using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.TeampLeaber.ProiectColectiv.Models
{
    public class PrelungireContractModel
    {
        public string Numar { get; set; }
        public int NrYears  { get; set; }

        public PrelungireContractModel(string numar, int nrYears)
        {
            this.Numar = numar;
            this.NrYears = nrYears;
        }
    }
}
