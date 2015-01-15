using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.TeampLeaber.ProiectColectiv.Models
{
    public class MormantModel
    {
        public int Id { get; set; }
        public string NumeCimitir { get; set;}
        public string NumeParcela { get; set; }
        public double? Suprafata { get; set; }
        public int Numar { get; set; }
        public bool AreValoareIstorica { get; set; }
        public string Observatie { get; set; }

        public MormantModel(int id, double suprafata, int numar, bool areValoareIstorica, string observati)
        {
            this.Id = id;
            this.Suprafata = suprafata;
            this.Numar = numar;
            this.AreValoareIstorica = areValoareIstorica;
            this.Observatie = observati;
        }

        public bool isValid()
        {
            var errors = new List<string>();

            if (this.Id < 0)
            {
                errors.Add("Id-ul trebuie sa fie pozitiv");
            }
            if (this.Suprafata < 0)
            {
                errors.Add("Suprafata mormatului trebuie sa fie numar pozitiv");
            }
            if (this.Numar < 0)
            {
                errors.Add("Numarul mormantului trebuie sa fie numar pozitiv");
            }

            if (errors.Count() > 0)
            {
                ErrorHandling.ErrorHandling.Instance.HandleErrors(errors);
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return NumeCimitir + ", " + NumeParcela + ", " + Numar + " (" + Suprafata + " mp)";
        }
    }
}
