namespace ProjetoIntegrador.Screen
{
    partial class MenuUser
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
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.lblBuscarUsuario = new System.Windows.Forms.Label();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.btnAttDataGridUsuario = new System.Windows.Forms.Button();
            this.btnRemoverUsuario = new System.Windows.Forms.Button();
            this.btnAlterarUsuario = new System.Windows.Forms.Button();
            this.btnAddUsuario = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pnlDataGridUsuario = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlDataGridUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Location = new System.Drawing.Point(335, 156);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(800, 20);
            this.txtBuscarUsuario.TabIndex = 22;
            this.txtBuscarUsuario.TextChanged += new System.EventHandler(this.txtBuscarUsuario_TextChanged);
            // 
            // lblBuscarUsuario
            // 
            this.lblBuscarUsuario.AutoSize = true;
            this.lblBuscarUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarUsuario.Location = new System.Drawing.Point(141, 157);
            this.lblBuscarUsuario.Name = "lblBuscarUsuario";
            this.lblBuscarUsuario.Size = new System.Drawing.Size(182, 16);
            this.lblBuscarUsuario.TabIndex = 21;
            this.lblBuscarUsuario.Text = "Nome de Usuário ou Matrícula";
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Location = new System.Drawing.Point(1200, 140);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(150, 50);
            this.btnBuscarUsuario.TabIndex = 20;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // btnAttDataGridUsuario
            // 
            this.btnAttDataGridUsuario.Location = new System.Drawing.Point(650, 50);
            this.btnAttDataGridUsuario.Name = "btnAttDataGridUsuario";
            this.btnAttDataGridUsuario.Size = new System.Drawing.Size(150, 50);
            this.btnAttDataGridUsuario.TabIndex = 19;
            this.btnAttDataGridUsuario.Text = "Atualizar Dados";
            this.btnAttDataGridUsuario.UseVisualStyleBackColor = true;
            // 
            // btnRemoverUsuario
            // 
            this.btnRemoverUsuario.Location = new System.Drawing.Point(450, 50);
            this.btnRemoverUsuario.Name = "btnRemoverUsuario";
            this.btnRemoverUsuario.Size = new System.Drawing.Size(150, 50);
            this.btnRemoverUsuario.TabIndex = 18;
            this.btnRemoverUsuario.Text = "Remover Usuário";
            this.btnRemoverUsuario.UseVisualStyleBackColor = true;
            // 
            // btnAlterarUsuario
            // 
            this.btnAlterarUsuario.Location = new System.Drawing.Point(250, 50);
            this.btnAlterarUsuario.Name = "btnAlterarUsuario";
            this.btnAlterarUsuario.Size = new System.Drawing.Size(150, 50);
            this.btnAlterarUsuario.TabIndex = 17;
            this.btnAlterarUsuario.Text = "Alterar Usuário";
            this.btnAlterarUsuario.UseVisualStyleBackColor = true;
            this.btnAlterarUsuario.Click += new System.EventHandler(this.btnAlterarUsuario_Click);
            // 
            // btnAddUsuario
            // 
            this.btnAddUsuario.Location = new System.Drawing.Point(50, 50);
            this.btnAddUsuario.Name = "btnAddUsuario";
            this.btnAddUsuario.Size = new System.Drawing.Size(150, 50);
            this.btnAddUsuario.TabIndex = 16;
            this.btnAddUsuario.Text = "Adicionar Usuário";
            this.btnAddUsuario.UseVisualStyleBackColor = true;
            this.btnAddUsuario.Click += new System.EventHandler(this.btnAddUsuario_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(269, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(0, 0);
            this.button3.TabIndex = 15;
            this.button3.Text = "Remover Produto";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pnlDataGridUsuario
            // 
            this.pnlDataGridUsuario.Controls.Add(this.dataGridView1);
            this.pnlDataGridUsuario.Location = new System.Drawing.Point(50, 200);
            this.pnlDataGridUsuario.Name = "pnlDataGridUsuario";
            this.pnlDataGridUsuario.Size = new System.Drawing.Size(1300, 600);
            this.pnlDataGridUsuario.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1300, 600);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MenuUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1384, 811);
            this.Controls.Add(this.txtBuscarUsuario);
            this.Controls.Add(this.lblBuscarUsuario);
            this.Controls.Add(this.btnBuscarUsuario);
            this.Controls.Add(this.btnAttDataGridUsuario);
            this.Controls.Add(this.btnRemoverUsuario);
            this.Controls.Add(this.btnAlterarUsuario);
            this.Controls.Add(this.btnAddUsuario);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pnlDataGridUsuario);
            this.Name = "MenuUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuUser";
            this.Load += new System.EventHandler(this.MenuUser_Load);
            this.pnlDataGridUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.Label lblBuscarUsuario;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Button btnAttDataGridUsuario;
        private System.Windows.Forms.Button btnRemoverUsuario;
        private System.Windows.Forms.Button btnAlterarUsuario;
        private System.Windows.Forms.Button btnAddUsuario;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnlDataGridUsuario;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}