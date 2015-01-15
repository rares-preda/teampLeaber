using Client.TeampLeaber.ProiectColectiv.Models;
using Client.TeampLeaber.ProiectColectiv.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Client.TeampLeaber.ProiectColectiv.Networking.Requests
{
    public class ModificareCerereAtribuireRequest : BaseRequest
    {
        private CerereAtribuireModel _cerere;

        public ModificareCerereAtribuireRequest(CerereAtribuireModel cerere)
        {
            _cerere = cerere;
        }

        public async Task<bool> Run()
        {
            try
            {
                response = await this.PostAsJsonAsync(Constants.CereriAtribuirePath, _cerere);

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
