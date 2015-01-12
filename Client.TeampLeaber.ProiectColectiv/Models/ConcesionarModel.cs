using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.TeampLeaber.ProiectColectiv.Models
{
    public class ConcesionarModel
    {
        public string CNP { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Domiciliu { get; set; }

        public ConcesionarModel(string cnp, string nume, string prenume, string domiciliu)
        {
            this.CNP = cnp;
            this.Nume = nume;
            this.Prenume = prenume;
            this.Domiciliu = domiciliu;
        }

        public bool isValid()
        {
            List<string> errorMessages = new List<string>();

            if (this.CNP != null && this.Nume != null && this.Prenume != null && this.Domiciliu != null)
            {
                if (this.CNP.Length != 13)
                {
                    errorMessages.Add("CNP-ul nu este valid");
                }
                if (this.Nume.Length == 0)
                {
                    errorMessages.Add("Introduceti numele concesionarului");
                }
                if (this.Prenume.Length == 0)
                {
                    errorMessages.Add("Introduceti prenumele concesionarului");
                }
                if (this.Domiciliu.Length == 0)
                {
                    errorMessages.Add("Introduceti domiciliu concesionarului");
                }
            }
            else
            {
                errorMessages.Add("ConcesionarModel invalid");
            }

            if (errorMessages.Count() == 0)
            {
                return true;
            }
            else
            {
                ErrorHandling.ErrorHandling.Instance.HandleErrors(errorMessages);
                return false;
            }
        }
    }
}
