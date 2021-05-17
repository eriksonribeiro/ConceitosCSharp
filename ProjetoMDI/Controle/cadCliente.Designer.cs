namespace ProjetoMDI
{
    partial class frmCliente
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
            this.btnCadFornecedor = new System.Windows.Forms.Button();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnCadFornecedor
            // 
            this.btnCadFornecedor.Location = new System.Drawing.Point(42, 84);
            this.btnCadFornecedor.Name = "btnCadFornecedor";
            this.btnCadFornecedor.Size = new System.Drawing.Size(75, 23);
            this.btnCadFornecedor.TabIndex = 0;
            this.btnCadFornecedor.Text = "button1";
            this.btnCadFornecedor.UseVisualStyleBackColor = true;
            this.btnCadFornecedor.Click += new System.EventHandler(this.btnCadFornecedor_Click);
            // 
            // pnContainer
            // 
            this.pnContainer.Location = new System.Drawing.Point(349, 111);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(496, 373);
            this.pnContainer.TabIndex = 1;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.pnContainer);
            this.Controls.Add(this.btnCadFornecedor);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCliente";
            this.Text = "Cadastro de Cliente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadFornecedor;
        private System.Windows.Forms.Panel pnContainer;
    }
}