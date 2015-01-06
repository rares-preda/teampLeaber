namespace Client.TeampLeaber.ProiectColectiv
{
    partial class EditReligionForm
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
            this.lblNumeReligie = new System.Windows.Forms.Label();
            this.txtNumeReligie = new System.Windows.Forms.TextBox();
            this.btnSalveazaReligie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeReligie
            // 
            this.lblNumeReligie.AutoSize = true;
            this.lblNumeReligie.Location = new System.Drawing.Point(22, 16);
            this.lblNumeReligie.Name = "lblNumeReligie";
            this.lblNumeReligie.Size = new System.Drawing.Size(38, 13);
            this.lblNumeReligie.TabIndex = 0;
            this.lblNumeReligie.Text = "Nume:";
            // 
            // txtNumeReligie
            // 
            this.txtNumeReligie.Location = new System.Drawing.Point(81, 13);
            this.txtNumeReligie.Name = "txtNumeReligie";
            this.txtNumeReligie.Size = new System.Drawing.Size(142, 20);
            this.txtNumeReligie.TabIndex = 1;
            // 
            // btnSalveazaReligie
            // 
            this.btnSalveazaReligie.Location = new System.Drawing.Point(148, 48);
            this.btnSalveazaReligie.Name = "btnSalveazaReligie";
            this.btnSalveazaReligie.Size = new System.Drawing.Size(75, 23);
            this.btnSalveazaReligie.TabIndex = 2;
            this.btnSalveazaReligie.Text = "Salveaza";
            this.btnSalveazaReligie.UseVisualStyleBackColor = true;
            // 
            // EditReligionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 88);
            this.Controls.Add(this.btnSalveazaReligie);
            this.Controls.Add(this.txtNumeReligie);
            this.Controls.Add(this.lblNumeReligie);
            this.Name = "EditReligionForm";
            this.Text = "Religii";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeReligie;
        private System.Windows.Forms.TextBox txtNumeReligie;
        private System.Windows.Forms.Button btnSalveazaReligie;
    }
}