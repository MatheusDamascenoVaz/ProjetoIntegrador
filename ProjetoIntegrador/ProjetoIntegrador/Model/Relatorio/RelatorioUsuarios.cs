using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using ProjetoIntegrador.Services;

public class RelatorioUsuariosMySQL

{

    public DatabaseService _databaseService;

    public RelatorioUsuariosMySQL(DatabaseService databaseService)
    {
        _databaseService = databaseService;
    }

    public void GerarRelatorioUsuarios()
    {
        // Configuração do documento PDF
        Document doc = new Document(PageSize.A4.Rotate());
        doc.SetMargins(20, 20, 20, 20);

        // Definir onde salvar o arquivo
        SaveFileDialog saveFileDialog = new SaveFileDialog
        {
            Filter = "PDF files (*.pdf)|*.pdf",
            Title = "Salvar Relatório de Produtos Vencidos",
            FileName = $"RelatorioUsuarios_{DateTime.Now:yyyyMMdd}.pdf"
        };

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                // Criar o arquivo PDF
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                doc.Open();

                // Adicionar título
                Paragraph titulo = new Paragraph("RELATÓRIO DE USUÁRIOS",
                    new Font(Font.FontFamily.HELVETICA, 16, Font.BOLD));
                titulo.Alignment = Element.ALIGN_CENTER;
                titulo.SpacingAfter = 20;
                doc.Add(titulo);

                // Adicionar data de emissão
                Paragraph dataEmissao = new Paragraph($"Emitido em: {DateTime.Now:dd/MM/yyyy HH:mm}",
                    new Font(Font.FontFamily.HELVETICA, 10));
                dataEmissao.SpacingAfter = 20;
                doc.Add(dataEmissao);

                // Buscar dados no banco usando o DatabaseService
                DataTable dt = GetUsuarios();

                // Verificar se há dados
                if (dt == null || dt.Rows.Count == 0)
                {
                    Paragraph semDados = new Paragraph("Nenhum produto vencido encontrado.",
                        new Font(Font.FontFamily.HELVETICA, 12));
                    semDados.Alignment = Element.ALIGN_CENTER;
                    doc.Add(semDados);
                }
                else
                {
                    // Criar tabela no PDF
                    PdfPTable table = new PdfPTable(dt.Columns.Count);
                    table.WidthPercentage = 100;

                    // Adicionar cabeçalhos
                    foreach (DataColumn column in dt.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName,
                            new Font(Font.FontFamily.HELVETICA, 10, Font.BOLD)));
                        cell.BackgroundColor = new BaseColor(200, 200, 200);
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }

                    // Adicionar dados
                    foreach (DataRow row in dt.Rows)
                    {
                        foreach (object item in row.ItemArray)
                        {
                            table.AddCell(new Phrase(item?.ToString() ?? string.Empty,
                                new Font(Font.FontFamily.HELVETICA, 9)));
                        }
                    }

                    doc.Add(table);

                    // Adicionar rodapé com quantidade de itens
                    Paragraph rodape = new Paragraph($"Total de usuários ativos: {dt.Rows.Count}",
                        new Font(Font.FontFamily.HELVETICA, 10, Font.ITALIC));
                    rodape.SpacingBefore = 20;
                    doc.Add(rodape);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar relatório: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                doc.Close();
            }
        }
    }

    private DataTable GetUsuarios()
    {
        string query = @"
        SELECT * FROM usuarios 
        WHERE status = 1 ";
        

        try
        {
            // Verificar se o DatabaseService está configurado corretamente
            if (_databaseService == null)
            {
                throw new ArgumentNullException(nameof(_databaseService), "O serviço de banco de dados não foi inicializado");
            }

            // Executar a consulta
            using (MySqlDataReader dataReader = _databaseService.ExecuteQuery(query))
            {

                DataTable dt = new DataTable();

                dt.Load(dataReader);

                return dt;
            }


        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao buscar produtos: {ex.Message}", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return new DataTable(); // Retorna tabela vazia em caso de erro
        }
    }
}