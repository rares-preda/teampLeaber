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
    public partial class AddReligiiForm : Form
    {
        private Controller.MainController contr;
        public AddReligiiForm()
        {
            InitializeComponent();
        }

        public string CurrentReligionName
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }

        internal void SetController(Controller.MainController mainController)
        {
            this.contr = mainController;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.contr.SaveReligionCommand();
        }

        public int SelectedReligionID { get; set; }
    }
}
