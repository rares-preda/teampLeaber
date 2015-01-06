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
    public class MorminteByConcesionar : BaseRequest
    {
        private string _cnp;
        public MorminteByConcesionar(string Cnp)
        {
            _cnp = Cnp;
        }
        public async Task<Models.MorminteConcesionar> Run()
        {
            try
            {
                response = await this.GetAsync(Constants.GetMorminteByConcesionarPath + "?cnp=" + _cnp);

                if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Accepted) // 200
                {
                    Models.MorminteConcesionar value = await response.Content.ReadAsAsync<Models.MorminteConcesionar>();
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
