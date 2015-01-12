using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Client.TeampLeaber.ProiectColectiv.Models;
using Client.TeampLeaber.ProiectColectiv.Utils;

namespace Client.TeampLeaber.ProiectColectiv.Networking.Requests
{
    public class ContracteConcesionarRequest : BaseRequest
    {
        private string cnp;

        public ContracteConcesionarRequest(string cnp)
        {
            this.cnp = cnp;
        }

        internal async Task<List<ContractModel>> Run()
        {
            try
            {
                response = await this.GetAsync(Constants.ContracteConcesionarPath + "?cnp=" + cnp);

                if (response.StatusCode == HttpStatusCode.OK) // 200
                {
                    List<ContractModel> value = await response.Content.ReadAsAsync<List<ContractModel>>();
                    return value;
                }
                else
                {
                    ErrorModel error = await response.Content.ReadAsAsync<ErrorModel>();
                    ErrorHandling.ErrorHandling.Instance.HandleErrors(error.errors);
                    return null;
                }
            }
            catch(Exception)
            {
                ErrorHandling.ErrorHandling.Instance.HandleError(Constants.ErrorMessages.Unknown_error);
                return null;
            }
        }
    }
}
