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

        public MainController(MainForm mainForm)
        {
            _view = mainForm;
            _view.SetController(this);
            GetReligions();
        
        }

        private async void GetReligions()
        {
            Networking.Requests.ReligiiRequest req = new Networking.Requests.ReligiiRequest();
            _religii = await req.Run();
            _view.SetReligionsTab1(_religii);
        }


        internal async void CautaConcesionarCommand()
        {
            if (String.IsNullOrEmpty(_view.ConcsCnpTab1))
            {
                ErrorHandling.ErrorHandling.Instance.HandleError(Utils.Constants.ErrorMessages.NO_CNP_CONCESIONAR);
                return;
            }

            var request = new Networking.Requests.MorminteByConcesionar(_view.ConcsCnpTab1);
            var value = await request.Run();
            if (value == null)
                return;
            _view.ConcsNumeTab1 = value.Nume;
            _view.ConcsPrenumeTab1 = value.Prenume;
            _view.UpdateMorminteTab1(value.Morminte);
             
        }

        internal async void ProgrameazaInmormantare()
        {

            InmormantareModel model = new InmormantareModel(_view.DecedatNumeTab1, _view.DecedatPrenumeTab1, _view.DecedatCNPTab1, _view.GetSelectedReligionTab1().Id,
                _view.GetSelectedMormantTab1() == null ? 0 : _view.GetSelectedMormantTab1().Id, _view.SelectedDateTab1);
            if (!model.IsValid())
                return;
            var request = new Networking.Requests.ProgramareInmormantareRequest(model);
            bool ok = await request.Run();
            if (!ok)
                return;
            MessageBox.Show(Utils.Constants.SUCCESS_MESSAGE);
        }
    }
}
