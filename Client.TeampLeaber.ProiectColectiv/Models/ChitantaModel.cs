using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.TeampLeaber.ProiectColectiv.Models
{
    public class ChitantaModel
    {
        public int Id { get; set; }
        public string Numar { get; set; }
        public double Suma { get; set; }

        public ChitantaModel(int id, string numar, double suma)
        {
            this.Id = id;
            this.Numar = numar;
            this.Suma = suma;
        }

        public override string ToString()
        {
            return "Id: " + Id + " Numar: " + Numar + " Suma: " + Suma;
        }

        public bool isValid()
        {
            List<string> errorMessages = new List<string>();
            if (this.Numar != null)
            {
                if (this.Id < 0)
                {
                    errorMessages.Add("Id-ul trebuie sa fie pozitiv");
                }
                if (this.Numar.Length == 0)
                {
                    errorMessages.Add("Numar chitanta inexistent");
                }
                if (this.Suma < 0)
                {
                    errorMessages.Add("Suma trebuie sa fie numar pozitiv");
                }
            }
            else
            {
                errorMessages.Add("ChitantaModel invalid");
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
