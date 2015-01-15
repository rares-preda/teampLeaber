namespace Client.TeampLeaber.ProiectColectiv.Views
{
    partial class EditInmormantareForm
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
            this.grpInmormantari = new System.Windows.Forms.GroupBox();
            this.cmbMorminte = new System.Windows.Forms.ComboBox();
            this.cmbParcele = new System.Windows.Forms.ComboBox();
            this.lblMormant = new System.Windows.Forms.Label();
            this.lblParcela = new System.Windows.Forms.Label();
            this.cmbCimitir = new System.Windows.Forms.ComboBox();
            this.lblCimitir = new System.Windows.Forms.Label();
            this.grpDecedat = new System.Windows.Forms.GroupBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtCnp = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblCnp = new System.Windows.Forms.Label();
            this.grpInmormantare = new System.Windows.Forms.GroupBox();
            this.cmbReligii = new System.Windows.Forms.ComboBox();
            this.lblData = new System.Windows.Forms.Label();
            this.datePickerInmormantare = new System.Windows.Forms.DateTimePicker();
            this.lblReligie = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.grpInmormantari.SuspendLayout();
            this.grpDecedat.SuspendLayout();
            this.grpInmormantare.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInmormantari
            // 
            this.grpInmormantari.Controls.Add(this.cmbMorminte);
            this.grpInmormantari.Controls.Add(this.cmbParcele);
            this.grpInmormantari.Controls.Add(this.lblMormant);
            this.grpInmormantari.Controls.Add(this.lblParcela);
            this.grpInmormantari.Controls.Add(this.cmbCimitir);
            this.grpInmormantari.Controls.Add(this.lblCimitir);
            this.grpInmormantari.Location = new System.Drawing.Point(12, 12);
            this.grpInmormantari.Name = "grpInmormantari";
            this.grpInmormantari.Size = new System.Drawing.Size(211, 115);
            this.grpInmormantari.TabIndex = 0;
            this.grpInmormantari.TabStop = false;
            this.grpInmormantari.Text = "Mormant";
            // 
            // cmbMorminte
            // 
            this.cmbMorminte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMorminte.FormattingEnabled = true;
            this.cmbMorminte.Location = new System.Drawing.Point(66, 82);
            this.cmbMorminte.Name = "cmbMorminte";
            this.cmbMorminte.Size = new System.Drawing.Size(121, 21);
            this.cmbMorminte.TabIndex = 5;
            // 
            // cmbParcele
            // 
            this.cmbParcele.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParcele.FormattingEnabled = true;
            this.cmbParcele.Location = new System.Drawing.Point(66, 52);
            this.cmbParcele.Name = "cmbParcele";
            this.cmbParcele.Size = new System.Drawing.Size(121, 21);
            this.cmbParcele.TabIndex = 4;
            this.cmbParcele.SelectedIndexChanged += new System.EventHandler(this.cmbParcele_SelectedIndexChanged);
            // 
            // lblMormant
            // 
            this.lblMormant.AutoSize = true;
            this.lblMormant.Location = new System.Drawing.Point(10, 85);
            this.lblMormant.Name = "lblMormant";
            this.lblMormant.Size = new System.Drawing.Size(51, 13);
            this.lblMormant.TabIndex = 3;
            this.lblMormant.Text = "Mormant:";
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Location = new System.Drawing.Point(10, 55);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(46, 13);
            this.lblParcela.TabIndex = 2;
            this.lblParcela.Text = "Parcela:";
            // 
            // cmbCimitir
            // 
            this.cmbCimitir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCimitir.FormattingEnabled = true;
            this.cmbCimitir.Location = new System.Drawing.Point(66, 23);
            this.cmbCimitir.Name = "cmbCimitir";
            this.cmbCimitir.Size = new System.Drawing.Size(121, 21);
            this.cmbCimitir.TabIndex = 1;
            this.cmbCimitir.SelectedIndexChanged += new System.EventHandler(this.cmbCimitir_SelectedIndexChanged);
            // 
            // lblCimitir
            // 
            this.lblCimitir.AutoSize = true;
            this.lblCimitir.Location = new System.Drawing.Point(10, 26);
            this.lblCimitir.Name = "lblCimitir";
            this.lblCimitir.Size = new System.Drawing.Size(37, 13);
            this.lblCimitir.TabIndex = 0;
            this.lblCimitir.Text = "Cimitir:";
            // 
            // grpDecedat
            // 
            this.grpDecedat.Controls.Add(this.txtPrenume);
            this.grpDecedat.Controls.Add(this.txtNume);
            this.grpDecedat.Controls.Add(this.txtCnp);
            this.grpDecedat.Controls.Add(this.lblNume);
            this.grpDecedat.Controls.Add(this.lblPrenume);
            this.grpDecedat.Controls.Add(this.lblCnp);
            this.grpDecedat.Location = new System.Drawing.Point(229, 12);
            this.grpDecedat.Name = "grpDecedat";
            this.grpDecedat.Size = new System.Drawing.Size(224, 115);
            this.grpDecedat.TabIndex = 1;
            this.grpDecedat.TabStop = false;
            this.grpDecedat.Text = "Decedat";
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(73, 82);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(138, 20);
            this.txtPrenume.TabIndex = 5;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(73, 52);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(138, 20);
            this.txtNume.TabIndex = 4;
            // 
            // txtCnp
            // 
            this.txtCnp.Location = new System.Drawing.Point(73, 23);
            this.txtCnp.Name = "txtCnp";
            this.txtCnp.Size = new System.Drawing.Size(138, 20);
            this.txtCnp.TabIndex = 3;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(15, 55);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(38, 13);
            this.lblNume.TabIndex = 2;
            this.lblNume.Text = "Nume:";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(15, 85);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(52, 13);
            this.lblPrenume.TabIndex = 1;
            this.lblPrenume.Text = "Prenume:";
            // 
            // lblCnp
            // 
            this.lblCnp.AutoSize = true;
            this.lblCnp.Location = new System.Drawing.Point(15, 26);
            this.lblCnp.Name = "lblCnp";
            this.lblCnp.Size = new System.Drawing.Size(32, 13);
            this.lblCnp.TabIndex = 0;
            this.lblCnp.Text = "CNP:";
            // 
            // grpInmormantare
            // 
            this.grpInmormantare.Controls.Add(this.cmbReligii);
            this.grpInmormantare.Controls.Add(this.lblData);
            this.grpInmormantare.Controls.Add(this.datePickerInmormantare);
            this.grpInmormantare.Controls.Add(this.lblReligie);
            this.grpInmormantare.Location = new System.Drawing.Point(12, 134);
            this.grpInmormantare.Name = "grpInmormantare";
            this.grpInmormantare.Size = new System.Drawing.Size(441, 55);
            this.grpInmormantare.TabIndex = 2;
            this.grpInmormantare.TabStop = false;
            this.grpInmormantare.Text = "Inmormantare";
            // 
            // cmbReligii
            // 
            this.cmbReligii.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReligii.FormattingEnabled = true;
            this.cmbReligii.Location = new System.Drawing.Point(61, 20);
            this.cmbReligii.Name = "cmbReligii";
            this.cmbReligii.Size = new System.Drawing.Size(126, 21);
            this.cmbReligii.TabIndex = 3;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(232, 23);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data:";
            // 
            // datePickerInmormantare
            // 
            this.datePickerInmormantare.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerInmormantare.Location = new System.Drawing.Point(290, 17);
            this.datePickerInmormantare.Name = "datePickerInmormantare";
            this.datePickerInmormantare.Size = new System.Drawing.Size(138, 20);
            this.datePickerInmormantare.TabIndex = 1;
            // 
            // lblReligie
            // 
            this.lblReligie.AutoSize = true;
            this.lblReligie.Location = new System.Drawing.Point(13, 23);
            this.lblReligie.Name = "lblReligie";
            this.lblReligie.Size = new System.Drawing.Size(42, 13);
            this.lblReligie.TabIndex = 0;
            this.lblReligie.Text = "Religie:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(378, 195);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // EditInmormantareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 228);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grpInmormantare);
            this.Controls.Add(this.grpDecedat);
            this.Controls.Add(this.grpInmormantari);
            this.Name = "EditInmormantareForm";
            this.Text = "Modifica inmormantare";
            this.grpInmormantari.ResumeLayout(false);
            this.grpInmormantari.PerformLayout();
            this.grpDecedat.ResumeLayout(false);
            this.grpDecedat.PerformLayout();
            this.grpInmormantare.ResumeLayout(false);
            this.grpInmormantare.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInmormantari;
        private System.Windows.Forms.ComboBox cmbMorminte;
        private System.Windows.Forms.ComboBox cmbParcele;
        private System.Windows.Forms.Label lblMormant;
        private System.Windows.Forms.Label lblParcela;
        private System.Windows.Forms.ComboBox cmbCimitir;
        private System.Windows.Forms.Label lblCimitir;
        private System.Windows.Forms.GroupBox grpDecedat;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtCnp;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblCnp;
        private System.Windows.Forms.GroupBox grpInmormantare;
        private System.Windows.Forms.DateTimePicker datePickerInmormantare;
        private System.Windows.Forms.Label lblReligie;
        private System.Windows.Forms.ComboBox cmbReligii;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnOk;
    }
}