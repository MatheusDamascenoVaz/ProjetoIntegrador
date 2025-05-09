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

        public AddRelatorio()
        {
            InitializeComponent();
            _databaseService = new DatabaseService();
            relatorio = new RelatorioValidadeMySQL(_databaseService);
            relatorioVencidos = new RelatorioProdutosVencidosMySQL(_databaseService);
            relatorioUsuarios = new RelatorioUsuariosMySQL(_databaseService);
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
    }
}