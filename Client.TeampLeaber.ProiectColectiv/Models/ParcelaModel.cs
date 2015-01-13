using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.TeampLeaber.ProiectColectiv.Models
{
    public class ParcelaModel
    {
        public ParcelaModel(int _id, string _denumire)
        {
            Id = _id;
            Denumire = _denumire;
        }

        public int Id { get; set; }
        public string Denumire { get; set; }

        public bool IsValid()
        {
            List<string> errorMessages = new List<string>();
            if (this.Denumire != null)
            {
                if (this.Id < 0)
                {
                    errorMessages.Add("Id-ul trebuie sa fie pozitiv");
                }
                if (this.Denumire.Length == 0)
                {
                    errorMessages.Add("Introduceti denumirea parcelei");
                }
            }
            else
            {
                errorMessages.Add("ParcelaModel invalid");
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

        public override string ToString()
        {
            return this.Denumire;
        }
    }
}
