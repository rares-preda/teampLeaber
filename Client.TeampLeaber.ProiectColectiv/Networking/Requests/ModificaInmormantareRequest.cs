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
    public class ModificaInmormantareRequest : BaseRequest
    {
        private RaportInmormantareModel _inmormantare;


        public ModificaInmormantareRequest(RaportInmormantareModel inmormantare)
        {
            _inmormantare = inmormantare;
        }

        public async Task<bool> Run()
        {
            try
            {
                response = await this.PostAsJsonAsync(Constants.RaportInmormantariPath, _inmormantare);

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
