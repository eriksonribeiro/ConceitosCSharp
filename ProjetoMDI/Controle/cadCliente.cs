using System;
using System.Windows.Forms;

namespace ProjetoMDI
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void AbrirFormInPanel(object FForm)
        {
            if (this.pnContainer.Controls.Count > 0)
                this.pnContainer.Controls.RemoveAt(0);
            Form form = FForm as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnContainer.Controls.Add(form);
            this.pnContainer.Tag = form;
            form.Show();
        }

        private void btnCadFornecedor_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmFornecedor());
        }
    }
}
