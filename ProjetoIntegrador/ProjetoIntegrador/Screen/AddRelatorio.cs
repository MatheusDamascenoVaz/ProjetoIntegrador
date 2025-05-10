using System;
using System.Windows.Forms;
using ProjetoIntegrador.Models;
using ProjetoIntegrador.Services;

namespace ProjetoIntegrador.Screen
{
    public partial class AddRelatorio : Form
    {
        public DatabaseService _databaseService;
        public RelatorioValidadeMySQL relatorio;
        public RelatorioProdutosVencidosMySQL relatorioVencidos;
        public RelatorioUsuariosMySQL relatorioUsuarios;
        public RelatorioProdutosEstoqueMySQL RelatorioEstoque;
        public RelatorioEntreDatasMySQL relatorioEntreDatas;

        public AddRelatorio()
        {
            InitializeComponent();
            _databaseService = new DatabaseService();
            relatorio = new RelatorioValidadeMySQL(_databaseService);
            relatorioVencidos = new RelatorioProdutosVencidosMySQL(_databaseService);
            relatorioUsuarios = new RelatorioUsuariosMySQL(_databaseService);
            RelatorioEstoque = new RelatorioProdutosEstoqueMySQL(_databaseService);
            relatorioEntreDatas = new RelatorioEntreDatasMySQL(_databaseService);
            this.FormClosing += ApplicationClose;
        }
        private void ApplicationClose(object sender, FormClosingEventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Cria e gera o relatório
                relatorio.GerarRelatorio60DiasValidade();

                MessageBox.Show("Relatório gerado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar relatório: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Cria e gera o relatório
                relatorioVencidos.GerarRelatorioProdutosVencidos();

                MessageBox.Show("Relatório gerado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar relatório: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Cria e gera o relatório
                relatorioUsuarios.GerarRelatorioUsuarios();

                MessageBox.Show("Relatório gerado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar relatório: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Cria e gera o relatório
                RelatorioEstoque.GerarRelatorioProdutosEstoque();

                MessageBox.Show("Relatório gerado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar relatório: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Obter as datas dos DateTimePickers
            DateTime dataInicio = dTimeInicio.Value; 
            DateTime dataFim = dTimeFinal.Value;   

            // Validar se a data final é maior ou igual à data inicial
            if (dataFim < dataInicio)
            {
                MessageBox.Show("A data final deve ser maior ou igual à data inicial!", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var relatorio = new RelatorioEntreDatasMySQL(_databaseService)
            {
                dataInicio = dataInicio,
                dataFim = dataFim
            };

            try
            {
                // Chamar o método para gerar o relatório
                relatorioEntreDatas.GerarRelatorioEntreDatas(dataInicio, dataFim );

                MessageBox.Show("Relatório gerado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar relatório: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}