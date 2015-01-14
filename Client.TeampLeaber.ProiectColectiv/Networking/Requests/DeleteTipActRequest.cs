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
    public class DeleteTipActRequest : BaseRequest
    {  
        private int ID;
        public DeleteTipActRequest(int id)
        {
            this.ID = id;
        }
        public async Task<bool> Run()
        {
            try
            {
                response = await this.DeleteAsync(Constants.TipActePath + "/" + ID);
                if (response.StatusCode == HttpStatusCode.OK) // 200
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

