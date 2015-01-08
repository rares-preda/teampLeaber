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
            else
            {
                errors.Add("Cimitir invalid.");
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
    }
}
