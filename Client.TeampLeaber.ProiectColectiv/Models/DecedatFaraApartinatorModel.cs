using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Client.TeampLeaber.ProiectColectiv.Models;

namespace Client.TeampLeaber.ProiectColectiv.Models
{
    public class DecedatFaraApartinatorModel
    {
        public ActModel AdeverintaInhumare { get; set; }

        public ActModel SolicitareIml { get; set; }

        public string Cimitir { get; set; }

        public string Parcela { get; set; }

        public int NrMormant { get; set; }

        public override string ToString()
        {
            return "Adeverinta:" + AdeverintaInhumare.ToString() + "   Iml:" + SolicitareIml.ToString() + "   Cimitir:" + Cimitir + "   Parcela:" + Parcela + "   Numar:" + NrMormant.ToString();
            //return AdeverintaInhumare.ToString() + " " + SolicitareIml.ToString() + " " + Cimitir + " " + Parcela + " " + NrMormant.ToString();
        }
    }
}
