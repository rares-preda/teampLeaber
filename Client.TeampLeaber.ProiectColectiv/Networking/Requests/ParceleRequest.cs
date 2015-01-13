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
    public class ParceleRequest : BaseRequest
    {
        private int _idCimitir;

        public ParceleRequest(int idCimitir)
        {
            _idCimitir = idCimitir;
        }

        public async Task<List<ParcelaModel>> Run()
        {
            try
            {
                response = await this.GetAsync(Constants.ParcelePath + "/GetByCimitir?cimitirId=" + this._idCimitir);

                if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Accepted) // 200
                {
                    List<ParcelaModel> parcele = await response.Content.ReadAsAsync<List<ParcelaModel>>();
                    return parcele;
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
