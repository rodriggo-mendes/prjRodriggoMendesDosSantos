namespace prjRodriggoMendesDosSantos.forms
{
    partial class frmRodriggoMendesDosSantos_CNPJ
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
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Validação de CNPJ";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(33, 81);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(228, 20);
            this.txtCNPJ.TabIndex = 1;
            // 
            // lblObs
            // 
            this.lblObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblObs.Location = new System.Drawing.Point(33, 190);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(228, 65);
            this.lblObs.TabIndex = 2;
            this.lblObs.Text = "Digite na caixa de texto o número do CNPJ";
            this.lblObs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.MintCream;
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidar.Location = new System.Drawing.Point(110, 131);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 33);
            this.btnValidar.TabIndex = 3;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // frmRodriggoMendesDosSantos_CNPJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(293, 293);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRodriggoMendesDosSantos_CNPJ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validação de CNPJ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Button btnValidar;
    }
}

