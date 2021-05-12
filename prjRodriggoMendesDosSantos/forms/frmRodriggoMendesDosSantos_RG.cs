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
    public partial class frmRodriggoMendesDosSantos_RG : Form
    {
        public frmRodriggoMendesDosSantos_RG()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            clsRodriggoMendesDosSantos_RG verif = new clsRodriggoMendesDosSantos_RG();

            if (!verif.verificaRG(txtRG.Text.Replace("-", "").Replace(".", "")))
            {
                lblOBS.Text = "O RG é inválido!";
            }
            else
            {
                lblOBS.Text = "O RG é correto!";
            }
        }
    }
}
