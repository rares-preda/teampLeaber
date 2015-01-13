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

        public async void GetContracteByCNP(string cnp)
        {
            if (cnp.Length == 13)
            {
                var contracteConcesionarRequest = new Networking.Requests.ContracteConcesionarRequest(cnp);
                List<ContractModel> contracte = await contracteConcesionarRequest.Run();
                _view.AddContracteGridView(contracte);
            }
            else
            {
                ErrorHandling.ErrorHandling.Instance.HandleError(Utils.Constants.ErrorMessages.INVALID_CNP);
            }
        }
    }
}
