using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Client.TeampLeaber.ProiectColectiv.Networking.Requests;
using Client.TeampLeaber.ProiectColectiv.Models;
using Client.TeampLeaber.ProiectColectiv.ErrorHandling;

namespace Client.TeampLeaber.ProiectColectiv.Controller
{
    public class LocuriDeVeciController
    {
        private MainForm _view;

        public LocuriDeVeciController(MainForm mainForm)
        {
            _view = mainForm;
            _view.SetLocuriDeVeciController(this);
            this.ShowCimitire();
        }

        public async void ShowCimitire()
        {
            var cimitireRequest = new CimitireRequest();
            List<CimitirModel> cimitire = await cimitireRequest.Run();

            _view.ShowCimitireTab6(cimitire);
        }

        public async void ShowParceleByCimitir(CimitirModel cimitir)
        {
            var parceleRequst = new ParceleRequest(cimitir.Id);
            List<ParcelaModel> parcele = await parceleRequst.Run();

            _view.ShowParceleTab6(parcele);
        }

        public async void ShowMorminteByParcela(ParcelaModel parcela)
        {
            var morminteRequest = new MorminteRequest(parcela.Id);
            List<MormantModel> morminte = await morminteRequest.Run();

            _view.ShowMorminteTab6(morminte);
        }
    }
}
