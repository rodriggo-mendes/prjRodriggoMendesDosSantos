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
    public partial class frmRodriggoMendesDosSantos_CPF : Form
    {
        public frmRodriggoMendesDosSantos_CPF()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txtCPF.Text.Replace(" ","").Replace(".","").Replace("-","").Length == 11)
            {
                try
                {
                    long.Parse(txtCPF.Text.Replace(" ", "").Replace(".", "").Replace("-", ""));
                }

                catch
                {
                    MessageBox.Show("Um número de CPF tem 11 números\nPor favor, verifique o número e tente novamente");
                    txtCPF.Clear();
                    txtCPF.Focus();
                    return;
                }
            }

            else
            {
                MessageBox.Show("Um número de CPF tem 11 números\nPor favor, verifique o número e tente novamente");
                txtCPF.Clear();
                txtCPF.Focus();
                return;
            }

            clsRodriggoMendesDosSantos_CPF cpf = new clsRodriggoMendesDosSantos_CPF();
            if (cpf.validaCPF(txtCPF.Text.Replace(" ", "").Replace(".", "").Replace("-", "")))
            {
                lblObs.Text = "O CPF " + txtCPF.Text + " é verdadeiro";
            }

            else
            {
                lblObs.Text = "O CPF " + txtCPF.Text + " é falso";
            }                   
        }
    }
}
