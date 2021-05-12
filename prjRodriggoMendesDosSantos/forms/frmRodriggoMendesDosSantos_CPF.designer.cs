namespace prjRodriggoMendesDosSantos.forms
{
    partial class frmRodriggoMendesDosSantos_CPF
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
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(55, 70);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(193, 20);
            this.txtCPF.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Verificação de CPF";
            // 
            // lblObs
            // 
            this.lblObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblObs.Location = new System.Drawing.Point(21, 174);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(265, 52);
            this.lblObs.TabIndex = 3;
            this.lblObs.Text = "Digite o número do CPF e o dígito";
            this.lblObs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.MintCream;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.Location = new System.Drawing.Point(105, 117);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(91, 31);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // frmRodriggoMendesDosSantos_CPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(309, 263);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCPF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRodriggoMendesDosSantos_CPF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validação de CPF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Button btnVerificar;
    }
}

