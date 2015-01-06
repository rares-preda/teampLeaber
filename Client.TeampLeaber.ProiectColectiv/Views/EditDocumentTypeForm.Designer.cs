namespace Client.TeampLeaber.ProiectColectiv
{
    partial class EditDocumentTypeForm
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
            this.lblTipAct = new System.Windows.Forms.Label();
            this.txtTipAct = new System.Windows.Forms.TextBox();
            this.btnSalveazaTipAct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTipAct
            // 
            this.lblTipAct.AutoSize = true;
            this.lblTipAct.Location = new System.Drawing.Point(22, 13);
            this.lblTipAct.Name = "lblTipAct";
            this.lblTipAct.Size = new System.Drawing.Size(43, 13);
            this.lblTipAct.TabIndex = 0;
            this.lblTipAct.Text = "Tip act:";
            // 
            // txtTipAct
            // 
            this.txtTipAct.Location = new System.Drawing.Point(89, 10);
            this.txtTipAct.Name = "txtTipAct";
            this.txtTipAct.Size = new System.Drawing.Size(135, 20);
            this.txtTipAct.TabIndex = 1;
            // 
            // btnSalveazaTipAct
            // 
            this.btnSalveazaTipAct.Location = new System.Drawing.Point(149, 45);
            this.btnSalveazaTipAct.Name = "btnSalveazaTipAct";
            this.btnSalveazaTipAct.Size = new System.Drawing.Size(75, 23);
            this.btnSalveazaTipAct.TabIndex = 2;
            this.btnSalveazaTipAct.Text = "Salveaza";
            this.btnSalveazaTipAct.UseVisualStyleBackColor = true;
            // 
            // EditDocumentTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 80);
            this.Controls.Add(this.btnSalveazaTipAct);
            this.Controls.Add(this.txtTipAct);
            this.Controls.Add(this.lblTipAct);
            this.Name = "EditDocumentTypeForm";
            this.Text = "Tip Acte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipAct;
        private System.Windows.Forms.TextBox txtTipAct;
        private System.Windows.Forms.Button btnSalveazaTipAct;
    }
}