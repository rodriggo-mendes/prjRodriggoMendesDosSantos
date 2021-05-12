using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjRodriggoMendesDosSantos.forms;

namespace prjRodriggoMendesDosSantos
{
    public partial class frmRodriggoMendesDosSantos : Form
    {
        public frmRodriggoMendesDosSantos()
        {
            InitializeComponent();
        }

        private void msiCPF_Click(object sender, EventArgs e)
        {
            frmRodriggoMendesDosSantos_CPF cpf = new frmRodriggoMendesDosSantos_CPF();
            foreach (Form filho in this.MdiChildren)
            {
                if (filho.GetType() == typeof(frmRodriggoMendesDosSantos_CPF))
                {
                    filho.Focus();
                    return;
                }
            }
            cpf.MdiParent = this;
            cpf.Show();
        }

        private void frmRodriggoMendesDosSantos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void msiCNPJ_Click(object sender, EventArgs e)
        {
            frmRodriggoMendesDosSantos_CNPJ cnpj = new frmRodriggoMendesDosSantos_CNPJ();
            foreach (Form filho in this.MdiChildren)
            {
                if (filho.GetType() == typeof(frmRodriggoMendesDosSantos_CNPJ))
                {
                    filho.Focus();
                    return;
                }
            }
            cnpj.MdiParent = this;
            cnpj.Show();
        }

        private void msiCC_Click(object sender, EventArgs e)
        {
            frmRodriggoMendesDosSantos_CC cc = new frmRodriggoMendesDosSantos_CC();
            foreach (Form filho in this.MdiChildren)
            {
                if (filho.GetType() == typeof(frmRodriggoMendesDosSantos_CC))
                {
                    filho.Focus();
                    return;
                }
            }
            cc.MdiParent = this;
            cc.Show();
        }

        private void cmiCC_Click(object sender, EventArgs e)
        {
            frmRodriggoMendesDosSantos_CC cc = new frmRodriggoMendesDosSantos_CC();
            foreach (Form filho in this.MdiChildren)
            {
                if (filho.GetType() == typeof(frmRodriggoMendesDosSantos_CC))
                {
                    filho.Focus();
                    return;
                }
            }
            cc.MdiParent = this;
            cc.Show();
        }

        private void cmiCPF_Click(object sender, EventArgs e)
        {
            frmRodriggoMendesDosSantos_CPF cpf = new frmRodriggoMendesDosSantos_CPF();
            foreach (Form filho in this.MdiChildren)
            {
                if (filho.GetType() == typeof(frmRodriggoMendesDosSantos_CPF))
                {
                    filho.Focus();
                    return;
                }
            }
            cpf.MdiParent = this;
            cpf.Show();
        }

        private void cmiCNPJ_Click(object sender, EventArgs e)
        {
            frmRodriggoMendesDosSantos_CNPJ cnpj = new frmRodriggoMendesDosSantos_CNPJ();
            foreach (Form filho in this.MdiChildren)
            {
                if (filho.GetType() == typeof(frmRodriggoMendesDosSantos_CNPJ))
                {
                    filho.Focus();
                    return;
                }
            }
            cnpj.MdiParent = this;
            cnpj.Show();
        }

        private void msiPISPASEP_Click(object sender, EventArgs e)
        {
            frmRodriggoMendesDosSantos_PISPASEP pispasep = new frmRodriggoMendesDosSantos_PISPASEP();
            foreach (Form filho in this.MdiChildren)
            {
                if (filho.GetType() == typeof(frmRodriggoMendesDosSantos_PISPASEP))
                {
                    filho.Focus();
                    return;
                }
            }
            pispasep.MdiParent = this;
            pispasep.Show();
        }

        private void msiTE_Click(object sender, EventArgs e)
        {
            frmRodriggoMendesDosSantos_TE te = new frmRodriggoMendesDosSantos_TE();
            foreach (Form filho in this.MdiChildren)
            {
                if (filho.GetType() == typeof(frmRodriggoMendesDosSantos_TE))
                {
                    filho.Focus();
                    return;
                }
            }
            te.MdiParent = this;
            te.Show();
        }

        private void msiRG_Click(object sender, EventArgs e)
        {
            frmRodriggoMendesDosSantos_RG rg = new frmRodriggoMendesDosSantos_RG();
            foreach (Form filho in this.MdiChildren)
            {
                if (filho.GetType() == typeof(frmRodriggoMendesDosSantos_RG))
                {
                    filho.Focus();
                    return;
                }
            }
            rg.MdiParent = this;
            rg.Show();
        }
    }
}
