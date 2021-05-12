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
    public partial class frmRodriggoMendesDosSantos_CC : Form
    {
        public frmRodriggoMendesDosSantos_CC()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                long.Parse(txtCC.Text.Replace(" ", ""));
            }
            catch
            {
                MessageBox.Show("Um cartão de crédito contém 16 números\nVerifique o número inserido e tente novamente");
                txtCC.Clear();
                txtCC.Focus();
                return;
            }

            if (txtCC.Text.Replace(" ", "").Length != 16)
            {
                MessageBox.Show("Um cartão de crédito contém 16 números\nVerifique o número inserido e tente novamente");
                txtCC.Clear();
                txtCC.Focus();
                return;
            }

            clsRodriggoMendesDosSantos_CC cc = new clsRodriggoMendesDosSantos_CC();
            if (!cc.verificacao(txtCC.Text.Replace(" ","")))
            {
                lblObs.Text = "O cartão de crédito " + txtCC.Text + " é falso";
            }

            else
	        {
                lblObs.Text = "O cartão de crédito " + txtCC.Text + " é verdadeiro";
	        }
        }
    }
}
