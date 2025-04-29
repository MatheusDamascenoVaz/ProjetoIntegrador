namespace ProjetoIntegrador
{
    partial class LoginScreen
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblLoginEmail = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblRedefinirSenha = new System.Windows.Forms.Label();
            this.pnlLoginMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLoginMain = new System.Windows.Forms.Label();
            this.pnlLoginSenha = new System.Windows.Forms.Panel();
            this.pnlLoginEmail = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlLoginMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlLoginSenha.SuspendLayout();
            this.pnlLoginEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(51)))), ((int)(((byte)(80)))));
            this.btnLogin.Location = new System.Drawing.Point(120, 220);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(160, 40);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Location = new System.Drawing.Point(40, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(224, 13);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Location = new System.Drawing.Point(40, 3);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(224, 13);
            this.txtSenha.TabIndex = 2;
            // 
            // lblLoginEmail
            // 
            this.lblLoginEmail.AutoSize = true;
            this.lblLoginEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLoginEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(51)))), ((int)(((byte)(80)))));
            this.lblLoginEmail.Location = new System.Drawing.Point(1, 3);
            this.lblLoginEmail.Name = "lblLoginEmail";
            this.lblLoginEmail.Size = new System.Drawing.Size(35, 13);
            this.lblLoginEmail.TabIndex = 5;
            this.lblLoginEmail.Text = "Email:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(51)))), ((int)(((byte)(80)))));
            this.lbl.Location = new System.Drawing.Point(1, 3);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(41, 13);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "Senha:";
            // 
            // lblRedefinirSenha
            // 
            this.lblRedefinirSenha.AutoSize = true;
            this.lblRedefinirSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblRedefinirSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRedefinirSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(51)))), ((int)(((byte)(80)))));
            this.lblRedefinirSenha.Location = new System.Drawing.Point(53, 175);
            this.lblRedefinirSenha.Name = "lblRedefinirSenha";
            this.lblRedefinirSenha.Size = new System.Drawing.Size(108, 13);
            this.lblRedefinirSenha.TabIndex = 7;
            this.lblRedefinirSenha.Text = "Esqueci minha senha";
            this.lblRedefinirSenha.Click += new System.EventHandler(this.lblRedefinirSenha_Click);
            // 
            // pnlLoginMain
            // 
            this.pnlLoginMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.pnlLoginMain.Controls.Add(this.pictureBox1);
            this.pnlLoginMain.Controls.Add(this.lblLoginMain);
            this.pnlLoginMain.Controls.Add(this.pnlLoginSenha);
            this.pnlLoginMain.Controls.Add(this.pnlLoginEmail);
            this.pnlLoginMain.Controls.Add(this.lblRedefinirSenha);
            this.pnlLoginMain.Controls.Add(this.btnLogin);
            this.pnlLoginMain.Location = new System.Drawing.Point(411, 62);
            this.pnlLoginMain.Name = "pnlLoginMain";
            this.pnlLoginMain.Size = new System.Drawing.Size(400, 329);
            this.pnlLoginMain.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoIntegrador.Properties.Resources.EstoqueMasterLogo;
            this.pictureBox1.Location = new System.Drawing.Point(230, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblLoginMain
            // 
            this.lblLoginMain.AutoSize = true;
            this.lblLoginMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(51)))), ((int)(((byte)(80)))));
            this.lblLoginMain.Location = new System.Drawing.Point(114, 35);
            this.lblLoginMain.Name = "lblLoginMain";
            this.lblLoginMain.Size = new System.Drawing.Size(99, 31);
            this.lblLoginMain.TabIndex = 10;
            this.lblLoginMain.Text = "LOGIN";
            // 
            // pnlLoginSenha
            // 
            this.pnlLoginSenha.BackColor = System.Drawing.Color.White;
            this.pnlLoginSenha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLoginSenha.Controls.Add(this.txtSenha);
            this.pnlLoginSenha.Controls.Add(this.lbl);
            this.pnlLoginSenha.Location = new System.Drawing.Point(50, 150);
            this.pnlLoginSenha.Name = "pnlLoginSenha";
            this.pnlLoginSenha.Size = new System.Drawing.Size(300, 20);
            this.pnlLoginSenha.TabIndex = 9;
            // 
            // pnlLoginEmail
            // 
            this.pnlLoginEmail.BackColor = System.Drawing.Color.White;
            this.pnlLoginEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLoginEmail.Controls.Add(this.txtEmail);
            this.pnlLoginEmail.Controls.Add(this.lblLoginEmail);
            this.pnlLoginEmail.Location = new System.Drawing.Point(50, 100);
            this.pnlLoginEmail.Name = "pnlLoginEmail";
            this.pnlLoginEmail.Size = new System.Drawing.Size(300, 20);
            this.pnlLoginEmail.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(61, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(611, 444);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // LoginScreen
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.pnlLoginMain);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.pnlLoginMain.ResumeLayout(false);
            this.pnlLoginMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlLoginSenha.ResumeLayout(false);
            this.pnlLoginSenha.PerformLayout();
            this.pnlLoginEmail.ResumeLayout(false);
            this.pnlLoginEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblLoginEmail;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblRedefinirSenha;
        private System.Windows.Forms.Panel pnlLoginMain;
        private System.Windows.Forms.Panel pnlLoginEmail;
        private System.Windows.Forms.Panel pnlLoginSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLoginMain;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

