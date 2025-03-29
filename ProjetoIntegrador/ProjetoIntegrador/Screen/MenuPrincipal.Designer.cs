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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMenuUsers = new System.Windows.Forms.Button();
            this.btnMenuProducts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(701, 29);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMenuUsers
            // 
            this.btnMenuUsers.Location = new System.Drawing.Point(84, 87);
            this.btnMenuUsers.Name = "btnMenuUsers";
            this.btnMenuUsers.Size = new System.Drawing.Size(153, 23);
            this.btnMenuUsers.TabIndex = 1;
            this.btnMenuUsers.Text = "Adicionar/Remover Usuários";
            this.btnMenuUsers.UseVisualStyleBackColor = true;
            this.btnMenuUsers.Click += new System.EventHandler(this.btnMenuUsers_Click);
            // 
            // btnMenuProducts
            // 
            this.btnMenuProducts.Location = new System.Drawing.Point(84, 155);
            this.btnMenuProducts.Name = "btnMenuProducts";
            this.btnMenuProducts.Size = new System.Drawing.Size(153, 23);
            this.btnMenuProducts.TabIndex = 2;
            this.btnMenuProducts.Text = "Adicionar/Remover Produtos";
            this.btnMenuProducts.UseVisualStyleBackColor = true;
            this.btnMenuProducts.Click += new System.EventHandler(this.btnMenuProducts_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMenuProducts);
            this.Controls.Add(this.btnMenuUsers);
            this.Controls.Add(this.btnLogout);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMenuUsers;
        private System.Windows.Forms.Button btnMenuProducts;
    }
}