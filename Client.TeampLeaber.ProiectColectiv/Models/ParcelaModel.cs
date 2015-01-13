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
            List<string> errors = new List<string>();
            if (Id != null && Denumire != null)
            {
                if (Denumire.Length == 0)
                {
                    errors.Add("Introduceti un nume valid.");
                }
            }
            if (errors.Count() == 0)
            {
                return true;
            }
            else
            {
                ErrorHandling.ErrorHandling.Instance.HandleErrors(errors);
                return false;
            }
        }

        public override string ToString()
        {
            return this.Denumire;
        }
    }
}
