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
        public DocumentTypeForm()
        {
            InitializeComponent();
            loadTipuriActe();    
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

    }
}
