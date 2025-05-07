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
            this.imgRelatorio = new System.Windows.Forms.PictureBox();
            this.imgProduto = new System.Windows.Forms.PictureBox();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.imgVenda = new System.Windows.Forms.PictureBox();
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
            this.imgAjuda = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRelatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVenda)).BeginInit();
            this.pnlUsuarios.SuspendLayout();
            this.pnlVendas.SuspendLayout();
            this.pnlProdutos.SuspendLayout();
            this.pnlRelatorios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAjuda)).BeginInit();
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
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(108, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seja Bem Vindo (a)";
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(106)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.lblUserLogado);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.imgLogout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1384, 100);
            this.panel1.TabIndex = 8;
            // 
            // lblUserLogado
            // 
            this.lblUserLogado.AutoSize = true;
            this.lblUserLogado.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLogado.ForeColor = System.Drawing.Color.Black;
            this.lblUserLogado.Location = new System.Drawing.Point(399, 29);
            this.lblUserLogado.Name = "lblUserLogado";
            this.lblUserLogado.Size = new System.Drawing.Size(0, 33);
            this.lblUserLogado.TabIndex = 8;
            // 
            // imgLogout
            // 
            this.imgLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgLogout.Image = global::ProjetoIntegrador.Properties.Resources.sair;
            this.imgLogout.Location = new System.Drawing.Point(1300, 20);
            this.imgLogout.Name = "imgLogout";
            this.imgLogout.Size = new System.Drawing.Size(60, 60);
            this.imgLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogout.TabIndex = 6;
            this.imgLogout.TabStop = false;
            this.imgLogout.Click += new System.EventHandler(this.imgLogout_Click);
            // 
            // imgRelatorio
            // 
            this.imgRelatorio.BackColor = System.Drawing.Color.Transparent;
            this.imgRelatorio.Image = global::ProjetoIntegrador.Properties.Resources.product_durability;
            this.imgRelatorio.Location = new System.Drawing.Point(10, 10);
            this.imgRelatorio.Name = "imgRelatorio";
            this.imgRelatorio.Size = new System.Drawing.Size(130, 130);
            this.imgRelatorio.TabIndex = 9;
            this.imgRelatorio.TabStop = false;
            this.imgRelatorio.Click += new System.EventHandler(this.pnlRelatorios_Click);
            // 
            // imgProduto
            // 
            this.imgProduto.Image = global::ProjetoIntegrador.Properties.Resources.produtos;
            this.imgProduto.Location = new System.Drawing.Point(10, 10);
            this.imgProduto.Name = "imgProduto";
            this.imgProduto.Size = new System.Drawing.Size(130, 130);
            this.imgProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProduto.TabIndex = 3;
            this.imgProduto.TabStop = false;
            this.imgProduto.Click += new System.EventHandler(this.pnlProdutos_Click);
            // 
            // imgUser
            // 
            this.imgUser.Image = global::ProjetoIntegrador.Properties.Resources.adicionar_usuario;
            this.imgUser.Location = new System.Drawing.Point(10, 10);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(130, 130);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUser.TabIndex = 5;
            this.imgUser.TabStop = false;
            this.imgUser.Click += new System.EventHandler(this.pnlUsuarios_Click);
            // 
            // imgVenda
            // 
            this.imgVenda.Image = global::ProjetoIntegrador.Properties.Resources.vendas;
            this.imgVenda.Location = new System.Drawing.Point(10, 10);
            this.imgVenda.Name = "imgVenda";
            this.imgVenda.Size = new System.Drawing.Size(130, 130);
            this.imgVenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgVenda.TabIndex = 4;
            this.imgVenda.TabStop = false;
            this.imgVenda.Click += new System.EventHandler(this.pnlVendas_Click);
            // 
            // pnlUsuarios
            // 
            this.pnlUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUsuarios.Controls.Add(this.lblMainUsuarioDescricao);
            this.pnlUsuarios.Controls.Add(this.lblMainUsuario);
            this.pnlUsuarios.Controls.Add(this.imgUser);
            this.pnlUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.pnlVendas.Controls.Add(this.imgVenda);
            this.pnlVendas.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.pnlProdutos.Controls.Add(this.imgProduto);
            this.pnlProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.pnlRelatorios.Controls.Add(this.imgRelatorio);
            this.pnlRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // imgAjuda
            // 
            this.imgAjuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgAjuda.Image = global::ProjetoIntegrador.Properties.Resources.ajuda;
            this.imgAjuda.Location = new System.Drawing.Point(1300, 116);
            this.imgAjuda.Name = "imgAjuda";
            this.imgAjuda.Size = new System.Drawing.Size(60, 60);
            this.imgAjuda.TabIndex = 14;
            this.imgAjuda.TabStop = false;
            this.imgAjuda.Click += new System.EventHandler(this.imgAjuda_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1384, 711);
            this.Controls.Add(this.imgAjuda);
            this.Controls.Add(this.pnlVendas);
            this.Controls.Add(this.pnlUsuarios);
            this.Controls.Add(this.pnlRelatorios);
            this.Controls.Add(this.pnlProdutos);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRelatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVenda)).EndInit();
            this.pnlUsuarios.ResumeLayout(false);
            this.pnlUsuarios.PerformLayout();
            this.pnlVendas.ResumeLayout(false);
            this.pnlVendas.PerformLayout();
            this.pnlProdutos.ResumeLayout(false);
            this.pnlProdutos.PerformLayout();
            this.pnlRelatorios.ResumeLayout(false);
            this.pnlRelatorios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAjuda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox imgProduto;
        private System.Windows.Forms.PictureBox imgVenda;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PictureBox imgUser;
        private System.Windows.Forms.PictureBox imgLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUserLogado;
        private System.Windows.Forms.PictureBox imgRelatorio;
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
        private System.Windows.Forms.PictureBox imgAjuda;
    }
}