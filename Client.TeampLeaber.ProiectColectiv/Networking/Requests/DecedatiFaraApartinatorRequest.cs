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
    public class DecedatiFaraApartinatorRequest : BaseRequest
    {
        internal async Task<List<DecedatFaraApartinatorModel>> Run()
        {
            try
            {
                response = await this.GetAsync(Constants.PersoanaDecedataPath + "/GetFaraApartinator");

                if (response.StatusCode == HttpStatusCode.OK) //200
                {
                    List<DecedatFaraApartinatorModel> decedatiFaraApartinator = await response.Content.ReadAsAsync<List<DecedatFaraApartinatorModel>>();
                    return decedatiFaraApartinator;
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
