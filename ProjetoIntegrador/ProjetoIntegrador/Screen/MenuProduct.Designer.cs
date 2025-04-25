namespace ProjetoIntegrador.Screen
{
    partial class MenuProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuProduct));
            this.pnlDataGridProduto = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.btnAlterarProduto = new System.Windows.Forms.Button();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.btnAttDataGridProduto = new System.Windows.Forms.Button();
            this.btnBuscarProduto = new System.Windows.Forms.Button();
            this.lblBuscarProduto = new System.Windows.Forms.Label();
            this.txtBuscarProduto = new System.Windows.Forms.TextBox();
            this.pnlDataGridProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDataGridProduto
            // 
            this.pnlDataGridProduto.Controls.Add(this.dataGridView1);
            this.pnlDataGridProduto.Location = new System.Drawing.Point(50, 200);
            this.pnlDataGridProduto.Name = "pnlDataGridProduto";
            this.pnlDataGridProduto.Size = new System.Drawing.Size(1300, 600);
            this.pnlDataGridProduto.TabIndex = 1;
            this.pnlDataGridProduto.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDataGridProduto_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1300, 600);
            this.dataGridView1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(277, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(0, 0);
            this.button3.TabIndex = 4;
            this.button3.Text = "Remover Produto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.Location = new System.Drawing.Point(50, 50);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(150, 50);
            this.btnAddProduto.TabIndex = 7;
            this.btnAddProduto.Text = "Adicionar Produto";
            this.btnAddProduto.UseVisualStyleBackColor = true;
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // btnAlterarProduto
            // 
            this.btnAlterarProduto.Location = new System.Drawing.Point(250, 50);
            this.btnAlterarProduto.Name = "btnAlterarProduto";
            this.btnAlterarProduto.Size = new System.Drawing.Size(150, 50);
            this.btnAlterarProduto.TabIndex = 8;
            this.btnAlterarProduto.Text = "Alterar Produto";
            this.btnAlterarProduto.UseVisualStyleBackColor = true;
            this.btnAlterarProduto.Click += new System.EventHandler(this.btnAlterarProduto_Click);
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.Location = new System.Drawing.Point(450, 50);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(150, 50);
            this.btnRemoverProduto.TabIndex = 9;
            this.btnRemoverProduto.Text = "Remover Produto";
            this.btnRemoverProduto.UseVisualStyleBackColor = true;
            this.btnRemoverProduto.Click += new System.EventHandler(this.btnRemoverProduto_Click);
            // 
            // btnAttDataGridProduto
            // 
            this.btnAttDataGridProduto.Location = new System.Drawing.Point(650, 50);
            this.btnAttDataGridProduto.Name = "btnAttDataGridProduto";
            this.btnAttDataGridProduto.Size = new System.Drawing.Size(150, 50);
            this.btnAttDataGridProduto.TabIndex = 10;
            this.btnAttDataGridProduto.Text = "Atualizar Dados";
            this.btnAttDataGridProduto.UseVisualStyleBackColor = true;
            this.btnAttDataGridProduto.Click += new System.EventHandler(this.btnAttDataGridProduto_Click);
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.Location = new System.Drawing.Point(1200, 140);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(150, 50);
            this.btnBuscarProduto.TabIndex = 11;
            this.btnBuscarProduto.Text = "Buscar";
            this.btnBuscarProduto.UseVisualStyleBackColor = true;
            this.btnBuscarProduto.Click += new System.EventHandler(this.btnBuscarProduto_Click);
            // 
            // lblBuscarProduto
            // 
            this.lblBuscarProduto.AutoSize = true;
            this.lblBuscarProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarProduto.Location = new System.Drawing.Point(101, 157);
            this.lblBuscarProduto.Name = "lblBuscarProduto";
            this.lblBuscarProduto.Size = new System.Drawing.Size(230, 16);
            this.lblBuscarProduto.TabIndex = 12;
            this.lblBuscarProduto.Text = "Nome do Produto ou Código de Barras";
            this.lblBuscarProduto.Click += new System.EventHandler(this.lblBuscarProduto_Click);
            // 
            // txtBuscarProduto
            // 
            this.txtBuscarProduto.Location = new System.Drawing.Point(335, 156);
            this.txtBuscarProduto.Name = "txtBuscarProduto";
            this.txtBuscarProduto.Size = new System.Drawing.Size(800, 20);
            this.txtBuscarProduto.TabIndex = 13;
            this.txtBuscarProduto.TextChanged += new System.EventHandler(this.txtBuscarProduto_TextChanged);
            // 
            // MenuProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1384, 811);
            this.Controls.Add(this.txtBuscarProduto);
            this.Controls.Add(this.lblBuscarProduto);
            this.Controls.Add(this.btnBuscarProduto);
            this.Controls.Add(this.btnAttDataGridProduto);
            this.Controls.Add(this.btnRemoverProduto);
            this.Controls.Add(this.btnAlterarProduto);
            this.Controls.Add(this.btnAddProduto);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pnlDataGridProduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Produtos";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.pnlDataGridProduto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlDataGridProduto;

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAddProduto;
        private System.Windows.Forms.Button btnAlterarProduto;
        private System.Windows.Forms.Button btnRemoverProduto;
        private System.Windows.Forms.Button btnAttDataGridProduto;
        private System.Windows.Forms.Button btnBuscarProduto;
        private System.Windows.Forms.Label lblBuscarProduto;
        private System.Windows.Forms.TextBox txtBuscarProduto;
    }
}