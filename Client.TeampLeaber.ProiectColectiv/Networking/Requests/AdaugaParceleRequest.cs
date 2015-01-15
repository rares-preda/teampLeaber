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
    public class AdaugaParceleRequest : BaseRequest
    {
        private ParcelaModelForRequest parcela;

        public AdaugaParceleRequest(ParcelaModelForRequest parcela)
        {
            this.parcela = parcela;
        }

        internal async Task<bool> Run()
        {
            try
            {
                response = await this.PutAsJsonAsync(Constants.ParcelePath, parcela);

                if (response.StatusCode == HttpStatusCode.OK) // 200
                {
                    return true;
                }
                else
                {
                    ErrorModel error = await response.Content.ReadAsAsync<ErrorModel>();
                    ErrorHandling.ErrorHandling.Instance.HandleErrors(error.errors);
                    return false;
                }
            }
            catch(Exception)
            {
                ErrorHandling.ErrorHandling.Instance.HandleError(Constants.ErrorMessages.Unknown_error);
                return false;
            }
        }
    }
}
