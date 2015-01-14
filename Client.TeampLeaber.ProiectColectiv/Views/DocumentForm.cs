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
    public partial class DocumentForm : Form
    {
        private MainController contr;
        public DocumentForm()
        {
            InitializeComponent();
        }

        private void btnAdaugaTipActe_Click(object sender, EventArgs e)
        {
            this.contr.AdaugaActeCommand();
        }

        public string ActName
        {
            get { return txtNumarAct.Text;  }
        }
        public int TipID
        {
            get
            {
                if ((cmbTipActe.SelectedItem as Models.TipActModel) == null)
                    return 0;
                return (cmbTipActe.SelectedItem as Models.TipActModel).Id;

            }
        }

        public string TipName
        {
            get
            {
                if ((cmbTipActe.SelectedItem as Models.TipActModel) == null)
                    return String.Empty;
                return (cmbTipActe.SelectedItem as Models.TipActModel).Denumire;

            }
        }

        internal void ShowTipuriActeInList(List<Models.TipActModel> tipuriActe)
        {
            cmbTipActe.Items.Clear();
            if (tipuriActe == null)
                return;
            foreach (var act in tipuriActe)
                cmbTipActe.Items.Add(act);
        }

        internal void SetController(Controller.MainController mainController)
        {
            this.contr = mainController;
        }

        private void btnSalveazaAct_Click(object sender, EventArgs e)
        {
            this.contr.SaveDocumentCommand();
        }
    }
}
