using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador.Screen
{
    public partial class DocumentacaoScreen: Form
    {
        WebBrowser webBrowser1;
        public DocumentacaoScreen()
        {
            InitializeComponents();
            ShowPdfFromResources();


        }

        private void InitializeComponents()
        {
            this.Text = "Visualizador de PDF";
            this.Size = new System.Drawing.Size(800, 600);

            webBrowser1 = new WebBrowser();
            webBrowser1.Dock = DockStyle.Fill;
            this.Controls.Add(webBrowser1);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void DocumentacaoScreen_Load(object sender, EventArgs e)
        {

        }

        private void ShowPdfFromResources()
        {
            try
            {
                // 1. Obter o PDF dos recursos
                byte[] pdfBytes = Properties.Resources.DOCUMENTACAO_ESTOQUE_MASTER;

                // 2. Criar um arquivo temporário
                string tempFilePath = Path.GetTempFileName() + ".pdf";
                File.WriteAllBytes(tempFilePath, pdfBytes);

                // 3. Exibir no WebBrowser
                webBrowser1.Navigate(tempFilePath);

                // 4. Configurar para deletar o temporário quando fechar
                this.FormClosed += (s, e) => {
                    try { File.Delete(tempFilePath); }
                    catch { /* Ignora erros ao deletar */ }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar PDF: {ex.Message}");
            }
        }
    }
}
