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
    public class RaportInmormantariRequest : BaseRequest
    {
        private int an;

        public RaportInmormantariRequest(int an)
        {
            this.an = an;
        }

        public async Task<List<RaportInmormantareModel>> Run()
        {
            try
            {
                response = await this.GetAsync(Constants.RaportInmormantariPath + "?year=" + this.an);

                if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Accepted) // 200
                {
                    List<RaportInmormantareModel> inmormantari = await response.Content.ReadAsAsync<List<RaportInmormantareModel>>();
                    return inmormantari;
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
