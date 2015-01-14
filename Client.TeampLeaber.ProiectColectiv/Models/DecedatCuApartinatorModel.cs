using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.TeampLeaber.ProiectColectiv.Models
{
    public class DecedatCuApartinatorModel
    {
        public int Id { get; set; }

        public string Nume { get; set; }

        public string Prenume { get; set; }

        public string Cimitir { get; set; }

        public string Parcela { get; set; }

        public int NrMormant { get; set; }

        public override string ToString()
        {
            //return "Nume:" + Nume + " Prenume: " + Prenume + " Cimitir: " + Cimitir + " Parcela: " + Parcela + " Numar: " + NrMormant.ToString();
            return Nume + " " + Prenume + " " + Cimitir + " " + Parcela + " " + NrMormant.ToString();
        }
    }
}
