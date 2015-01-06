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
        public DocumentForm()
        {
            InitializeComponent();
        }

        private void btnAdaugaTipActe_Click(object sender, EventArgs e)
        {
            DocumentTypeForm documentFormType = new DocumentTypeForm();
            documentFormType.Show();
        }
    }
}
