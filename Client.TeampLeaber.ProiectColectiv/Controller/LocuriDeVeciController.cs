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
            var cimitireRequest = new GetCimitireRequest();
            List<CimitirModel> cimitire = await cimitireRequest.Run();

            _view.ShowCimitireTab6(cimitire);
        }

        public async void ShowParceleByCimitir(CimitirModel cimitir)
        {
            var parceleRequst = new GetParceleRequest(cimitir.Id);
            List<ParcelaModel> parcele = await parceleRequst.Run();

            _view.ShowParceleTab6(parcele);
        }

        public async void ShowMorminteByParcela(ParcelaModel parcela)
        {
            var morminteRequest = new GetMorminteRequest(parcela.Id);
            List<MormantModel> morminte = await morminteRequest.Run();

            _view.ShowMorminteTab6(morminte);
        }

        public async void AdaugaCimitir(CimitirModel cimitir)
        {
            var adaugaCimitireRequest = new AdaugaCimitireRequest(cimitir);
            bool success = await adaugaCimitireRequest.Run();

            if (success)
            {
                this.ShowCimitire();
                ErrorHandling.ErrorHandling.Instance.HandleError(Utils.Constants.SUCCESS_MESSAGE);
            }
        }

        public async void ModificaCimitir(CimitirModel cimitir)
        {
            var modificaCimitirReqest = new ModificaCimitireRequest(cimitir);
            bool success = await modificaCimitirReqest.Run();

            if (success)
            {
                this.ShowCimitire();
                ErrorHandling.ErrorHandling.Instance.HandleError(Utils.Constants.SUCCESS_MESSAGE);
            }
        }

        public async void StergeCimitir(CimitirModel cimitir)
        {
            var stergeCimitirRequst = new StergeCimitireRequest(cimitir.Id);
            bool success = await stergeCimitirRequst.Run();

            if (success)
            {
                this.ShowCimitire();
                ErrorHandling.ErrorHandling.Instance.HandleError(Utils.Constants.SUCCESS_MESSAGE);
            }
        }

        public async void AdaugaParcela(ParcelaModel parcela, CimitirModel cimitir)
        {
            ParcelaModelForRequest parcelaModelForRequest = new ParcelaModelForRequest(parcela.Id, parcela.Denumire, cimitir.Id);

            var adaugaParcelaRequest = new AdaugaParceleRequest(parcelaModelForRequest);
            bool success = await adaugaParcelaRequest.Run();

            if (success)
            {
                this.ShowParceleByCimitir(cimitir);
                ErrorHandling.ErrorHandling.Instance.HandleError(Utils.Constants.SUCCESS_MESSAGE);
            }
        }

        public async void ModificaParcela(ParcelaModel parcela, CimitirModel cimitir)
        {
            ParcelaModelForRequest parcelaModelForRequest = new ParcelaModelForRequest(parcela.Id, parcela.Denumire, cimitir.Id);

            var modificaParcelaRequest = new ModificaParcelaRequest(parcelaModelForRequest);
            bool success = await modificaParcelaRequest.Run();

            if (success)
            {
                this.ShowParceleByCimitir(cimitir);
                ErrorHandling.ErrorHandling.Instance.HandleError(Utils.Constants.SUCCESS_MESSAGE);
            }
        }

        public async void StergeParcelaForCimir(ParcelaModel parcela, CimitirModel cimitir)
        {
            var stergeParcelaRequest = new StergeParcelaRequest(parcela.Id);
            bool success = await stergeParcelaRequest.Run();

            if (success)
            {
                this.ShowParceleByCimitir(cimitir);
                ErrorHandling.ErrorHandling.Instance.HandleError(Utils.Constants.SUCCESS_MESSAGE);
            }
        }

        public async void AdaugaMormant(MormantModel mormant, ParcelaModel parcela)
        {
            MormantModelForRequest mormantModelForRequest = new MormantModelForRequest(parcela.Id, mormant);

            var adaugaMormantRequest = new AdaugaMorminteRequest(mormantModelForRequest);
            var success = await adaugaMormantRequest.Run();

            if (success)
            {
                this.ShowMorminteByParcela(parcela);
                ErrorHandling.ErrorHandling.Instance.HandleError(Utils.Constants.SUCCESS_MESSAGE);
            }
        }

        public async void ModificaMormant(MormantModel mormant, ParcelaModel parcela)
        {
            MormantModelForRequest mormantModelForRequest = new MormantModelForRequest(parcela.Id, mormant);

            var modificaMormantRequest = new ModificaMormantReqest(mormantModelForRequest);
            var success = await modificaMormantRequest.Run();

            if (success)
            {
                this.ShowMorminteByParcela(parcela);
                ErrorHandling.ErrorHandling.Instance.HandleError(Utils.Constants.SUCCESS_MESSAGE);
            }
        }

        public async void StergeMormant(MormantModel mormant, ParcelaModel parcela)
        {
            var stergeMormantRequest = new StergeMormantRequest(mormant.Id);
            var success = await stergeMormantRequest.Run();

            if (success)
            {
                this.ShowMorminteByParcela(parcela);
                ErrorHandling.ErrorHandling.Instance.HandleError(Utils.Constants.SUCCESS_MESSAGE);
            }
        }
    }
}
