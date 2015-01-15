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
            return cmbMorminteDisponibile.SelectedItem as Models.MormantModel;
        }

        private void btnProgramare_Click(object sender, EventArgs e)
        {
            this._mainController.ProgrameazaInmormantare();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void adaugaButtonConcesionari_Click(object sender, EventArgs e)
        {
            await this.concesionariController.AdaugaConcesionar();
            this.clearConcesionar();
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
            try
            {
                contracteConcesionariGridViewTab2.DataSource = contracte;
            }
            catch (Exception e)
            {

            }
            
        }

        public void ClearCimitireDetailsTab6()
        {
            this.denumireCimitirTextBoxTab6.Text = "";
        }

        public void ClearParceleDetailsTab6()
        {
            this.denumireParcelaTextBoxTab6.Text = "";
        }

        public void ClearMorminteDetailsTab6()
        {
            suprafataMormantTextBoxTab6.Text = "";
            numarMormantTextBoxTab6.Text = "";
            valoareIstoricaMormantCheckboxTab6.Checked = false;
            observatiiMormantRichTextBoxTab6.Text = "";
        }

        private void contracteConcesionariGridViewTab2_SelectionChanged(object sender, EventArgs e)
        {
            prelungireLabelTab1.Visible = true;
            prelungireComboBoxTab1.Visible = true;
            modificaDurataContractButtonTab1.Visible = true;

            var s = contracteConcesionariGridViewTab2.SelectedRows[0];

            this.numarContractConcesiuneTextBoxTab1.Text = s.Cells["Numar"].Value.ToString();
            this.dataExpirareDatePickerTab1.Value = (DateTime)s.Cells["DataExpirare"].Value;
            this.cimitirComboBoxTab1.SelectedItem = (CimitirModel)s.Cells["Cimitir"].Value;
            this.parcelaComboboxTab1.SelectedItem = (ParcelaModel)s.Cells["Parcela"].Value;
            this.mormantComboboxTab1.SelectedItem = (MormantModel)s.Cells["Mormant"].Value;
            ChitantaModel chitanta = (ChitantaModel)s.Cells["Chitanta"].Value;
            this.nrChitantaTextFieldTab1.Text = chitanta.Numar.ToString();
            this.sumaTextFieldTab1.Text = chitanta.Suma.ToString();

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
        internal void UpdateActeList(List<Models.ActeModel> acte)
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
                ClearCimitireDetailsTab6();
                ClearParceleDetailsTab6();
                ClearMorminteDetailsTab6();

                denumireCimitirTextBoxTab6.Text = cimitir.Denumire;
                parceleListBoxTab6.DataSource = null;
                morminteListBoxTab6.DataSource = null;

                locuriDeVeciController.ShowParceleByCimitir(cimitir);
            }
            else
            {
                parceleListBoxTab6.SelectedIndex = -1;
                morminteListBoxTab6.SelectedIndex = -1;
            }
        }

        private void parceleListBoxTab6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (parceleListBoxTab6.SelectedIndex >= 0)
            {
                ParcelaModel parcela = (ParcelaModel)parceleListBoxTab6.SelectedValue;
                ClearParceleDetailsTab6();
                ClearMorminteDetailsTab6();

                denumireParcelaTextBoxTab6.Text = parcela.Denumire;

                morminteListBoxTab6.DataSource = null;
                locuriDeVeciController.ShowMorminteByParcela(parcela);
            }
            else
            {
                parceleListBoxTab6.SelectedIndex = -1;
            }
        }

        private void adaugaCimitirButtonTab6_Click(object sender, EventArgs e)
        {
            if (denumireCimitirTextBoxTab6.Text == "")
            {
                ErrorHandling.ErrorHandling.Instance.HandleError("Nu ati adaugat denumirea cimitirului");
            }
            else
            {
                CimitirModel cimitir = new CimitirModel(0, denumireCimitirTextBoxTab6.Text);
                if (cimitir.IsValid())
                {
                    locuriDeVeciController.AdaugaCimitir(cimitir);
                }
            }
        }

        private void modificaCimitirButtonTab6_Click(object sender, EventArgs e)
        {
            if (cimitireListBoxTab6.SelectedIndex >= 0)
            {
                if (denumireCimitirTextBoxTab6.Text == "")
                {
                    ErrorHandling.ErrorHandling.Instance.HandleError("Nu ati adaugat noua denumire");
                }
                else
                {
                    CimitirModel cimitir = (CimitirModel)cimitireListBoxTab6.SelectedItem;
                    cimitir.Denumire = denumireCimitirTextBoxTab6.Text;

                    locuriDeVeciController.ModificaCimitir(cimitir);
                }
            }
            else
            {
                ErrorHandling.ErrorHandling.Instance.HandleError("Nu ati selectat cimitirul pe care doriti sa-l modificati");
            }
        }

        private void deleteCimitirButtonTab6_Click(object sender, EventArgs e)
        {
            if (cimitireListBoxTab6.SelectedIndex >= 0)
            {
                CimitirModel cimitir = (CimitirModel)cimitireListBoxTab6.SelectedItem;
                locuriDeVeciController.StergeCimitir(cimitir);
            }
            else
            {
                ErrorHandling.ErrorHandling.Instance.HandleError("Nu ati selectat cimitirul pe care doriti sa-l stergeti");
            }
        }

        private void adaugaParcelaButtonTab6_Click(object sender, EventArgs e)
        {
            if (cimitireListBoxTab6.SelectedIndex >= 0)
            {
                if (denumireParcelaTextBoxTab6.Text == "")
                {
                    ErrorHandling.ErrorHandling.Instance.HandleError("Nu ati adaugat denumirea parcelei");
                }
                else
                {
                    ParcelaModel parcela = new ParcelaModel(0, denumireParcelaTextBoxTab6.Text);
                    locuriDeVeciController.AdaugaParcela(parcela, (CimitirModel)cimitireListBoxTab6.SelectedItem);
                }
            }
            else
            {
                ErrorHandling.ErrorHandling.Instance.HandleError("Nu ati selectat cimitirul in care doriti sa adaugati parcela");
            }
        }

        private void modificaParcelaButtonTab6_Click(object sender, EventArgs e)
        {
            if (cimitireListBoxTab6.SelectedIndex >= 0)
            {
                if (parceleListBoxTab6.SelectedIndex >= 0)
                {
                    if (denumireParcelaTextBoxTab6.Text == "")
                    {
                        ErrorHandling.ErrorHandling.Instance.HandleError("Nu ati adaugat denumirea parcelei");
                    }
                    else
                    {
                        ParcelaModel parcela = (ParcelaModel)parceleListBoxTab6.SelectedItem;
                        CimitirModel cimitir = (CimitirModel)cimitireListBoxTab6.SelectedItem;
                        parcela.Denumire = denumireParcelaTextBoxTab6.Text;

                        locuriDeVeciController.ModificaParcela(parcela, cimitir);
                    }
                }
                else
                {
                    ErrorHandling.ErrorHandling.Instance.HandleError("Nu ati selectat parcela pe care doriti sa o modificati");
                }
            }
            else
            {
                ErrorHandling.ErrorHandling.Instance.HandleError("Nu ati selectat cimitirul din care doriti sa modificati parcela");
            }
        }

        private void stergeParcelaButtonTab6_Click(object sender, EventArgs e)
        {
            if (cimitireListBoxTab6.SelectedIndex >= 0)
            {
                if (parceleListBoxTab6.SelectedIndex >= 0)
                {
                    CimitirModel cimitir = (CimitirModel)cimitireListBoxTab6.SelectedItem;
                    ParcelaModel parcela = (ParcelaModel)parceleListBoxTab6.SelectedItem;
                    locuriDeVeciController.StergeParcelaForCimir(parcela, cimitir);
                }
                else
                {
                    ErrorHandling.ErrorHandling.Instance.HandleError("Nu ati selectat parcela pe care dorit sa o stergeti");
                }
            }
            else
            {
                ErrorHandling.ErrorHandling.Instance.HandleError("Nu ati selectat mormantul din care doriti sa stergeti parcela");
            }
        }

        public void clearConcesionar()
        {
            this.cnpTextBoxConcesionari.Text = "";
            this.numeTextBoxConcesionari.Text = "";
            this.prenumeTextBoxConcesionari.Text = "";
            this.domiciliuRichTextBoxConcesionari.Text = "";
        }

        private void morminteListBoxTab6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (morminteListBoxTab6.SelectedIndex >= 0)
            {
                MormantModel mormant = (MormantModel)morminteListBoxTab6.SelectedItem;
                this.suprafataMormantTextBoxTab6.Text = mormant.Suprafata.ToString();
                this.numarMormantTextBoxTab6.Text = mormant.Numar.ToString();
                this.valoareIstoricaMormantCheckboxTab6.Checked = mormant.AreValoareIstorica;
                if (mormant.Observatie != null)
                {
                    this.observatiiMormantRichTextBoxTab6.Text = mormant.Observatie;
                }
                else
                {
                    this.observatiiMormantRichTextBoxTab6.Text = "";
                }
            }
        }

        private void adaugaMormantButtonTab6_Click(object sender, EventArgs e)
        {
            if (cimitireListBoxTab6.SelectedIndex >= 0)
            {
                if (parceleListBoxTab6.SelectedIndex >= 0)
                {
                    if (suprafataMormantTextBoxTab6.Text == "" || numarMormantTextBoxTab6.Text == "")
                    {
                        ErrorHandling.ErrorHandling.Instance.HandleError("Nu ati completat datele despre mormant");
                    }
                    else
                    {
                        double suprafata = 0;
                        if( !double.TryParse(suprafataMormantTextBoxTab6.Text, out suprafata) ) {
                            ErrorHandling.ErrorHandling.Instance.HandleError("Suprafata trebuie sa fie numar real");
                            return;
                        }

                        int numar = 0;
                        if (!int.TryParse(numarMormantTextBoxTab6.Text, out numar))
                        {
                            ErrorHandling.ErrorHandling.Instance.HandleError("Mormantul trebuie sa fie numar intreg");
                            return;
                        }

                        MormantModel mormant = new MormantModel(0, suprafata, numar, valoareIstoricaMormantCheckboxTab6.Checked, observatiiMormantRichTextBoxTab6.Text);
                        ParcelaModel parcela = (ParcelaModel)parceleListBoxTab6.SelectedItem;
                        if (mormant.isValid())
                        {
                            locuriDeVeciController.AdaugaMormant(mormant, parcela);
                        }
                    }
                }
                else
                {
                    ErrorHandling.ErrorHandling.Instance.HandleError("Nu ati selectat parcela in care doriti sa adaugati mormantul");
                }
            }
            else
            {
                ErrorHandling.ErrorHandling.Instance.HandleError("Nu ati selectat cimitirul in care doriti sa adaugati mormantul");
            }
        }

        private void modificaMormantButtonTab6_Click(object sender, EventArgs e)
        {
            if (cimitireListBoxTab6.SelectedIndex >= 0)
            {
                if (parceleListBoxTab6.SelectedIndex >= 0)
                {
                    if (morminteListBoxTab6.SelectedIndex >= 0)
                    {
                        if (suprafataMormantTextBoxTab6.Text == "" || numarMormantTextBoxTab6.Text == "")
                        {
                            ErrorHandling.ErrorHandling.Instance.HandleError("Nu ati completat datele despre mormant");
                        }
                        else
                        {
                            double suprafata = 0;
                            if (!double.TryParse(suprafataMormantTextBoxTab6.Text, out suprafata))
                            {
                                ErrorHandling.ErrorHandling.Instance.HandleError("Suprafata trebuie sa fie numar real");
                                return;
                            }

                            int numar = 0;
                            if (!int.TryParse(numarMormantTextBoxTab6.Text, out numar))
                            {
                                ErrorHandling.ErrorHandling.Instance.HandleError("Mormantul trebuie sa fie numar intreg");
                                return;
                            }

                            ParcelaModel parcela = (ParcelaModel)parceleListBoxTab6.SelectedItem;
                            MormantModel mormantSelectat = (MormantModel)morminteListBoxTab6.SelectedItem;
                            MormantModel mormant = new MormantModel(mormantSelectat.Id, suprafata, numar, valoareIstoricaMormantCheckboxTab6.Checked, observatiiMormantRichTextBoxTab6.Text);
                            if (mormant.isValid())
                            {
                                locuriDeVeciController.ModificaMormant(mormant, parcela);
                            }
                        }
                    }
                    else
                    {
                        ErrorHandling.ErrorHandling.Instance.HandleError("Nu ati selectat mormantul pe care doriti sa-l modificati");
                    }
                }
                else
                {
                    ErrorHandling.ErrorHandling.Instance.HandleError("Nu ati selectat parcela in care doriti sa adaugati mormantul");
                }
            }
            else
            {
                ErrorHandling.ErrorHandling.Instance.HandleError("Nu ati selectat cimitirul in care doriti sa adaugati mormantul");
            }
        }

        private void stergeMormantButtonTab6_Click(object sender, EventArgs e)
        {
            if (cimitireListBoxTab6.SelectedIndex >= 0)
            {
                if (parceleListBoxTab6.SelectedIndex >= 0)
                {
                    if (morminteListBoxTab6.SelectedIndex >= 0)
                    {
                        ParcelaModel parcela = (ParcelaModel)parceleListBoxTab6.SelectedItem;
                        MormantModel mormant = (MormantModel)morminteListBoxTab6.SelectedItem;
                        locuriDeVeciController.StergeMormant(mormant, parcela);
                    }
                    else
                    {
                        ErrorHandling.ErrorHandling.Instance.HandleError("Nu ati selectat mormantul pe care doriti sa-l modificati");
                    }
                }
                else
                {
                    ErrorHandling.ErrorHandling.Instance.HandleError("Nu ati selectat parcela in care doriti sa adaugati mormantul");
                }
            }
            else
            {
                ErrorHandling.ErrorHandling.Instance.HandleError("Nu ati selectat cimitirul in care doriti sa adaugati mormantul");
            }
        }
    }
}
