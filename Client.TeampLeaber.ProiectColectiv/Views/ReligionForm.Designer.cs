namespace Client.TeampLeaber.ProiectColectiv
{
    partial class ReligionForm
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
            this.lstReligii = new System.Windows.Forms.ListBox();
            this.btnAdaugaReligie = new System.Windows.Forms.Button();
            this.btnEditeazaReligie = new System.Windows.Forms.Button();
            this.buttonSterge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstReligii
            // 
            this.lstReligii.FormattingEnabled = true;
            this.lstReligii.Location = new System.Drawing.Point(12, 19);
            this.lstReligii.Name = "lstReligii";
            this.lstReligii.Size = new System.Drawing.Size(120, 108);
            this.lstReligii.TabIndex = 0;
            this.lstReligii.SelectedIndexChanged += new System.EventHandler(this.lstReligii_SelectedIndexChanged);
            // 
            // btnAdaugaReligie
            // 
            this.btnAdaugaReligie.Location = new System.Drawing.Point(149, 104);
            this.btnAdaugaReligie.Name = "btnAdaugaReligie";
            this.btnAdaugaReligie.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugaReligie.TabIndex = 2;
            this.btnAdaugaReligie.Text = "Adauga";
            this.btnAdaugaReligie.UseVisualStyleBackColor = true;
            this.btnAdaugaReligie.Click += new System.EventHandler(this.btnAdaugaReligie_Click);
            // 
            // btnEditeazaReligie
            // 
            this.btnEditeazaReligie.Enabled = false;
            this.btnEditeazaReligie.Location = new System.Drawing.Point(149, 28);
            this.btnEditeazaReligie.Name = "btnEditeazaReligie";
            this.btnEditeazaReligie.Size = new System.Drawing.Size(75, 23);
            this.btnEditeazaReligie.TabIndex = 3;
            this.btnEditeazaReligie.Text = "Modifica";
            this.btnEditeazaReligie.UseVisualStyleBackColor = true;
            this.btnEditeazaReligie.Click += new System.EventHandler(this.btnEditeazaReligie_Click);
            // 
            // buttonSterge
            // 
            this.buttonSterge.Enabled = false;
            this.buttonSterge.Location = new System.Drawing.Point(149, 57);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(75, 23);
            this.buttonSterge.TabIndex = 4;
            this.buttonSterge.Text = "Sterge";
            this.buttonSterge.UseVisualStyleBackColor = true;
            this.buttonSterge.Click += new System.EventHandler(this.buttonSterge_Click);
            // 
            // ReligionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 139);
            this.Controls.Add(this.buttonSterge);
            this.Controls.Add(this.btnEditeazaReligie);
            this.Controls.Add(this.btnAdaugaReligie);
            this.Controls.Add(this.lstReligii);
            this.Name = "ReligionForm";
            this.Text = "Religii";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstReligii;
        private System.Windows.Forms.Button btnAdaugaReligie;
        private System.Windows.Forms.Button btnEditeazaReligie;
        private System.Windows.Forms.Button buttonSterge;
    }
}