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
    class LogInRequest : BaseRequest
    {
        private string email;
        private string password;

        public LogInRequest(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        internal async Task<Models.UserModel> Run()
        {
            UserModel user = new UserModel
            {
                Password = password,
                Username = email
            };
            try
            {
                response = await this.PostAsJsonAsync(Constants.LogInPath, user);

                if (response.StatusCode == HttpStatusCode.OK) // 200
                {
                    UserModel loggedUser = await response.Content.ReadAsAsync<UserModel>();
                    return loggedUser;
                }
                else
                {
                    ErrorModel error = await response.Content.ReadAsAsync<ErrorModel>();
                    ErrorHandling.ErrorHandling.Instance.HandleErrors(error.errors);
                    return null;
                }
            }
            catch(Exception)
            {
                ErrorHandling.ErrorHandling.Instance.HandleError(Constants.ErrorMessages.Unknown_error);
                return null;
            }
        }

        

    }
}
