namespace Client.TeampLeaber.ProiectColectiv
{
    partial class DocumentForm
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
            this.lblNumarAct = new System.Windows.Forms.Label();
            this.lblTipAct = new System.Windows.Forms.Label();
            this.txtNumarAct = new System.Windows.Forms.TextBox();
            this.cmbTipActe = new System.Windows.Forms.ComboBox();
            this.btnAdaugaTipActe = new System.Windows.Forms.Button();
            this.btnSalveazaAct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumarAct
            // 
            this.lblNumarAct.AutoSize = true;
            this.lblNumarAct.Location = new System.Drawing.Point(26, 13);
            this.lblNumarAct.Name = "lblNumarAct";
            this.lblNumarAct.Size = new System.Drawing.Size(41, 13);
            this.lblNumarAct.TabIndex = 0;
            this.lblNumarAct.Text = "Numar:";
            // 
            // lblTipAct
            // 
            this.lblTipAct.AutoSize = true;
            this.lblTipAct.Location = new System.Drawing.Point(42, 37);
            this.lblTipAct.Name = "lblTipAct";
            this.lblTipAct.Size = new System.Drawing.Size(25, 13);
            this.lblTipAct.TabIndex = 1;
            this.lblTipAct.Text = "Tip:";
            // 
            // txtNumarAct
            // 
            this.txtNumarAct.Location = new System.Drawing.Point(86, 10);
            this.txtNumarAct.Name = "txtNumarAct";
            this.txtNumarAct.Size = new System.Drawing.Size(202, 20);
            this.txtNumarAct.TabIndex = 2;
            // 
            // cmbTipActe
            // 
            this.cmbTipActe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipActe.FormattingEnabled = true;
            this.cmbTipActe.Location = new System.Drawing.Point(86, 34);
            this.cmbTipActe.Name = "cmbTipActe";
            this.cmbTipActe.Size = new System.Drawing.Size(129, 21);
            this.cmbTipActe.TabIndex = 3;
            // 
            // btnAdaugaTipActe
            // 
            this.btnAdaugaTipActe.Location = new System.Drawing.Point(221, 32);
            this.btnAdaugaTipActe.Name = "btnAdaugaTipActe";
            this.btnAdaugaTipActe.Size = new System.Drawing.Size(67, 23);
            this.btnAdaugaTipActe.TabIndex = 4;
            this.btnAdaugaTipActe.Text = "Adauga tip";
            this.btnAdaugaTipActe.UseVisualStyleBackColor = true;
            this.btnAdaugaTipActe.Click += new System.EventHandler(this.btnAdaugaTipActe_Click);
            // 
            // btnSalveazaAct
            // 
            this.btnSalveazaAct.Location = new System.Drawing.Point(203, 61);
            this.btnSalveazaAct.Name = "btnSalveazaAct";
            this.btnSalveazaAct.Size = new System.Drawing.Size(85, 23);
            this.btnSalveazaAct.TabIndex = 5;
            this.btnSalveazaAct.Text = "Salveaza";
            this.btnSalveazaAct.UseVisualStyleBackColor = true;
            // 
            // DocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 96);
            this.Controls.Add(this.btnSalveazaAct);
            this.Controls.Add(this.btnAdaugaTipActe);
            this.Controls.Add(this.cmbTipActe);
            this.Controls.Add(this.txtNumarAct);
            this.Controls.Add(this.lblTipAct);
            this.Controls.Add(this.lblNumarAct);
            this.Name = "DocumentForm";
            this.Text = "Acte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumarAct;
        private System.Windows.Forms.Label lblTipAct;
        private System.Windows.Forms.TextBox txtNumarAct;
        private System.Windows.Forms.ComboBox cmbTipActe;
        private System.Windows.Forms.Button btnAdaugaTipActe;
        private System.Windows.Forms.Button btnSalveazaAct;
    }
}