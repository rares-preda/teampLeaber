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
    public partial class EditDocumentTypeForm : Form
    {
        public int SelectedTipActID { get; set; }
        private MainController contr;
        public EditDocumentTypeForm()
        {
            InitializeComponent();
        }

        public string DocumentTypeActName
        {
            get
            {
                return txtTipAct.Text;
            }
            set
            {
                txtTipAct.Text = value;
            }
        }

        internal void SetController(Controller.MainController mainController)
        {
            this.contr = mainController;
        }

        private void btnSalveazaTipAct_Click(object sender, EventArgs e)
        {
            this.contr.SaveDocumentType();
        }
    }
}
