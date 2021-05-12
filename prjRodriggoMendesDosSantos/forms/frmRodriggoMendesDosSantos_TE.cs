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
    public partial class frmRodriggoMendesDosSantos_TE : Form
    {
        public frmRodriggoMendesDosSantos_TE()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            clsRodriggoMendesDosSantos_TE gerarDigitos = new clsRodriggoMendesDosSantos_TE();
            
            long nTitulo;

            if (txtTitulo.TextLength == 11)
            {
                try
                {
                    nTitulo = long.Parse(txtTitulo.Text);
                }

                catch
                {
                    MessageBox.Show("Digite apenas caracteres numéricos\nInsira o número do título de eleitor");
                    return;
                }
            }

            else
            {
                MessageBox.Show("Um título de eleitor tem 11 números\n \nPor favor, verifique o número, insira o mesmo apenas com caracteres numéricos e tente novamente");
                txtTitulo.Clear();
                txtTitulo.Focus();
                return;
            }

            gerarDigitos.calcular(txtTitulo.Text);

            lblObs.Text = gerarDigitos.textoRetorno;
        }
    }
}
