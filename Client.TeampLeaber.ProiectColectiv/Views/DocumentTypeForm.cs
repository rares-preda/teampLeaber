using Client.TeampLeaber.ProiectColectiv.Controller;
using Client.TeampLeaber.ProiectColectiv.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.TeampLeaber.ProiectColectiv
{
    public partial class DocumentTypeForm : Form
    {
        private MainController contr;
       
        public DocumentTypeForm()
        {
            InitializeComponent();
            loadTipuriActe();

            this.FormClosing += (sender, e) => { contr.OnClosingDocumentTypeFormEvent(); };
        }

        public TipActModel SelectedTipAct
        {
            get
            {
                return lstTipActe.SelectedItem as TipActModel;
            }
        }

        private async void loadTipuriActe()
        {
            using (var client = new HttpClient())
            {
                // New code:
                client.BaseAddress = new Uri(Utils.Constants.HOST);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, client.BaseAddress);
                HttpResponseMessage response = await client.GetAsync("/api/tipActe");

                if (response.IsSuccessStatusCode)
                {
                    IEnumerable<TipActModel> tipuriActe = await response.Content.ReadAsAsync<IEnumerable<TipActModel>>();
                    foreach (TipActModel tipAct in tipuriActe) 
                    {
                        lstTipActe.Items.Add(tipAct.ToString());
                    }
                }
            }
            
        }

        internal void AddTypeList(List<TipActModel> list)
        {
            lstTipActe.Items.Clear();
            if (list == null)
                return;
            foreach (var item in list)
                lstTipActe.Items.Add(item);
        }

        private void btnAdaugaTipActe_Click(object sender, EventArgs e)
        {
            this.contr.AddDocumentTypeCommand();
        }

        internal void SetController(Controller.MainController mainController)
        {
            this.contr = mainController;
        }

        private void btnEditeazaTipActe_Click(object sender, EventArgs e)
        {
            this.contr.UpdateActeCommand();
        }

        private void lstTipActe_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCommandsAvailability();
        }

        public void SetCommandsAvailability()
        {
            var item = lstTipActe.SelectedItem as Models.TipActModel;
            if (item == null)
                buttonDelete.Enabled = btnEditeazaTipActe.Enabled = false;
            else
                buttonDelete.Enabled = btnEditeazaTipActe.Enabled = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.contr.DeleteActCommand();
        }



    
    }
}
