using Client.TeampLeaber.ProiectColectiv.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.TeampLeaber.ProiectColectiv.Models;

namespace Client.TeampLeaber.ProiectColectiv
{
    public partial class MainForm : Form
    {
        private RaportController raportController;
        private ConcesionariController concesionariController;
        private MainController _mainController;

        public MainForm()
        {
            InitializeComponent();

        }

        public string  DecedatCNPTab1
        {
            get
            {
                return txtCNP.Text;
            }
        }
        public string DecedatNumeTab1
        {
            get
            {
                return txtNume.Text;
            }
        }
        public string DecedatPrenumeTab1
        {
            get
            {
                return txtPrenume.Text;
            }
        }

        public string ConcsCnpTab1
        {
            get
            {
                return txtCNPConcesionar1.Text;
            }
        }

        public string ConcsNumeTab1
        {
            set
            {
                txtNumeConcesionar1.Text = value;
                txtNumeConcesionar1.Visible = lblConcesionarNume.Visible = true;
            }
            get
            {
                return txtNumeConcesionar1.Text;
              
            }
        }

        public string ConcsPrenumeTab1
        {
            set 
            {
                txtPrenumeConcesionar1.Visible = lblConcesionarPrenume.Visible = true;
                txtPrenumeConcesionar1.Text = value;
            }
            get
            {
                return txtPrenumeConcesionar1.Text;
            }
        }

        public DateTime SelectedDateTab1
        {
            get
            {
                return dataInmormantare.Value;
            }
        }

        public int AnPickerTabRapoarte
        {
            get
            {
                return anPickerTabRapoarte.Value.Year;
            }
        }

        private void btnActe_Click(object sender, EventArgs e)
        {
            this._mainController.ShowActeForm();
        }

        internal void SetController(Controller.MainController mainController)
        {
            this._mainController = mainController;
        }

        internal void SetConcesionariController(Controller.ConcesionariController concesionariController)
        {
            this.concesionariController = concesionariController;
        }

        internal void SetRaportController(Controller.RaportController raportController)
        {
            this.raportController = raportController;
        }

        private void btnCautaConcesionar_Click(object sender, EventArgs e)
        {
            this._mainController.CautaConcesionarCommand();
        }

        internal void SetReligionsTab1(List<Models.ReligieModel> _religii)
        {
            cmbReligie.Items.Clear();
            foreach (var item in _religii)
                cmbReligie.Items.Add(item);
            if (_religii != null && _religii.Count() > 0)
                cmbReligie.SelectedIndex = 0;
        }

        public Models.ReligieModel GetSelectedReligionTab1()
        {
            return cmbReligie.SelectedItem as Models.ReligieModel;
        }

        internal MormantModel GetSelectedMormantLiberTab1()
        {
            return morminteLiberecmbBox.SelectedItem as MormantModel;
        }

        internal void UpdateMorminteTab1(List<Models.MormantModel> list)
        {
            cmbMorminteDisponibile.Items.Clear();
            foreach (var item in list)
                cmbMorminteDisponibile.Items.Add(item);
            if (list.Count() > 0)
            {
                cmbMorminteDisponibile.SelectedIndex = 0;
                lblLocuriDisponibile.Visible = cmbMorminteDisponibile.Visible = true;
            }
        }

        public Models.MormantModel GetSelectedMormantTab1()
        {
            if (chkApartinator.Checked)
                 return cmbMorminteDisponibile.SelectedItem as Models.MormantModel;
            return morminteLiberecmbBox.SelectedItem as Models.MormantModel;
        }

        private void btnProgramare_Click(object sender, EventArgs e)
        {
            if (chkApartinator.Checked)
                this._mainController.ProgrameazaInmormantare();
            else
                this._mainController.ProgrameazaInmormantareFaraApartinator();
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adaugaButtonConcesionari_Click(object sender, EventArgs e)
        {
            this.concesionariController.AdaugaConcesionar();
        }

        public string CnpConcesionarTab2
        {
            get
            {
                return cnpTextBoxConcesionari.Text;
            }
        }
        public string NumeConcesionarTab2
        {
            get
            {
                return numeTextBoxConcesionari.Text;
            }
        }
        public string PrenumeConcesionarTab2
        {
            get
            {
                return prenumeTextBoxConcesionari.Text;
            }
        }
        public string DomiciliuConcesionarTab2
        {
            get
            {
                return domiciliuRichTextBoxConcesionari.Text;
            }
        }

        private void btnCautaTabRapoarte_Click(object sender, EventArgs e)
        {
            this.raportController.AfiseazaRegistruInmormantari();
        }

        internal void SetRapoarteInmormantareList(List<Models.RaportInmormantareModel> _inmormantari)
        {
            lstInmormantariTabRapoarte.Items.Clear();
            foreach (Models.RaportInmormantareModel raport in _inmormantari)
                lstInmormantariTabRapoarte.Items.Add(raport);
        }

        public Models.RaportInmormantareModel SelectedRaportInmormantare
        {
            get
            {
                return lstInmormantariTabRapoarte.SelectedItem as Models.RaportInmormantareModel;
            }
        }

        private void btnModificaTabRapoarte_Click(object sender, EventArgs e)
        {
            this.raportController.SetEditInmormantareView();
        }

        private void cautaContracteButtonTab2_Click(object sender, EventArgs e)
        {
            this.concesionariController.GetContracteByCNP(this.cautaCNPConcesionarTextBoxTab2.Text);
        }

        public void AddContracteGridView(List<ContractModel> contracte)
        {
            contracteConcesionariGridViewTab2.DataSource = contracte;
        }

        private void contracteConcesionariGridViewTab2_SelectionChanged(object sender, EventArgs e)
        {
            prelungireLabelTab1.Visible = true;
            prelungireComboBoxTab1.Visible = true;
            modificaDurataContractButtonTab1.Visible = true;
        }
        internal void ClearDateConcesionarDataTab1()
        {
            txtNumeConcesionar1.Visible = lblConcesionarNume.Visible = false;
            txtPrenumeConcesionar1.Visible = lblConcesionarPrenume.Visible = false;
            lblLocuriDisponibile.Visible = cmbMorminteDisponibile.Visible = false;
        }

        private void modificaDurataContractButtonTab1_Click(object sender, EventArgs e)
        {
            var s = contracteConcesionariGridViewTab2.SelectedRows[0];
        }
        internal void UpdateActeList(List<Models.ActModel> acte)
        {
            lbActeTab1.Items.Clear();
            foreach (var item in acte)
                lbActeTab1.Items.Add(item);
        }

        private void lstInmormantariTabRapoarte_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstInmormantariTabRapoarte.SelectedIndex >= 0)
            {
                btnModificaTabRapoarte.Enabled = true;
            }
        }

        private void btnReligii_Click(object sender, EventArgs e)
        {
            _mainController.EditReligiiCommand();
        }

        private void lbActeTab1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCommandsAvailabilityTab1();
        }

        public void SetCommandsAvailabilityTab1()
        {
            var item = lbActeTab1.SelectedItem as Models.ActModel;
            if (item == null)
                buttonStergeActTab1.Enabled = false;
            else
                buttonStergeActTab1.Enabled = true;
        }

        private void buttonStergeActTab1_Click(object sender, EventArgs e)
        {
            this._mainController.DeleteSelectedActCommand();
        }

        public ActModel SelectedActTab1
        {
            get
            {
                return lbActeTab1.SelectedItem as ActModel;
            }
        }

        private void dataInmormantare_ValueChanged(object sender, EventArgs e)
        {
            this._mainController.NewDateSelected();
        }

        internal void SetInmormantariListTab1(List<RaportInmormantareModel> list)
        {
            inmormantariListTab1.Items.Clear();
            if (list == null)
                return;
            foreach (var i in list)
                inmormantariListTab1.Items.Add(i);
        }

        private void chkApartinator_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkApartinator.Checked)
            {
                txtCNP.Enabled = txtNume.Enabled = txtPrenume.Enabled = false;
                groupBoxMormantLiberTab1.Visible = true;
                grpConcesionar1.Visible = false;
                this._mainController.GetMorminteLibereCommand();
            }
            else
            {
                txtCNP.Enabled = txtNume.Enabled = txtPrenume.Enabled = true;
                groupBoxMormantLiberTab1.Visible = false;
                grpConcesionar1.Visible = true;
            }
        }

        internal void PopulateMorminteLibereList(List<MormantModel> mormintelibere)
        {
            morminteLiberecmbBox.Items.Clear();
            foreach (var item in mormintelibere)
                morminteLiberecmbBox.Items.Add(item);
        }



        internal void ClearAllDataAfterSuccess()
        {
            //To DO
        }
    }
}
