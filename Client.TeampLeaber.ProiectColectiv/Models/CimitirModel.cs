using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.TeampLeaber.ProiectColectiv.Models
{
    public class CimitirModel
    {
        public CimitirModel(int id, string denumire)
        {
            Id = id;
            Denumire = denumire;
        }

        public int Id { get; set; }
        public string Denumire { get; set; }

        public override string ToString()
        {
            return "Id: " + Id + " Denumire: " + Denumire;
        }

        public bool isValid()
        {
            List<string> errorMessages = new List<string>();
            if (Denumire != null)
            {
                if (Id < 0)
                {
                    errorMessages.Add("Id-ul trebuie sa fie pozitiv");
                }
                if (Denumire.Length == 0)
                {
                    errorMessages.Add("Introduceti denumirea cimitirului");
                }
            }
            else
            {
                errorMessages.Add("CimitirModel invalid");
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
