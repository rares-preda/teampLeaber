using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Client.TeampLeaber.ProiectColectiv.Models
{
    public class DecedatModel
    {
        public string Cnp { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public List<ActModel> Acte { get; set; }

        public bool AreApartinator { get; set; }
        public bool IsValid()
        {
            if (!AreApartinator)
                return true;
            var errors = new List<string>();

            if (String.IsNullOrEmpty(Nume))
                errors.Add("Introduceti numele persoanei decedate");

            if (String.IsNullOrEmpty(Prenume))
                errors.Add("Introduceti prenumele persoanei decedate");
            if (String.IsNullOrEmpty(Cnp))
                errors.Add("Introduceti Cnp-ul decedate");
            if (!Regex.IsMatch(Cnp, "^[0-9]+$", RegexOptions.Compiled) || Cnp.Length != 13)
                errors.Add("Cnp invalid");

            if (errors.Count() > 0)
            {
                ErrorHandling.ErrorHandling.Instance.HandleErrors(errors);
                return false;
            }
            return true;
        }
    }
}
