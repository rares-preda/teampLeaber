using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Client.TeampLeaber.ProiectColectiv.Utils;
using Client.TeampLeaber.ProiectColectiv.ErrorHandling;
using Client.TeampLeaber.ProiectColectiv.Models;

namespace Client.TeampLeaber.ProiectColectiv.Networking.Requests
{
    public class PrelungireConcesionarRequest : BaseRequest
    {
        private Models.PrelungireContractModel contract;
        public PrelungireConcesionarRequest(Models.PrelungireContractModel contract)
        {
            this.contract = contract;
        }

        public async Task<bool> Run()
        {
            try
            {
                response = await this.PostAsJsonAsync(Constants.PrelungireContractConcesiune, contract);

                if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Accepted) // 200
                    return true;
                else
                {
                    ErrorModel error = await response.Content.ReadAsAsync<ErrorModel>();
                    ErrorHandling.ErrorHandling.Instance.HandleErrors(error.errors);
                    return false;
                }
            }
            catch (Exception)
            {
                ErrorHandling.ErrorHandling.Instance.HandleError(Constants.ErrorMessages.Unknown_error);
                return false;
            }
        }
    }
}
