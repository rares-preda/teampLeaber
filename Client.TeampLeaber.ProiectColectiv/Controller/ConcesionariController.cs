using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.TeampLeaber.ProiectColectiv.Models;
using Client.TeampLeaber.ProiectColectiv.Controller;
using Client.TeampLeaber.ProiectColectiv.ErrorHandling;

namespace Client.TeampLeaber.ProiectColectiv.Controller
{
    public class ConcesionariController
    {
        private MainForm _view;

        public ConcesionariController(MainForm mainForm)
        {
            _view = mainForm;
            _view.SetConcesionariController(this);
        }

        public async void AdaugaConcesionar()
        {
            ConcesionarModel concesionar = new ConcesionarModel(_view.CnpConcesionarTab2, 
                                                                _view.NumeConcesionarTab2,
                                                                _view.PrenumeConcesionarTab2,
                                                                _view.DomiciliuConcesionarTab2);
            if (concesionar.isValid())
            {
                var adaugareConcesionarRequest = new Networking.Requests.AdaugareConcesionarRequest(concesionar);
                bool success = await adaugareConcesionarRequest.Run();

                if (success)
                {
                    ErrorHandling.ErrorHandling.Instance.HandleError(Utils.Constants.AdaugareConcesionariSuccessMessage);
                }
            }
        }

        public async Task showContracteByCNP(string cnp)
        {
             await RefreshContracteByCNP(cnp);

             var cimtireRequest = new Networking.Requests.CimitireRequest();
             List<CimitirModel> cimitire = await cimtireRequest.Run();
             _view.SetCimitireTab1(cimitire);
        }

        public async Task RefreshContracteByCNP(string cnp)
        {
            if (cnp.Length == 13)
            {
                var contracteConcesionarRequest = new Networking.Requests.ContracteConcesionarRequest(cnp);
                List<ContractModel> contracte = await contracteConcesionarRequest.Run();
                _view.CNPConcesionarTab1 = cnp;
                _view.AddContracteGridView(contracte);
            }
            else
            {
                ErrorHandling.ErrorHandling.Instance.HandleError(Utils.Constants.ErrorMessages.INVALID_CNP);
            }
        }

        public async void PrelungesteContractConcesiune(PrelungireContractModel prelungireContract)
        {
            var prelungireContractRequest = new Networking.Requests.PrelungireConcesionarRequest(prelungireContract);
            bool success = await prelungireContractRequest.Run();

            if (success)
            {
                ErrorHandling.ErrorHandling.Instance.HandleError(Utils.Constants.SUCCESS_MESSAGE);
                RefreshContracteByCNP(_view.CNPConcesionarTab1);
            }
        }

        public async void RenuntaContractConcesiune(string numar)
        {
            var renuntaContractRequest = new Networking.Requests.RenuntareContractConcesiuneRequest(numar);
            bool success = await renuntaContractRequest.Run();

            if (success)
            {
                ErrorHandling.ErrorHandling.Instance.HandleError(Utils.Constants.SUCCESS_MESSAGE);
                RefreshContracteByCNP(_view.CNPConcesionarTab1);
            }
        }

        public async void ShowParceleByCimitir(CimitirModel cimitir)
        {
            var parcelaRequest = new Networking.Requests.ParceleRequest(cimitir.Id);
            List<ParcelaModel> parcele = await parcelaRequest.Run();
            _view.ShowParceleInComboBoxTab1(parcele);
        }

        public async void ShowMorminteByParcela(ParcelaModel parcela) 
        {
            var morminteRequest = new Networking.Requests.MorminteRequest(parcela.Id);
            List<MormantModel> morminte = await morminteRequest.Run();
            _view.ShowMorminteInComboBoxTab1(morminte);
        }

        public async void addContract(ContractModel contractModel)
        {
            var addContractRequest = new Networking.Requests.AdaugareContractRequest(contractModel);
            bool success = await addContractRequest.Run();
            if (success)
            {
                ErrorHandling.ErrorHandling.Instance.HandleError(Utils.Constants.SUCCESS_MESSAGE);
            }
        }
    }
}
