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

namespace Client.TeampLeaber.ProiectColectiv
{
    public partial class MainForm : Form
    {

        private ConcesionariController concesionariController;
        private MainController _mainController;
        private RaportController raportController;

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
            DocumentForm documentForm = new DocumentForm();
            documentForm.Show();
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
    }
}
