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
        private MainController contr;
        public MainForm()
        {
            InitializeComponent();
        }

        public string  DecedatCNP 
        {
            get
            {
                return txtCNP.Text;
            }
        }
        public string DecedatNume
        {
            get
            {
                return txtNume.Text;
            }
        }
        public string DecedatPrenume
        {
            get
            {
                return txtPrenume.Text;
            }
        }

        public string ConcsCnp
        {
            get
            {
                return txtCNPConcesionar1.Text;
            }
        }

        public string ConcsNume
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

        public string ConcsPrenume
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

        public DateTime SelectedDate
        {
            get
            {
                return dataInmormantare.Value;
            }
        }

        private void btnActe_Click(object sender, EventArgs e)
        {
            DocumentForm documentForm = new DocumentForm();
            documentForm.Show();
        }

        internal void SetController(Controller.MainController mainController)
        {
            this.contr = mainController;
        }

        private void btnCautaConcesionar_Click(object sender, EventArgs e)
        {
            this.contr.CautaConcesionarCommand();
        }

        internal void SetReligions(List<Models.ReligieModel> _religii)
        {
            cmbReligie.Items.Clear();
            foreach (var item in _religii)
                cmbReligie.Items.Add(item);
            if (_religii != null && _religii.Count() > 0)
                cmbReligie.SelectedIndex = 0;
       
        }
        public Models.ReligieModel GetSelectedReligion()
        {
            return cmbReligie.SelectedItem as Models.ReligieModel;
        }

        internal void UpdateMorminte(List<Models.MormantModel> list)
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

        public Models.MormantModel GetSelectedMormant()
        {
            return cmbMorminteDisponibile.SelectedItem as Models.MormantModel;
        }

        private void btnProgramare_Click(object sender, EventArgs e)
        {
            this.contr.ProgrameazaInmormantare();
        }
    }
}
