using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.TeampLeaber.ProiectColectiv.Models;

namespace Client.TeampLeaber.ProiectColectiv.Controller
{
    public class CereriAtribuireController
    {
        private MainForm _view;

        public CereriAtribuireController(MainForm mainForm)
        {
            _view = mainForm;
            _view.SetCereriAtribuireController(this);
        }

        internal async Task<List<StadiuSolutionareModel>> GetStadiiSolutionare()
        {
            var request = new Networking.Requests.StadiiSolutionareRequest();
            List<StadiuSolutionareModel> _stadii = await request.Run();
            return _stadii;
        }

        internal async Task<List<CerereAtribuireModel>> GetCereriAtribuire()
        {
            var request = new Networking.Requests.CereriAtribuireRequest();
            List<CerereAtribuireModel> _cereri = await request.Run();
            return _cereri;
        }

        internal async void InitializeMainFormCereriTab()
        {
            List<CerereAtribuireModel> cereri = await GetCereriAtribuire();
            _view.SetCereriAtribuireList(cereri);
            _view.SetGroupBoxEditareCereriAtribuireVisible(false);
            List<StadiuSolutionareModel> stadii = await GetStadiiSolutionare();
            _view.SetStadiiSolutionareItems(stadii);
            _view.SetGroupBoxEditareStadiuSolutionareVisible(false);
            _view.ClearTextBoxesTabCereriAtribuire();
        }

        internal async void AdaugaCerereAtribuire()
        {
            int result;
            bool added = false;
            if (!Int32.TryParse(_view.AdaugareNumarCurentTextBox, out result))
            {
                ErrorHandling.ErrorHandling.Instance.HandleError("Numar curent invalid.");
                return;
            }
            CerereAtribuireModel cerere = new CerereAtribuireModel(result, _view.AdaugareNumarInfocetTextBox, DateTime.Now, _view.AdaugareStadiuSolutionareComboBox);
            if (cerere.IsValid())
            {
                var request = new Networking.Requests.AdaugareCerereAtribuireRequest(cerere);
                added = await request.Run();
            }

            if (added)
                InitializeMainFormCereriTab();
        }

        internal async void StergeCerereAtribuire()
        {
            CerereAtribuireModel cerere = _view.GetCereriAtribuireSelectedItem();
            if (cerere != null)
            {
                var request = new Networking.Requests.StergereCerereAtribuireRequest(cerere.Id);
                bool deleted = await request.Run();

                if (deleted)
                    InitializeMainFormCereriTab();
            }
        }

        internal async void ModificaCerereAtribuire()
        {
            int result;
            bool updated = false;
            CerereAtribuireModel cerere = _view.GetCereriAtribuireSelectedItem();
            if (cerere == null)
            {
                ErrorHandling.ErrorHandling.Instance.HandleError("Cerere de atribuire neselectata.");
                return;
            }
            if (!Int32.TryParse(_view.EditareNumarCurentTextBox, out result))
            {
                ErrorHandling.ErrorHandling.Instance.HandleError("Numar curent invalid.");
                return;
            }
            cerere.NumarCurent = result;
            cerere.NumarInfocet = _view.EditareNumarInfocetTextBox;
            cerere.StadiuSolutionare = _view.EditareStadiuSolutionareCombobox;
            cerere.DataCerere = DateTime.Now;
            if (cerere.IsValid())
            {
                var request = new Networking.Requests.ModificareCerereAtribuireRequest(cerere);
                updated = await request.Run();
            }
            if (updated)
                InitializeMainFormCereriTab();
        }

        internal async void AdaugaStadiuSolutionare()
        {
            bool added = false;
            StadiuSolutionareModel stadiu = new StadiuSolutionareModel(_view.AdaugareStadiuSolutionareTextBox);
            if (stadiu.IsValid())
            {
                var request = new Networking.Requests.AdaugareStadiuSolutionareRequest(stadiu);
                added = await request.Run();
            }

            if (added)
                InitializeMainFormCereriTab();
        }

        internal async void ModificaStadiuSolutionare()
        {
            bool updated = false;
            StadiuSolutionareModel stadiu = _view.GetStadiuSolutionareSelectedItem();
            if (stadiu == null)
            {
                ErrorHandling.ErrorHandling.Instance.HandleError("Stadiu de solutionare neselectat.");
                return;
            }
            stadiu.Denumire = _view.EditareStadiuSolutionareTextBox;
            if (stadiu.IsValid())
            {
                var request = new Networking.Requests.ModificareStadiuSolutionareRequest(stadiu);
                updated = await request.Run();
            }
            if (updated)
                InitializeMainFormCereriTab();
        }

        internal async void StergeStadiuSolutionare()
        {
            StadiuSolutionareModel stadiu = _view.GetStadiuSolutionareSelectedItem();
            if (stadiu != null)
            {
                var request = new Networking.Requests.StergereStadiuSolutionareRequest(stadiu.Id);
                bool deleted = await request.Run();

                if (deleted)
                    InitializeMainFormCereriTab();
            }
        }
    }
}
