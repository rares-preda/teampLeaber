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
    public class MorminteRequest : BaseRequest
    {
        private int _idParcela;

        public MorminteRequest(int idParcela)
        {
            _idParcela = idParcela;
        }

        public async Task<List<MormantModel>> Run()
        {
            try
            {
                response = await this.GetAsync(Constants.MormintePath + "/GetByParcela?parcelaId=" + this._idParcela);

                if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Accepted) // 200
                {
                    List<MormantModel> morminte = await response.Content.ReadAsAsync<List<MormantModel>>();
                    return morminte;
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
