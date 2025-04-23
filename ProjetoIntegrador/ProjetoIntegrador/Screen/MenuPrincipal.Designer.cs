namespace ProjetoIntegrador.Screen
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUserLogado = new System.Windows.Forms.Label();
            this.imgLogout = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlUsuarios = new System.Windows.Forms.Panel();
            this.lblMainUsuarioDescricao = new System.Windows.Forms.Label();
            this.lblMainUsuario = new System.Windows.Forms.Label();
            this.pnlVendas = new System.Windows.Forms.Panel();
            this.lblMainVendaDescricao = new System.Windows.Forms.Label();
            this.lblMainVendas = new System.Windows.Forms.Label();
            this.pnlProdutos = new System.Windows.Forms.Panel();
            this.lblMainProdutoDescricao = new System.Windows.Forms.Label();
            this.lblMainProduto = new System.Windows.Forms.Label();
            this.pnlRelatorios = new System.Windows.Forms.Panel();
            this.lblMainRelatorioDescricao = new System.Windows.Forms.Label();
            this.lblMainRelatorio = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlUsuarios.SuspendLayout();
            this.pnlVendas.SuspendLayout();
            this.pnlProdutos.SuspendLayout();
            this.pnlRelatorios.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seja Bem Vindo (a)";
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.lblUserLogado);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.imgLogout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1384, 100);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblUserLogado
            // 
            this.lblUserLogado.AutoSize = true;
            this.lblUserLogado.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLogado.Location = new System.Drawing.Point(399, 29);
            this.lblUserLogado.Name = "lblUserLogado";
            this.lblUserLogado.Size = new System.Drawing.Size(0, 33);
            this.lblUserLogado.TabIndex = 8;
            // 
            // imgLogout
            // 
            this.imgLogout.Image = global::ProjetoIntegrador.Properties.Resources.sair;
            this.imgLogout.Location = new System.Drawing.Point(1300, 20);
            this.imgLogout.Name = "imgLogout";
            this.imgLogout.Size = new System.Drawing.Size(60, 60);
            this.imgLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogout.TabIndex = 6;
            this.imgLogout.TabStop = false;
            this.imgLogout.Click += new System.EventHandler(this.imgLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProjetoIntegrador.Properties.Resources.product_durability;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pnlRelatorios_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjetoIntegrador.Properties.Resources.produtos;
            this.pictureBox2.Location = new System.Drawing.Point(10, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pnlProdutos_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProjetoIntegrador.Properties.Resources.adicionar_usuario;
            this.pictureBox4.Location = new System.Drawing.Point(10, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(130, 130);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pnlUsuarios_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProjetoIntegrador.Properties.Resources.vendas;
            this.pictureBox3.Location = new System.Drawing.Point(10, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 130);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pnlVendas_Click);
            // 
            // pnlUsuarios
            // 
            this.pnlUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUsuarios.Controls.Add(this.lblMainUsuarioDescricao);
            this.pnlUsuarios.Controls.Add(this.lblMainUsuario);
            this.pnlUsuarios.Controls.Add(this.pictureBox4);
            this.pnlUsuarios.Location = new System.Drawing.Point(100, 200);
            this.pnlUsuarios.Name = "pnlUsuarios";
            this.pnlUsuarios.Size = new System.Drawing.Size(550, 150);
            this.pnlUsuarios.TabIndex = 10;
            this.pnlUsuarios.Click += new System.EventHandler(this.pnlUsuarios_Click);
            // 
            // lblMainUsuarioDescricao
            // 
            this.lblMainUsuarioDescricao.AutoSize = true;
            this.lblMainUsuarioDescricao.Location = new System.Drawing.Point(170, 50);
            this.lblMainUsuarioDescricao.Name = "lblMainUsuarioDescricao";
            this.lblMainUsuarioDescricao.Size = new System.Drawing.Size(349, 13);
            this.lblMainUsuarioDescricao.TabIndex = 7;
            this.lblMainUsuarioDescricao.Text = "•\tAdiciona, gerencia e remove a entrada de novos usuários da aplicação";
            this.lblMainUsuarioDescricao.Click += new System.EventHandler(this.pnlUsuarios_Click);
            // 
            // lblMainUsuario
            // 
            this.lblMainUsuario.AutoSize = true;
            this.lblMainUsuario.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainUsuario.Location = new System.Drawing.Point(170, 15);
            this.lblMainUsuario.Name = "lblMainUsuario";
            this.lblMainUsuario.Size = new System.Drawing.Size(189, 24);
            this.lblMainUsuario.TabIndex = 6;
            this.lblMainUsuario.Text = "Adicionar Usuário";
            this.lblMainUsuario.Click += new System.EventHandler(this.pnlUsuarios_Click);
            // 
            // pnlVendas
            // 
            this.pnlVendas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVendas.Controls.Add(this.lblMainVendaDescricao);
            this.pnlVendas.Controls.Add(this.lblMainVendas);
            this.pnlVendas.Controls.Add(this.pictureBox3);
            this.pnlVendas.Location = new System.Drawing.Point(750, 200);
            this.pnlVendas.Name = "pnlVendas";
            this.pnlVendas.Size = new System.Drawing.Size(550, 150);
            this.pnlVendas.TabIndex = 11;
            this.pnlVendas.Click += new System.EventHandler(this.pnlVendas_Click);
            // 
            // lblMainVendaDescricao
            // 
            this.lblMainVendaDescricao.AutoSize = true;
            this.lblMainVendaDescricao.Location = new System.Drawing.Point(170, 50);
            this.lblMainVendaDescricao.Name = "lblMainVendaDescricao";
            this.lblMainVendaDescricao.Size = new System.Drawing.Size(325, 13);
            this.lblMainVendaDescricao.TabIndex = 8;
            this.lblMainVendaDescricao.Text = "•\tTerminal para a inserção das vendas e emissão de comprovantes ";
            this.lblMainVendaDescricao.Click += new System.EventHandler(this.pnlVendas_Click);
            // 
            // lblMainVendas
            // 
            this.lblMainVendas.AutoSize = true;
            this.lblMainVendas.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainVendas.Location = new System.Drawing.Point(170, 15);
            this.lblMainVendas.Name = "lblMainVendas";
            this.lblMainVendas.Size = new System.Drawing.Size(174, 24);
            this.lblMainVendas.TabIndex = 5;
            this.lblMainVendas.Text = "Adicionar Venda";
            this.lblMainVendas.Click += new System.EventHandler(this.pnlVendas_Click);
            // 
            // pnlProdutos
            // 
            this.pnlProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProdutos.Controls.Add(this.lblMainProdutoDescricao);
            this.pnlProdutos.Controls.Add(this.lblMainProduto);
            this.pnlProdutos.Controls.Add(this.pictureBox2);
            this.pnlProdutos.Location = new System.Drawing.Point(100, 450);
            this.pnlProdutos.Name = "pnlProdutos";
            this.pnlProdutos.Size = new System.Drawing.Size(550, 150);
            this.pnlProdutos.TabIndex = 12;
            this.pnlProdutos.Click += new System.EventHandler(this.pnlProdutos_Click);
            // 
            // lblMainProdutoDescricao
            // 
            this.lblMainProdutoDescricao.AutoSize = true;
            this.lblMainProdutoDescricao.Location = new System.Drawing.Point(170, 50);
            this.lblMainProdutoDescricao.Name = "lblMainProdutoDescricao";
            this.lblMainProdutoDescricao.Size = new System.Drawing.Size(315, 13);
            this.lblMainProdutoDescricao.TabIndex = 8;
            this.lblMainProdutoDescricao.Text = "•\tPainel para adição, edição e remoção de produtos da aplicação";
            this.lblMainProdutoDescricao.Click += new System.EventHandler(this.pnlProdutos_Click);
            // 
            // lblMainProduto
            // 
            this.lblMainProduto.AutoSize = true;
            this.lblMainProduto.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainProduto.Location = new System.Drawing.Point(170, 15);
            this.lblMainProduto.Name = "lblMainProduto";
            this.lblMainProduto.Size = new System.Drawing.Size(193, 24);
            this.lblMainProduto.TabIndex = 4;
            this.lblMainProduto.Text = "Adicionar Produto";
            this.lblMainProduto.Click += new System.EventHandler(this.pnlProdutos_Click);
            // 
            // pnlRelatorios
            // 
            this.pnlRelatorios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRelatorios.Controls.Add(this.lblMainRelatorioDescricao);
            this.pnlRelatorios.Controls.Add(this.lblMainRelatorio);
            this.pnlRelatorios.Controls.Add(this.pictureBox1);
            this.pnlRelatorios.Location = new System.Drawing.Point(750, 450);
            this.pnlRelatorios.Name = "pnlRelatorios";
            this.pnlRelatorios.Size = new System.Drawing.Size(550, 150);
            this.pnlRelatorios.TabIndex = 13;
            this.pnlRelatorios.Click += new System.EventHandler(this.pnlRelatorios_Click);
            // 
            // lblMainRelatorioDescricao
            // 
            this.lblMainRelatorioDescricao.AutoSize = true;
            this.lblMainRelatorioDescricao.Location = new System.Drawing.Point(170, 50);
            this.lblMainRelatorioDescricao.Name = "lblMainRelatorioDescricao";
            this.lblMainRelatorioDescricao.Size = new System.Drawing.Size(176, 13);
            this.lblMainRelatorioDescricao.TabIndex = 11;
            this.lblMainRelatorioDescricao.Text = "•\tCriação de relatórios customizados";
            this.lblMainRelatorioDescricao.Click += new System.EventHandler(this.pnlRelatorios_Click);
            // 
            // lblMainRelatorio
            // 
            this.lblMainRelatorio.AutoSize = true;
            this.lblMainRelatorio.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainRelatorio.Location = new System.Drawing.Point(170, 15);
            this.lblMainRelatorio.Name = "lblMainRelatorio";
            this.lblMainRelatorio.Size = new System.Drawing.Size(162, 24);
            this.lblMainRelatorio.TabIndex = 10;
            this.lblMainRelatorio.Text = "Gerar Relatório";
            this.lblMainRelatorio.Click += new System.EventHandler(this.pnlRelatorios_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1384, 711);
            this.Controls.Add(this.pnlVendas);
            this.Controls.Add(this.pnlUsuarios);
            this.Controls.Add(this.pnlRelatorios);
            this.Controls.Add(this.pnlProdutos);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlUsuarios.ResumeLayout(false);
            this.pnlUsuarios.PerformLayout();
            this.pnlVendas.ResumeLayout(false);
            this.pnlVendas.PerformLayout();
            this.pnlProdutos.ResumeLayout(false);
            this.pnlProdutos.PerformLayout();
            this.pnlRelatorios.ResumeLayout(false);
            this.pnlRelatorios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox imgLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUserLogado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlUsuarios;
        private System.Windows.Forms.Panel pnlVendas;
        private System.Windows.Forms.Panel pnlProdutos;
        private System.Windows.Forms.Panel pnlRelatorios;
        private System.Windows.Forms.Label lblMainUsuario;
        private System.Windows.Forms.Label lblMainVendas;
        private System.Windows.Forms.Label lblMainProduto;
        private System.Windows.Forms.Label lblMainRelatorio;
        private System.Windows.Forms.Label lblMainUsuarioDescricao;
        private System.Windows.Forms.Label lblMainVendaDescricao;
        private System.Windows.Forms.Label lblMainProdutoDescricao;
        private System.Windows.Forms.Label lblMainRelatorioDescricao;
    }
}