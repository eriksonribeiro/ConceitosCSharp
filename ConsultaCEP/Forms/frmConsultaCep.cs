using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaCEP
{
    public partial class frmConsultaCep : Form
    {
        public frmConsultaCep()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtConsulta.Text))
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var result  = ws.consultaCEP(txtConsulta.Text.Trim());

                        txtEstado.Text = result.uf;
                        txtCidade.Text = result.cidade;
                        txtBairro.Text = result.bairro;
                        txtLogradouro.Text = result.end;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
                MessageBox.Show("Informe um CEP!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtConsulta.Text = String.Empty;
            txtEstado.Text = String.Empty;
            txtCidade.Text = String.Empty;
            txtBairro.Text = String.Empty;
            txtLogradouro.Text = String.Empty;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtConsulta_Leave(object sender, EventArgs e)
        {
            btnConsultar_Click(sender, e);
        }
    }
}
