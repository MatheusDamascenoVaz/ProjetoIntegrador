using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador.Screen
{
    public partial class Ajuda: Form
    {
        public Ajuda()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DocumentacaoScreen documentacaoScreen = new DocumentacaoScreen();
            documentacaoScreen.ShowDialog();
        }

        private void lblManualdeUso_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Define a URL que será aberta
                string url = "https://github.com/MatheusDamascenoVaz/ProjetoIntegrador/blob/master/ProjetoIntegrador/ProjetoIntegrador/Resources/EstoqueMaster_manual_de_uso.pdf";

                // Garante que o link seja tratado como visitado
                lblManualdeUso.LinkVisited = true;

                // Abre o URL no navegador padrão
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível abrir o link: {ex.Message}", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
