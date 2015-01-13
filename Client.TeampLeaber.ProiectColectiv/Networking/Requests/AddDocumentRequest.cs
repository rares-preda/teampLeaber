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
    public class AddDocumentRequest : BaseRequest
    {
        private Models.ActeModel model;
        public AddDocumentRequest(Models.ActeModel model)
        {
            this.model = model;
        }

        internal async Task<bool> Run()
        {
            try
            {
                response = await this.PutAsJsonAsync(Constants.ActePath, model);

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
            catch (Exception)
            {
                ErrorHandling.ErrorHandling.Instance.HandleError(Constants.ErrorMessages.Unknown_error);
                return false;
            }
        }

    }
}
