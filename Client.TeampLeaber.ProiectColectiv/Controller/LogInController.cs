﻿using Client.TeampLeaber.ProiectColectiv.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.TeampLeaber.ProiectColectiv.Controller
{
    public class LogInController
    {
        public LoginForm View {get; set;}

        public LogInController()
        {
            View = new LoginForm();
            View.SetController(this);
        }

        public async Task LogInCommand()
        {
            var loginRequest = new Networking.Requests.LogInRequest(View.UserName, View.TextPassword);
            UserModel.Instance = await loginRequest.Run();
            if (UserModel.Instance == null)
                View.TextPassword = String.Empty;
            else
            {
                InitiateMainForm();
            }

        }

        private void InitiateMainForm()
        {
            MainForm mainForm = new MainForm();

            MainController contr = new MainController(mainForm);
            ConcesionariController concesionarController = new ConcesionariController(mainForm);
            RaportController raportController = new RaportController(mainForm);
            CereriAtribuireController cereriAtribuireController = new CereriAtribuireController(mainForm);
            LocuriDeVeciController locuriDeVeciController = new LocuriDeVeciController(mainForm);
            mainForm.Show();
            View.Hide();
        }

    }
}
