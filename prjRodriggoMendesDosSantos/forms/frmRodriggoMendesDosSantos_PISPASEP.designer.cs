namespace prjRodriggoMendesDosSantos.forms
{
    partial class frmRodriggoMendesDosSantos_PISPASEP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.lblObs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerador de Dígito (PIS/PASEP)";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(60, 77);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(196, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.Color.MintCream;
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.Location = new System.Drawing.Point(115, 120);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(92, 35);
            this.btnGerar.TabIndex = 3;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // lblObs
            // 
            this.lblObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(49, 176);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(217, 75);
            this.lblObs.TabIndex = 4;
            this.lblObs.Text = "Insira na caixa de texto o número do PIS/PASEP com ou sem pontos";
            this.lblObs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRodriggoMendesDosSantos_PISPASEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(311, 288);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRodriggoMendesDosSantos_PISPASEP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Dígito PIS/PASEP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label lblObs;
    }
}

