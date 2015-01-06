using Client.TeampLeaber.ProiectColectiv.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.TeampLeaber.ProiectColectiv.Controller
{
    public class MainController
    {
        private MainForm _view;
        private string _selectedMormantId;
        private List<ReligieModel> _religii;

        public MainController()
        {
            _view = new MainForm();
            _view.SetController(this);
            GetReligions();
             
        }

        private async void GetReligions()
        {
            Networking.Requests.ReligiiRequest req = new Networking.Requests.ReligiiRequest();
            _religii = await req.Run();
            _view.SetReligions(_religii);
        }

        public void DisplayView()
        {
            _view.Show();
        }

        internal async void CautaConcesionarCommand()
        {
            if (String.IsNullOrEmpty(_view.ConcsCnp))
            {
                ErrorHandling.ErrorHandling.Instance.HandleError(Utils.Constants.ErrorMessages.NO_CNP_CONCESIONAR);
                return;
            }

            var request = new Networking.Requests.MorminteByConcesionar(_view.ConcsCnp);
            var value = await request.Run();
            if (value == null)
                return;
            _view.ConcsNume = value.Nume;
            _view.ConcsPrenume = value.Prenume;
            _view.UpdateMorminte(value.Morminte);
             
        }

        internal async void ProgrameazaInmormantare()
        {
            if (String.IsNullOrEmpty(_view.DecedatNume) || String.IsNullOrEmpty(_view.DecedatPrenume) || String.IsNullOrEmpty(_view.DecedatCNP))
            {
                ErrorHandling.ErrorHandling.Instance.HandleError(Utils.Constants.ErrorMessages.INVALID_DEAD_PERSON_PERSONAL_DATA);
                return;
            }
            if (_view.GetSelectedReligion() == null)
            {
                ErrorHandling.ErrorHandling.Instance.HandleError(Utils.Constants.ErrorMessages.NO_RELIGION_SELECTED);
                return;
            }
            if (_view.GetSelectedMormant() == null)
            {
                ErrorHandling.ErrorHandling.Instance.HandleError(Utils.Constants.ErrorMessages.NO_MORMANT_SELECTED);
                return;
            }

            var request = new Networking.Requests.ProgramareInmormantareRequest(_view.DecedatNume, _view.DecedatPrenume, _view.DecedatCNP, _view.GetSelectedReligion().Id,
                _view.GetSelectedMormant().Id, _view.SelectedDate, null);
            bool ok = await request.Run();
            if (ok)
            {
                MessageBox.Show("Merge!");
            }

        }
    }
}
