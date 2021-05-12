namespace prjRodriggoMendesDosSantos.forms
{
    partial class frmRodriggoMendesDosSantos_CC
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
            this.btnValidar = new System.Windows.Forms.Button();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.MintCream;
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidar.Location = new System.Drawing.Point(110, 146);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 33);
            this.btnValidar.TabIndex = 7;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // lblObs
            // 
            this.lblObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblObs.Location = new System.Drawing.Point(41, 205);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(214, 65);
            this.lblObs.TabIndex = 6;
            this.lblObs.Text = "Digite na caixa de texto o número do cartão de crédito";
            this.lblObs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(33, 96);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(228, 20);
            this.txtCC.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "Validação de Cartão de Crédito";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRodriggoMendesDosSantos_CC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 311);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRodriggoMendesDosSantos_CC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validação de Cartão de Crédito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label label1;
    }
}