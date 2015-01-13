using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.TeampLeaber.ProiectColectiv.Views
{
    public partial class EditInmormantareForm : Form
    {
        Controller.RaportController _raportController;

        public EditInmormantareForm(Controller.RaportController raportController)
        {
            InitializeComponent();
            _raportController = raportController;
        }

        public void SetCimitireComboBox(List<Models.CimitirModel> _cimitire)
        {
            cmbCimitir.Items.Clear();
            if (_cimitire != null && _cimitire.Count > 0)
            {
                foreach (var item in _cimitire)
                    cmbCimitir.Items.Add(item);
                cmbCimitir.SelectedIndex = 0;
            }
        }

        public void SetParceleComboBox(List<Models.ParcelaModel> _parcele)
        {
            cmbParcele.Items.Clear();
            cmbParcele.Text = "";
            if (_parcele != null && _parcele.Count > 0)
            {
                foreach (var item in _parcele)
                    cmbParcele.Items.Add(item);
                cmbParcele.SelectedIndex = 0;
            }
        }

        public void SetMorminteComboBox(List<Models.MormantModel> _morminte)
        {
            cmbMorminte.Items.Clear(); 
            cmbMorminte.Text = "";
            if (_morminte != null && _morminte.Count > 0)
            {
                foreach (var item in _morminte)
                    cmbMorminte.Items.Add(item);
                cmbMorminte.SelectedIndex = 0;
            }
        }

        public void SetReligiiComboBox(List<Models.ReligieModel> _religii)
        {
            cmbReligii.Items.Clear();
            if (_religii != null && _religii.Count > 0)
            {
                foreach (var item in _religii)
                    cmbReligii.Items.Add(item);
                cmbReligii.SelectedIndex = 0;
            }
        }

        public void SetDataInmormantare(DateTime dataInmormantare)
        {
            datePickerInmormantare.Value = dataInmormantare;
        }

        public void SetCnpTextBox(string text)
        {
            txtCnp.Text = text;
        }

        public void SetNameTextBox(string text)
        {
            txtNume.Text = text;
        }

        public void SetPrenumeTextBox(string text)
        {
            txtPrenume.Text = text;
        }

        public void SetCimitireComboBoxSelectedItem(Models.CimitirModel item)
        {
            cmbCimitir.SelectedItem = item;
        }

        public void SetParceleComboBoxSelectedItem(Models.ParcelaModel item)
        {
            cmbParcele.SelectedItem = item;
        }

        public void SetMorminteComboBoxSelectedItem(Models.MormantModel item)
        {
            cmbMorminte.SelectedItem = item;
        }

        public void SetCimitireComboBoxSelectedIndex(int index)
        {
            if (index >= 0 && index < cmbCimitir.Items.Count)
                cmbCimitir.SelectedIndex = index;
        }

        public void SetParceleComboBoxSelectedIndex(int index)
        {
            if (index >= 0 && index < cmbParcele.Items.Count)
                cmbParcele.SelectedIndex = index;
        }

        public void SetMorminteComboBoxSelectedIndex(int index)
        {
            if (index >= 0 && index < cmbMorminte.Items.Count)
                cmbMorminte.SelectedIndex = index;
        }

        public void SetReligiiComboBoxSelectedItem(Models.ReligieModel item)
        {
            cmbReligii.SelectedItem = item;
        }

        public object GetCimitireComboBoxSelectedItem()
        {
            return cmbCimitir.SelectedItem;
        }

        public object GetParceleComboBoxSelectedItem()
        {
            return cmbParcele.SelectedItem;
        }

        public object GetMorminteComboBoxSelectedItem()
        {
            return cmbMorminte.SelectedItem;
        }

        public object GetReligieComboBoxSelectedItem()
        {
            return cmbReligii.SelectedItem;
        }

        public string GetCnpTextBox()
        {
            return txtCnp.Text;
        }

        public string GetNumeTextBox()
        {
            return txtNume.Text;
        }

        public string GetPrenumeTextBox()
        {
            return txtPrenume.Text;
        }

        public DateTime GetDataInmormantareDatePicker()
        {
            return datePickerInmormantare.Value;
        }

        private void cmbCimitir_SelectedIndexChanged(object sender, EventArgs e)
        {
            _raportController.UpdateParceleComboBoxByCimitir(cmbCimitir.SelectedItem as Models.CimitirModel);
        }

        private void cmbParcele_SelectedIndexChanged(object sender, EventArgs e)
        {
            _raportController.UpdateMorminteComboBoxByParcela(cmbParcele.SelectedItem as Models.ParcelaModel);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _raportController.UpdateInmormantare();
        }
    }
}
