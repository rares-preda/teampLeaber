using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Client.TeampLeaber.ProiectColectiv.Utils;
using Client.TeampLeaber.ProiectColectiv.Models;

namespace Client.TeampLeaber.ProiectColectiv.Networking.Requests
{
    public class RaportMorminteRequest : BaseRequest
    {
        private int _cimitirId;
        private int _monumentFunerar;

        public RaportMorminteRequest(int cimitirId, bool monumentFunerar)
        {
            _cimitirId = cimitirId;
            if (monumentFunerar == true) _monumentFunerar = 1;
            else _monumentFunerar = 0;
        }

        public async Task<List<RaportMorminteModel>> Run()
        {
            try
            {
                response = await this.GetAsync(Constants.RaportMormintePath + "?cimitirId=" + _cimitirId + "&monumentFunerar=" + _monumentFunerar);

                if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Accepted) // 200
                {
                    List<RaportMorminteModel> morminte = await response.Content.ReadAsAsync<List<RaportMorminteModel>>();
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
