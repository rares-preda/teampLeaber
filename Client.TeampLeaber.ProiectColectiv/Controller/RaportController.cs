using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.TeampLeaber.ProiectColectiv.Models;

namespace Client.TeampLeaber.ProiectColectiv.Controller
{
    public class RaportController
    {
        private MainForm _view;

        public RaportController(MainForm mainForm)
        {
            _view = mainForm;
            _view.SetRaportController(this);
             
        }

        internal async void AfiseazaRegistruInmormantari()
        {
            int an = _view.AnPickerTabRapoarte;

            var request = new Networking.Requests.RaportInmormantariRequest(an);
            List<RaportInmormantareModel> inmormantari = await request.Run();
            if (inmormantari.Count() > 0)
            {
                _view.SetRapoarteInmormantareList(inmormantari);
            }
            else
            {
                ErrorHandling.ErrorHandling.Instance.HandleError(Utils.Constants.ErrorMessages.LISTA_VIDA);
            }
        }
    }
}
