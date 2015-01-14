using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.TeampLeaber.ProiectColectiv.Models
{
    public class ActModel
    {
        public int Id { get; set; }
        public int Numar { get; set; }
        public int TipActId { get; set; }
        public string TipActName { get; set; }

        public ActModel(string numar, int Id, string tip)
        {
            int n;
            if (!Int32.TryParse(numar, out n))
                this.Numar = 0;
            else 
                this.Numar = n;
            this.TipActId = Id;
            this.TipActName = tip;
        }
        public bool IsValid()
        {
            List<string> errors = new List<string>();
            if (this.Numar <= 0)
                errors.Add("Va rugam introduceti un numar de act valid!");
             if (this.TipActId <= 0)
                errors.Add("Tip act invalid!");

            if (errors.Count() > 0)
            {
                ErrorHandling.ErrorHandling.Instance.HandleErrors(errors);
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return TipActName + "    " + Numar;
        }
        public ActModel(int id, int numar, int tipActId)
        {
            this.Id = id;
            this.Numar = numar;
            this.TipActId = tipActId;

        }
    }
}
