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
        private LocuriDeVeciController locuriDeVeciController;
        private MainController _mainController;
        public string CNPConcesionarTab1 { get; set; }

        public MainForm()
        {
            InitializeComponent();
            adaugaContractGroupBox.Visible = false;
        }

        public string DecedatCNPTab1
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

        internal void SetLocuriDeVeciController(Controller.LocuriDeVeciController locuriDeVeciController)
        {
            this.locuriDeVeciController = locuriDeVeciController;
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

        private async void cautaContracteButtonTab2_Click(object sender, EventArgs e)
        {
            await this.concesionariController.showContracteByCNP(this.cautaCNPConcesionarTextBoxTab2.Text);

            this.adaugaContractGroupBox.Visible = true;
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
            if (prelungireComboBoxTab1.SelectedIndex < 0 || contracteConcesionariGridViewTab2.SelectedRows.Count == 0)
            {
                ErrorHandling.ErrorHandling.Instance.HandleError("Selecteaza contractul si una din optiunile de modificare a duratei contractului de concesiune.");
            }
            else
            {
                var s = contracteConcesionariGridViewTab2.SelectedRows[0];
                string numar = (string)s.Cells["Numar"].Value;

                if (prelungireComboBoxTab1.SelectedIndex == 0)
                {
                    concesionariController.RenuntaContractConcesiune(numar);
                }
                else
                {
                    int nrAni = int.Parse(prelungireComboBoxTab1.SelectedItem.ToString());
                    PrelungireContractModel prelungireContract = new PrelungireContractModel(numar, nrAni);
                    concesionariController.PrelungesteContractConcesiune(prelungireContract);
                }

            }
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


        public void SetCimitireTab1(List<CimitirModel> cimitire)
        {
            cimitirComboBoxTab1.DataSource = cimitire;
        }

        private void cimitirComboBoxTab1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cimitirComboBoxTab1.SelectedIndex >= 0)
            {
                CimitirModel cimitir = (CimitirModel)cimitirComboBoxTab1.SelectedItem;
                concesionariController.ShowParceleByCimitir(cimitir);
            }
            else
            {
                parcelaComboboxTab1.SelectedIndex = -1;
                mormantComboboxTab1.SelectedIndex = -1;
            }
        }

        public void ShowParceleInComboBoxTab1(List<ParcelaModel> parcele)
        {
            this.parcelaComboboxTab1.DataSource = parcele;
            mormantComboboxTab1.SelectedIndex = -1;
        }
        public void ShowMorminteInComboBoxTab1(List<MormantModel> morminte)
        {
            this.mormantComboboxTab1.DataSource = morminte;
        }

        private void parcelaComboboxTab1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (parcelaComboboxTab1.SelectedIndex >= 0)
            {
                ParcelaModel parcela = (ParcelaModel)parcelaComboboxTab1.SelectedItem;
                concesionariController.ShowMorminteByParcela(parcela);
            }
            else
            {
                mormantComboboxTab1.SelectedIndex = -1;
            }
        }

        private void adaugaContractButtonTab1_Click(object sender, EventArgs e)
        {
            if (numarContractConcesiuneTextBoxTab1.Text == "" || cimitirComboBoxTab1.SelectedIndex < 0 ||
                parcelaComboboxTab1.SelectedIndex < 0 || mormantComboboxTab1.SelectedIndex < 0 ||
                nrChitantaTextFieldTab1.Text == "" || sumaTextFieldTab1.Text == "")
            {
                string nrChitanta = nrChitantaTextFieldTab1.Text;
                float suma = 0;
                if (float.TryParse(sumaTextFieldTab1.Text, out suma))
                {

                }
                else
                {
                    ErrorHandling.ErrorHandling.Instance.HandleError("Suma trebuie sa fie numar real");
                    return;
                }

                ChitantaModel chitanta = new ChitantaModel(0, nrChitanta, suma);

                ContractModel contractModel = new ContractModel(numarContractConcesiuneTextBoxTab1.Text,
                                              DateTime.Now,
                                              dataExpirareDatePickerTab1.Value,
                                              chitanta,
                                              (CimitirModel)cimitirComboBoxTab1.SelectedValue,
                                              (ParcelaModel)parcelaComboboxTab1.SelectedValue,
                                              (MormantModel)mormantComboboxTab1.SelectedValue);
                if (contractModel.isValid())
                {
                    concesionariController.addContract(contractModel);
                }
            }
        }
        public Models.CimitirModel Raport2CimitirComboBox
        {
            get
            {
                return cmbRapoarteCimitir.SelectedItem as Models.CimitirModel;
            }
        }

        public Models.RaportMorminteModel Raport2ListSelectedItem
        {
            get
            {
                return lstRegistruMorminte.SelectedItem as Models.RaportMorminteModel;
            }
        }

        public bool Raport2CheckboxMonumentFunerar
        {
            get
            {
                return checkRapoarteMonument.Checked;
            }
        }

        public void LoadRaport2ListBox(List<Models.RaportMorminteModel> registruMorminte)
        {
            lstRegistruMorminte.Items.Clear();
            foreach (var item in registruMorminte)
                lstRegistruMorminte.Items.Add(item);
        }

        public void LoadRaport2CimitirCombobox(List<Models.CimitirModel> cimitire)
        {
            cmbRapoarteCimitir.Items.Clear();
            foreach (var item in cimitire)
                cmbRapoarteCimitir.Items.Add(item);
        }

        public void LoadRaport2InhumatiListBox(List<Models.InmormantareModel> inmormantari)
        {
            lstRapoarteInhumati.Items.Clear();
            foreach (var item in inmormantari)
                lstRapoarteInhumati.Items.Add(item.Decedat.Nume + " " + item.Decedat.Prenume + " - " + item.Data.ToShortDateString());
        }

        public void SetRaport2CimitirComboBoxIndex(int index)
        {
            if (index >= 0 && index < cmbRapoarteCimitir.Items.Count)
            {
                cmbRapoarteCimitir.SelectedIndex = index;
            }
        }

        private void tabControlRapoarte_Selected(object sender, TabControlEventArgs e)
        {
            raportController.UpdateRegistruCimitir();
        }

        private void btnRapoarteCauta_Click(object sender, EventArgs e)
        {
            raportController.LoadRegistruCimitirListBox();
        }

        private void lstRegistruMorminte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRegistruMorminte.SelectedIndex >= 0)
            {
                grpRapoarteObservatii.Visible = true;
                raportController.SetInfoMormant();
            }
        }

        public string Raport2ObservatiiTextBox
        {
            get
            {
                return txtRapoarteObservatii.Text;
            }
            set
            {
                txtRapoarteObservatii.Text = value;
            }
        }

        private void btnRapoarteObservatii_Click(object sender, EventArgs e)
        {
            raportController.UpdateMormantObservatie();
        }

        public void SetDecedatiCuApartinator(List<DecedatCuApartinatorModel> decedatiCuApartinator)
        {
            if (decedatiCuApartinator != null)
            {
                foreach (var item in decedatiCuApartinator)
                {
                    listBoxDecedatiCuApartinator.Items.Add(item.ToString());
                }
            }
        }

        public void SetDecedatiFaraApartinator(List<DecedatFaraApartinatorModel> decedatiFaraApartinator)
        {
            if (decedatiFaraApartinator != null)
            {
                foreach (var item in decedatiFaraApartinator)
                {
                    listBoxDecedatiFaraApartinator.Items.Add(item.ToString());
                }
            }
        }

        internal void ClearAllDataAfterSuccess()
        {
            inmormantariListTab1.Items.Clear();
            cmbMorminteDisponibile.Items.Clear();
            txtPrenumeConcesionar1.Text = String.Empty;
            txtNumeConcesionar1.Text = String.Empty;
            txtNumeConcesionar1.Text = String.Empty;
            lbActeTab1.Items.Clear();
            chkApartinator.Checked = true;
            morminteLiberecmbBox.Items.Clear();
            txtCNP.Text = txtPrenume.Text = txtNume.Text = String.Empty;
            txtNumeConcesionar1.Visible = txtPrenumeConcesionar1.Visible = lblConcesionarNume.Visible = lblConcesionarPrenume.Visible = false;
        }


        public void ShowCimitireTab6(List<CimitirModel> cimitire)
        {
            cimitireListBoxTab6.DataSource = cimitire;
        }

        public void ShowParceleTab6(List<ParcelaModel> parcele)
        {
            parceleListBoxTab6.DataSource = parcele;
        }

        public void ShowMorminteTab6(List<MormantModel> morminte)
        {
            morminteListBoxTab6.DataSource = morminte;
        }

        private void cimitireListBoxTab6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cimitireListBoxTab6.SelectedIndex >= 0)
            {
                CimitirModel cimitir = (CimitirModel)cimitireListBoxTab6.SelectedValue;
                locuriDeVeciController.ShowParceleByCimitir(cimitir);
            }
        }

        private void parceleListBoxTab6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (parceleListBoxTab6.SelectedIndex >= 0)
            {
                ParcelaModel parcela = (ParcelaModel)parceleListBoxTab6.SelectedValue;
                locuriDeVeciController.ShowMorminteByParcela(parcela);
            }
        }

        internal void SetContracteConcesiune(List<EvidentaContracteConcesiuneModel> contracteConcesiune)
        {
            foreach (var item in contracteConcesiune)
            {
                listBoxContracteConcesiune.Items.Add(item.ToString());
            }
        }

        private void buttonAfisareContracteConcesiune_Click(object sender, EventArgs e)
        {
            listBoxContracteConcesiune.Items.Clear();
            bool finalizat = checkBoxFinalizatTabRapoarteContracteConcesiune.Checked;
            raportController.GetContracteConcesiune(yearPickerContracteConcesiune.Value.Year, finalizat);
        }
    }
}
