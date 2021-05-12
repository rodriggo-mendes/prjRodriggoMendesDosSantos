using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjRodriggoMendesDosSantos.forms.classes;

namespace prjRodriggoMendesDosSantos.forms
{
    public partial class frmRodriggoMendesDosSantos_CNPJ : Form
    {
        public frmRodriggoMendesDosSantos_CNPJ()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtCNPJ.Text.Replace(".","").Replace("/","").Replace("-","").Length == 14)
            {
                try
                {
                    long.Parse(txtCNPJ.Text.Replace(".", "").Replace("/", "").Replace("-", ""));
                }

                catch
                {
                    MessageBox.Show("Um número de CNPJ tem 14 números\nPor favor, verifique o número e tente novamente");
                    txtCNPJ.Clear();
                    txtCNPJ.Focus();
                    return;
                }
            }

            else
            {
                MessageBox.Show("Um número de CNPJ tem 14 números\nPor favor, verifique o número e tente novamente");
                txtCNPJ.Clear();
                txtCNPJ.Focus();
                return;
            }

            clsRodriggoMendesDosSantos_CNPJ cnpj = new clsRodriggoMendesDosSantos_CNPJ();
            if (cnpj.validaCNPJ(txtCNPJ.Text.Replace(".", "").Replace("/", "").Replace("-", "")))
            {
                lblObs.Text = "O CNPJ "+ txtCNPJ.Text + " é verdadeiro";
            }

            else
            {
                lblObs.Text = "O CNPJ " + txtCNPJ.Text + " é falso";
            }    
        }
    }
}
