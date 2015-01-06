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
    public partial class LoginForm : Form
    {
        private Controller.LogInController contr;
        public string TextPassword 
        { 
            get
            {
                return txtPassword.Text;
            }
            set 
            {
                txtPassword.Text = value;
            }
        }
        public string UserName 
        { 
            get
            {
                return txtUsername.Text;
            }
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        internal void SetController(Controller.LogInController logInController)
        {
            this.contr = logInController;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            await this.contr.LogInCommand();
        }

    }
}
