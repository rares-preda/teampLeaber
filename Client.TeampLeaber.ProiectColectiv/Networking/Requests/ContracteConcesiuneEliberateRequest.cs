using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

using Client.TeampLeaber.ProiectColectiv.Models;
using Client.TeampLeaber.ProiectColectiv.Utils;

namespace Client.TeampLeaber.ProiectColectiv.Networking.Requests
{
    public class ContracteConcesiuneEliberateRequest : BaseRequest
    {
        private int _an;

        public ContracteConcesiuneEliberateRequest(int an)
        {
            _an = an;
        }

        internal async Task<List<EvidentaContracteConcesiuneModel>> Run()
        {
            try
            {
                response = await this.GetAsync(Constants.ContracteConcesiuneEliberate + _an);

                if(response.StatusCode == HttpStatusCode.OK) //200
                {
                    List<EvidentaContracteConcesiuneModel> contracteConcesiune = await response.Content.ReadAsAsync<List<EvidentaContracteConcesiuneModel>>();
                    return contracteConcesiune;
                }
                else
                {
                    ErrorModel error = await response.Content.ReadAsAsync<ErrorModel>();
                    ErrorHandling.ErrorHandling.Instance.HandleErrors(error.errors);
                    return null;
                }
            }
            catch (Exception)
            {
                ErrorHandling.ErrorHandling.Instance.HandleError(Constants.ErrorMessages.Unknown_error);
                return null;
            }
        }
    }
}
