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
    public partial class frmRodriggoMendesDosSantos_PISPASEP : Form
    {
        public frmRodriggoMendesDosSantos_PISPASEP()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            clsRodriggoMendesDosSantos_PISPASEP função = new clsRodriggoMendesDosSantos_PISPASEP();

            #region Validações

            if (txtNumero.Text == "")
            {
                MessageBox.Show("Insira o número do PIS ou PASEP e tente novamente!");
                txtNumero.Focus();
                return;
            }

            if (txtNumero.TextLength > 12)
            {
                MessageBox.Show("O número do PIS ou PASEP não é válido, tente novamente!");
                txtNumero.Focus();
                return;
            }

            #endregion

            função.gerarDigito(txtNumero.Text);

            lblObs.Text = função.textoOBS;
        }
    }
}
