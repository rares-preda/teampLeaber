using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.TeampLeaber.ProiectColectiv.Models
{
    public class EvidentaContracteConcesiuneModel
    {
        public string Numar { get; set; }

        public DateTime DataExpirare { get; set; }

        public DateTime DataEliberare { get; set; }

        public string Nume { get; set; }

        public string Prenume { get; set; }

        public string Domiciliu { get; set; }

        public override string ToString()
        {
            return Numar + " " + DataEliberare.Year + " " + DataExpirare.Year + " " + Nume + " " + Prenume + " " + Domiciliu;
        }
    }
}
