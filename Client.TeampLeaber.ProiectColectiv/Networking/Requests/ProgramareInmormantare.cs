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
    public class ProgramareInmormantareRequest : BaseRequest
    {
        private InmormantareModel model;
       

        public ProgramareInmormantareRequest(InmormantareModel model)
        {
            this.model = model;
        }

        public ProgramareInmormantareRequest(string nume, string prenume, string cnp, int religionId, int mormantId, DateTime date, List<ActeModel> acte)
        {
            this.model = new InmormantareModel();
            model.Data = date;
            model.Decedat = new DecedatModel();
            model.Decedat.Cnp = cnp;
            model.Decedat.Nume = nume;
            model.Decedat.Prenume = prenume;
            model.Decedat.Acte = acte;
            model.MormantId = mormantId;
            model.ReligieId = religionId;
        }

        public async Task<bool> Run()
        {
            try
            { 
                response = await this.PutAsJsonAsync(Constants.ProgramareInmormantarePath, model);

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
