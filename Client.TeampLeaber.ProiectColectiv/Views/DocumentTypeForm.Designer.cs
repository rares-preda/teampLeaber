namespace Client.TeampLeaber.ProiectColectiv
{
    partial class DocumentTypeForm
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
            this.lstTipActe = new System.Windows.Forms.ListBox();
            this.btnAdaugaTipActe = new System.Windows.Forms.Button();
            this.btnEditeazaTipActe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTipActe
            // 
            this.lstTipActe.FormattingEnabled = true;
            this.lstTipActe.Location = new System.Drawing.Point(13, 13);
            this.lstTipActe.Name = "lstTipActe";
            this.lstTipActe.Size = new System.Drawing.Size(120, 108);
            this.lstTipActe.TabIndex = 0;
            // 
            // btnAdaugaTipActe
            // 
            this.btnAdaugaTipActe.Location = new System.Drawing.Point(153, 64);
            this.btnAdaugaTipActe.Name = "btnAdaugaTipActe";
            this.btnAdaugaTipActe.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugaTipActe.TabIndex = 1;
            this.btnAdaugaTipActe.Text = "Adauga";
            this.btnAdaugaTipActe.UseVisualStyleBackColor = true;
            // 
            // btnEditeazaTipActe
            // 
            this.btnEditeazaTipActe.Location = new System.Drawing.Point(153, 98);
            this.btnEditeazaTipActe.Name = "btnEditeazaTipActe";
            this.btnEditeazaTipActe.Size = new System.Drawing.Size(75, 23);
            this.btnEditeazaTipActe.TabIndex = 2;
            this.btnEditeazaTipActe.Text = "Editeaza";
            this.btnEditeazaTipActe.UseVisualStyleBackColor = true;
            // 
            // DocumentTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 132);
            this.Controls.Add(this.btnEditeazaTipActe);
            this.Controls.Add(this.btnAdaugaTipActe);
            this.Controls.Add(this.lstTipActe);
            this.Name = "DocumentTypeForm";
            this.Text = "Tip Acte";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstTipActe;
        private System.Windows.Forms.Button btnAdaugaTipActe;
        private System.Windows.Forms.Button btnEditeazaTipActe;
    }
}