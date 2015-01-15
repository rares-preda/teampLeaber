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
    public partial class ReligionForm : Form
    {
        private Controller.MainController mainController;

        public ReligionForm()
        {
            InitializeComponent();
        }

        public ReligionForm(Controller.MainController mainController)
        {
            this.mainController = mainController;
        }

        internal void SetController(Controller.MainController mainController)
        {
            this.mainController = mainController;
        }

        public Models.ReligieModel SelectedReligie
        {
            get
            {
                return lstReligii.SelectedItem as Models.ReligieModel;
            }
        }

        internal void SetListElements(List<Models.ReligieModel> _religii)
        {
            lstReligii.Items.Clear();
            foreach (var value in _religii)
                lstReligii.Items.Add(value);
        }

        private void btnAdaugaReligie_Click(object sender, EventArgs e)
        {
            this.mainController.AddReligionCommand();
        }

        private void lstReligii_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCommandsAvailability();

        }

        public void SetCommandsAvailability()
        {
            var item = lstReligii.SelectedItem as Models.ReligieModel;
            if (item == null)
                buttonSterge.Enabled = btnEditeazaReligie.Enabled = false;
            else
                buttonSterge.Enabled = btnEditeazaReligie.Enabled = true;
        }

        private void btnEditeazaReligie_Click(object sender, EventArgs e)
        {
            this.mainController.EditSelectedReligionCommand();
        }

        private async void buttonSterge_Click(object sender, EventArgs e)
        {
            this.mainController.DeleteSelectedReligionCommand();
        }

     
    }
}
