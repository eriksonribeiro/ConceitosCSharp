using System;
using System.Windows.Forms;

namespace ProjetoMDI
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void itemCadCliente_Click(object sender, EventArgs e)
        {
                var cadCliente = new frmCliente
                {
                    MdiParent = this
                };
                cadCliente.Show();
        }

        private void itemCadFornecedor_Click(object sender, EventArgs e)
        {
            var cadFornecedor = new frmFornecedor
            {
                MdiParent = this
            };
            cadFornecedor.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            foreach (var control in this.Controls)
            {
                if (control is MdiClient)
                {
                  // control.BackColor = Color.Blue;
                    break;
                }
                    
            }
        }
    }
}
