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
    public class CereriAtribuireRequest : BaseRequest
    {
        public async Task<List<CerereAtribuireModel>> Run()
        {
            try
            {
                response = await this.GetAsync(Constants.CereriAtribuirePath + "?guid=" + Guid.NewGuid());

                if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Accepted) // 200
                {
                    List<CerereAtribuireModel> cereri = await response.Content.ReadAsAsync<List<CerereAtribuireModel>>();
                    return cereri;
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
