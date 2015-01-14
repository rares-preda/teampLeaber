using Client.TeampLeaber.ProiectColectiv.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Client.TeampLeaber.ProiectColectiv.Utils;

namespace Client.TeampLeaber.ProiectColectiv.Networking.Requests
{
    public class PostReligionRequest : BaseRequest
    {
        private ReligieModel model;


        public PostReligionRequest(ReligieModel model)
        {
            this.model = model;
        }

        public async Task<bool> Run()
        {
            try
            {
                response = await this.PostAsJsonAsync(Constants.ReligiiPath, model);

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

