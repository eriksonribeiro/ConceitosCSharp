namespace ProjetoMDI
{
    partial class frmMenu
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
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.menuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCadCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCadFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastros});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(933, 24);
            this.msMenu.TabIndex = 1;
            // 
            // menuCadastros
            // 
            this.menuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCadCliente,
            this.itemCadFornecedor});
            this.menuCadastros.Name = "menuCadastros";
            this.menuCadastros.Size = new System.Drawing.Size(66, 20);
            this.menuCadastros.Text = "Cadastro";
            // 
            // itemCadCliente
            // 
            this.itemCadCliente.Name = "itemCadCliente";
            this.itemCadCliente.Size = new System.Drawing.Size(180, 22);
            this.itemCadCliente.Text = "Cliente";
            this.itemCadCliente.Click += new System.EventHandler(this.itemCadCliente_Click);
            // 
            // itemCadFornecedor
            // 
            this.itemCadFornecedor.Name = "itemCadFornecedor";
            this.itemCadFornecedor.Size = new System.Drawing.Size(180, 22);
            this.itemCadFornecedor.Text = "Fornecedor";
            this.itemCadFornecedor.Click += new System.EventHandler(this.itemCadFornecedor_Click);
            // 
            // frmMenu
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.msMenu);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenu;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema MDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem menuCadastros;
        private System.Windows.Forms.ToolStripMenuItem itemCadCliente;
        private System.Windows.Forms.ToolStripMenuItem itemCadFornecedor;
    }
}