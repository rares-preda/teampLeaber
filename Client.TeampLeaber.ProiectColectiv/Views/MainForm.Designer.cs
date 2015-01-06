namespace Client.TeampLeaber.ProiectColectiv
{
    partial class MainForm
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
            this.tab = new System.Windows.Forms.TabControl();
            this.tabInmormantari = new System.Windows.Forms.TabPage();
            this.btnProgramare = new System.Windows.Forms.Button();
            this.grpDateInmormantare = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInmormantari = new System.Windows.Forms.Label();
            this.btnReligii = new System.Windows.Forms.Button();
            this.cmbReligie = new System.Windows.Forms.ComboBox();
            this.lblReligie = new System.Windows.Forms.Label();
            this.lblDataInmormantare = new System.Windows.Forms.Label();
            this.dataInmormantare = new System.Windows.Forms.DateTimePicker();
            this.grpConcesionar1 = new System.Windows.Forms.GroupBox();
            this.lblLocuriDisponibile = new System.Windows.Forms.Label();
            this.cmbMorminteDisponibile = new System.Windows.Forms.ComboBox();
            this.txtPrenumeConcesionar1 = new System.Windows.Forms.TextBox();
            this.txtNumeConcesionar1 = new System.Windows.Forms.TextBox();
            this.lblConcesionarPrenume = new System.Windows.Forms.Label();
            this.lblConcesionarNume = new System.Windows.Forms.Label();
            this.btnCautaConcesionar = new System.Windows.Forms.Button();
            this.lblCNPConcesionar1 = new System.Windows.Forms.Label();
            this.txtCNPConcesionar1 = new System.Windows.Forms.TextBox();
            this.grpDecedat = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblActeAnexate = new System.Windows.Forms.Label();
            this.btnActe = new System.Windows.Forms.Button();
            this.chkApartinator = new System.Windows.Forms.CheckBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblCnp = new System.Windows.Forms.Label();
            this.tabConcesionari = new System.Windows.Forms.TabPage();
            this.tab.SuspendLayout();
            this.tabInmormantari.SuspendLayout();
            this.grpDateInmormantare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpConcesionar1.SuspendLayout();
            this.grpDecedat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabInmormantari);
            this.tab.Controls.Add(this.tabConcesionari);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(667, 443);
            this.tab.TabIndex = 0;
            // 
            // tabInmormantari
            // 
            this.tabInmormantari.Controls.Add(this.btnProgramare);
            this.tabInmormantari.Controls.Add(this.grpDateInmormantare);
            this.tabInmormantari.Controls.Add(this.grpConcesionar1);
            this.tabInmormantari.Controls.Add(this.grpDecedat);
            this.tabInmormantari.Location = new System.Drawing.Point(4, 22);
            this.tabInmormantari.Name = "tabInmormantari";
            this.tabInmormantari.Padding = new System.Windows.Forms.Padding(3);
            this.tabInmormantari.Size = new System.Drawing.Size(659, 417);
            this.tabInmormantari.TabIndex = 0;
            this.tabInmormantari.Text = "Inmormantari";
            this.tabInmormantari.UseVisualStyleBackColor = true;
            // 
            // btnProgramare
            // 
            this.btnProgramare.Location = new System.Drawing.Point(544, 386);
            this.btnProgramare.Name = "btnProgramare";
            this.btnProgramare.Size = new System.Drawing.Size(103, 23);
            this.btnProgramare.TabIndex = 3;
            this.btnProgramare.Text = "Programeaza";
            this.btnProgramare.UseVisualStyleBackColor = true;
            this.btnProgramare.Click += new System.EventHandler(this.btnProgramare_Click);
            // 
            // grpDateInmormantare
            // 
            this.grpDateInmormantare.Controls.Add(this.dataGridView1);
            this.grpDateInmormantare.Controls.Add(this.btnInmormantari);
            this.grpDateInmormantare.Controls.Add(this.btnReligii);
            this.grpDateInmormantare.Controls.Add(this.cmbReligie);
            this.grpDateInmormantare.Controls.Add(this.lblReligie);
            this.grpDateInmormantare.Controls.Add(this.lblDataInmormantare);
            this.grpDateInmormantare.Controls.Add(this.dataInmormantare);
            this.grpDateInmormantare.Location = new System.Drawing.Point(9, 242);
            this.grpDateInmormantare.Name = "grpDateInmormantare";
            this.grpDateInmormantare.Size = new System.Drawing.Size(638, 132);
            this.grpDateInmormantare.TabIndex = 2;
            this.grpDateInmormantare.TabStop = false;
            this.grpDateInmormantare.Text = "Date inmormantare";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(396, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(235, 99);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnInmormantari
            // 
            this.btnInmormantari.Location = new System.Drawing.Point(308, 20);
            this.btnInmormantari.Name = "btnInmormantari";
            this.btnInmormantari.Size = new System.Drawing.Size(83, 28);
            this.btnInmormantari.TabIndex = 5;
            this.btnInmormantari.Text = "Inmormantari programte:";
            // 
            // btnReligii
            // 
            this.btnReligii.Location = new System.Drawing.Point(226, 57);
            this.btnReligii.Name = "btnReligii";
            this.btnReligii.Size = new System.Drawing.Size(61, 23);
            this.btnReligii.TabIndex = 4;
            this.btnReligii.Text = "Editeaza";
            this.btnReligii.UseVisualStyleBackColor = true;
            // 
            // cmbReligie
            // 
            this.cmbReligie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReligie.FormattingEnabled = true;
            this.cmbReligie.Location = new System.Drawing.Point(98, 59);
            this.cmbReligie.Name = "cmbReligie";
            this.cmbReligie.Size = new System.Drawing.Size(122, 21);
            this.cmbReligie.TabIndex = 3;
            // 
            // lblReligie
            // 
            this.lblReligie.AutoSize = true;
            this.lblReligie.Location = new System.Drawing.Point(20, 62);
            this.lblReligie.Name = "lblReligie";
            this.lblReligie.Size = new System.Drawing.Size(42, 13);
            this.lblReligie.TabIndex = 2;
            this.lblReligie.Text = "Religie:";
            // 
            // lblDataInmormantare
            // 
            this.lblDataInmormantare.AutoSize = true;
            this.lblDataInmormantare.Location = new System.Drawing.Point(29, 34);
            this.lblDataInmormantare.Name = "lblDataInmormantare";
            this.lblDataInmormantare.Size = new System.Drawing.Size(33, 13);
            this.lblDataInmormantare.TabIndex = 1;
            this.lblDataInmormantare.Text = "Data:";
            // 
            // dataInmormantare
            // 
            this.dataInmormantare.CustomFormat = "   dd/MM/yyyy                   HH:mm";
            this.dataInmormantare.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataInmormantare.Location = new System.Drawing.Point(98, 28);
            this.dataInmormantare.Name = "dataInmormantare";
            this.dataInmormantare.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataInmormantare.Size = new System.Drawing.Size(189, 20);
            this.dataInmormantare.TabIndex = 0;
            this.dataInmormantare.Value = new System.DateTime(2014, 11, 26, 22, 32, 41, 0);
            // 
            // grpConcesionar1
            // 
            this.grpConcesionar1.Controls.Add(this.lblLocuriDisponibile);
            this.grpConcesionar1.Controls.Add(this.cmbMorminteDisponibile);
            this.grpConcesionar1.Controls.Add(this.txtPrenumeConcesionar1);
            this.grpConcesionar1.Controls.Add(this.txtNumeConcesionar1);
            this.grpConcesionar1.Controls.Add(this.lblConcesionarPrenume);
            this.grpConcesionar1.Controls.Add(this.lblConcesionarNume);
            this.grpConcesionar1.Controls.Add(this.btnCautaConcesionar);
            this.grpConcesionar1.Controls.Add(this.lblCNPConcesionar1);
            this.grpConcesionar1.Controls.Add(this.txtCNPConcesionar1);
            this.grpConcesionar1.Location = new System.Drawing.Point(318, 7);
            this.grpConcesionar1.Name = "grpConcesionar1";
            this.grpConcesionar1.Size = new System.Drawing.Size(329, 229);
            this.grpConcesionar1.TabIndex = 1;
            this.grpConcesionar1.TabStop = false;
            this.grpConcesionar1.Text = "Concesionar";
            // 
            // lblLocuriDisponibile
            // 
            this.lblLocuriDisponibile.AutoSize = true;
            this.lblLocuriDisponibile.Location = new System.Drawing.Point(12, 120);
            this.lblLocuriDisponibile.Name = "lblLocuriDisponibile";
            this.lblLocuriDisponibile.Size = new System.Drawing.Size(51, 13);
            this.lblLocuriDisponibile.TabIndex = 8;
            this.lblLocuriDisponibile.Text = "Mormant:";
            this.lblLocuriDisponibile.Visible = false;
            // 
            // cmbMorminteDisponibile
            // 
            this.cmbMorminteDisponibile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMorminteDisponibile.FormattingEnabled = true;
            this.cmbMorminteDisponibile.Location = new System.Drawing.Point(87, 117);
            this.cmbMorminteDisponibile.Name = "cmbMorminteDisponibile";
            this.cmbMorminteDisponibile.Size = new System.Drawing.Size(154, 21);
            this.cmbMorminteDisponibile.TabIndex = 7;
            this.cmbMorminteDisponibile.Visible = false;
            // 
            // txtPrenumeConcesionar1
            // 
            this.txtPrenumeConcesionar1.Enabled = false;
            this.txtPrenumeConcesionar1.Location = new System.Drawing.Point(87, 91);
            this.txtPrenumeConcesionar1.Name = "txtPrenumeConcesionar1";
            this.txtPrenumeConcesionar1.Size = new System.Drawing.Size(154, 20);
            this.txtPrenumeConcesionar1.TabIndex = 6;
            this.txtPrenumeConcesionar1.Visible = false;
            // 
            // txtNumeConcesionar1
            // 
            this.txtNumeConcesionar1.Enabled = false;
            this.txtNumeConcesionar1.Location = new System.Drawing.Point(87, 65);
            this.txtNumeConcesionar1.Name = "txtNumeConcesionar1";
            this.txtNumeConcesionar1.Size = new System.Drawing.Size(154, 20);
            this.txtNumeConcesionar1.TabIndex = 5;
            this.txtNumeConcesionar1.Visible = false;
            // 
            // lblConcesionarPrenume
            // 
            this.lblConcesionarPrenume.AutoSize = true;
            this.lblConcesionarPrenume.Location = new System.Drawing.Point(11, 94);
            this.lblConcesionarPrenume.Name = "lblConcesionarPrenume";
            this.lblConcesionarPrenume.Size = new System.Drawing.Size(52, 13);
            this.lblConcesionarPrenume.TabIndex = 4;
            this.lblConcesionarPrenume.Text = "Prenume:";
            this.lblConcesionarPrenume.Visible = false;
            // 
            // lblConcesionarNume
            // 
            this.lblConcesionarNume.AutoSize = true;
            this.lblConcesionarNume.Location = new System.Drawing.Point(24, 68);
            this.lblConcesionarNume.Name = "lblConcesionarNume";
            this.lblConcesionarNume.Size = new System.Drawing.Size(38, 13);
            this.lblConcesionarNume.TabIndex = 3;
            this.lblConcesionarNume.Text = "Nume:";
            this.lblConcesionarNume.Visible = false;
            // 
            // btnCautaConcesionar
            // 
            this.btnCautaConcesionar.Location = new System.Drawing.Point(247, 37);
            this.btnCautaConcesionar.Name = "btnCautaConcesionar";
            this.btnCautaConcesionar.Size = new System.Drawing.Size(75, 23);
            this.btnCautaConcesionar.TabIndex = 2;
            this.btnCautaConcesionar.Text = "Cauta";
            this.btnCautaConcesionar.UseVisualStyleBackColor = true;
            this.btnCautaConcesionar.Click += new System.EventHandler(this.btnCautaConcesionar_Click);
            // 
            // lblCNPConcesionar1
            // 
            this.lblCNPConcesionar1.AutoSize = true;
            this.lblCNPConcesionar1.Location = new System.Drawing.Point(30, 42);
            this.lblCNPConcesionar1.Name = "lblCNPConcesionar1";
            this.lblCNPConcesionar1.Size = new System.Drawing.Size(32, 13);
            this.lblCNPConcesionar1.TabIndex = 1;
            this.lblCNPConcesionar1.Text = "CNP:";
            // 
            // txtCNPConcesionar1
            // 
            this.txtCNPConcesionar1.Location = new System.Drawing.Point(87, 39);
            this.txtCNPConcesionar1.Name = "txtCNPConcesionar1";
            this.txtCNPConcesionar1.Size = new System.Drawing.Size(154, 20);
            this.txtCNPConcesionar1.TabIndex = 0;
            // 
            // grpDecedat
            // 
            this.grpDecedat.Controls.Add(this.dataGridView2);
            this.grpDecedat.Controls.Add(this.lblActeAnexate);
            this.grpDecedat.Controls.Add(this.btnActe);
            this.grpDecedat.Controls.Add(this.chkApartinator);
            this.grpDecedat.Controls.Add(this.txtPrenume);
            this.grpDecedat.Controls.Add(this.txtNume);
            this.grpDecedat.Controls.Add(this.txtCNP);
            this.grpDecedat.Controls.Add(this.lblPrenume);
            this.grpDecedat.Controls.Add(this.lblNume);
            this.grpDecedat.Controls.Add(this.lblCnp);
            this.grpDecedat.Location = new System.Drawing.Point(9, 7);
            this.grpDecedat.Name = "grpDecedat";
            this.grpDecedat.Size = new System.Drawing.Size(303, 229);
            this.grpDecedat.TabIndex = 0;
            this.grpDecedat.TabStop = false;
            this.grpDecedat.Text = "Decedat";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(98, 174);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(189, 49);
            this.dataGridView2.TabIndex = 9;
            // 
            // lblActeAnexate
            // 
            this.lblActeAnexate.AutoSize = true;
            this.lblActeAnexate.Location = new System.Drawing.Point(6, 174);
            this.lblActeAnexate.Name = "lblActeAnexate";
            this.lblActeAnexate.Size = new System.Drawing.Size(73, 13);
            this.lblActeAnexate.TabIndex = 8;
            this.lblActeAnexate.Text = "Acte anexate:";
            // 
            // btnActe
            // 
            this.btnActe.Location = new System.Drawing.Point(192, 145);
            this.btnActe.Name = "btnActe";
            this.btnActe.Size = new System.Drawing.Size(95, 23);
            this.btnActe.TabIndex = 7;
            this.btnActe.Text = "Adauga acte";
            this.btnActe.UseVisualStyleBackColor = true;
            this.btnActe.Click += new System.EventHandler(this.btnActe_Click);
            // 
            // chkApartinator
            // 
            this.chkApartinator.AutoSize = true;
            this.chkApartinator.Checked = true;
            this.chkApartinator.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkApartinator.Location = new System.Drawing.Point(192, 122);
            this.chkApartinator.Name = "chkApartinator";
            this.chkApartinator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkApartinator.Size = new System.Drawing.Size(95, 17);
            this.chkApartinator.TabIndex = 6;
            this.chkApartinator.Text = "Are apartinator";
            this.chkApartinator.UseVisualStyleBackColor = true;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(98, 91);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(189, 20);
            this.txtPrenume.TabIndex = 5;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(98, 65);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(189, 20);
            this.txtNume.TabIndex = 4;
            // 
            // txtCNP
            // 
            this.txtCNP.Location = new System.Drawing.Point(98, 39);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(189, 20);
            this.txtCNP.TabIndex = 3;
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(27, 94);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(52, 13);
            this.lblPrenume.TabIndex = 2;
            this.lblPrenume.Text = "Prenume:";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(41, 68);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(38, 13);
            this.lblNume.TabIndex = 1;
            this.lblNume.Text = "Nume:";
            // 
            // lblCnp
            // 
            this.lblCnp.AutoSize = true;
            this.lblCnp.Location = new System.Drawing.Point(47, 42);
            this.lblCnp.Name = "lblCnp";
            this.lblCnp.Size = new System.Drawing.Size(32, 13);
            this.lblCnp.TabIndex = 0;
            this.lblCnp.Text = "CNP:";
            // 
            // tabConcesionari
            // 
            this.tabConcesionari.Location = new System.Drawing.Point(4, 22);
            this.tabConcesionari.Name = "tabConcesionari";
            this.tabConcesionari.Padding = new System.Windows.Forms.Padding(3);
            this.tabConcesionari.Size = new System.Drawing.Size(659, 417);
            this.tabConcesionari.TabIndex = 1;
            this.tabConcesionari.Text = "Concesionari";
            this.tabConcesionari.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 443);
            this.Controls.Add(this.tab);
            this.Name = "MainForm";
            this.Text = "TeampLeaber";
            this.tab.ResumeLayout(false);
            this.tabInmormantari.ResumeLayout(false);
            this.grpDateInmormantare.ResumeLayout(false);
            this.grpDateInmormantare.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpConcesionar1.ResumeLayout(false);
            this.grpConcesionar1.PerformLayout();
            this.grpDecedat.ResumeLayout(false);
            this.grpDecedat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabInmormantari;
        private System.Windows.Forms.TabPage tabConcesionari;
        private System.Windows.Forms.GroupBox grpConcesionar1;
        private System.Windows.Forms.TextBox txtPrenumeConcesionar1;
        private System.Windows.Forms.TextBox txtNumeConcesionar1;
        private System.Windows.Forms.Label lblConcesionarPrenume;
        private System.Windows.Forms.Label lblConcesionarNume;
        private System.Windows.Forms.Button btnCautaConcesionar;
        private System.Windows.Forms.Label lblCNPConcesionar1;
        private System.Windows.Forms.TextBox txtCNPConcesionar1;
        private System.Windows.Forms.GroupBox grpDecedat;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblCnp;
        private System.Windows.Forms.Label lblLocuriDisponibile;
        private System.Windows.Forms.ComboBox cmbMorminteDisponibile;
        private System.Windows.Forms.GroupBox grpDateInmormantare;
        private System.Windows.Forms.DateTimePicker dataInmormantare;
        private System.Windows.Forms.Button btnProgramare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label btnInmormantari;
        private System.Windows.Forms.Button btnReligii;
        private System.Windows.Forms.ComboBox cmbReligie;
        private System.Windows.Forms.Label lblReligie;
        private System.Windows.Forms.Label lblDataInmormantare;
        private System.Windows.Forms.Button btnActe;
        private System.Windows.Forms.CheckBox chkApartinator;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblActeAnexate;
    }
}

