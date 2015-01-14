using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Client.TeampLeaber.ProiectColectiv.Utils;
using Client.TeampLeaber.ProiectColectiv.Models;

namespace Client.TeampLeaber.ProiectColectiv.Networking.Requests
{
    public class GetInmormantariByDate : BaseRequest
    {
        private DateTime data;
        private int mormantId;

        public GetInmormantariByDate(DateTime d, int i)
        {
            data = d;
            mormantId = i;
        }
        public async Task<List<RaportInmormantareModel>> Run()
        {
            try
            {
                string fullpath = Constants.InmormantarePath + "?Year=" +  data.Year + "&Month=" + data.Month + "Day=" +  data.Day + "&MormantId=" + mormantId;
                response = await this.GetAsync(fullpath);

                if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Accepted) // 200
                {
                    List<RaportInmormantareModel> value = await response.Content.ReadAsAsync<List<RaportInmormantareModel>>();
                    return value;
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
