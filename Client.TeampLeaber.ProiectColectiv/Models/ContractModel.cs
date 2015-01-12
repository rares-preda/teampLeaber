using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.TeampLeaber.ProiectColectiv.Models
{
    public class ContractModel
    {
        public string Numar { get; set; }

        public DateTime DataEliberare { get; set; }

        public DateTime DataExpirare { get; set; }

        public ChitantaModel Chitanta { get; set; }

        public CimitirModel Cimitir { get; set; }

        public ParcelaModel Parcela { get; set; }

        public MormantModel Mormant { get; set; }

        public override string ToString()
        {
            return "Numar contract: " + Numar + " Data eliberare: " + DataEliberare +
                " Data expirare: " + DataExpirare + " Chitanta " + Chitanta + " Cimitir:  " + Cimitir +
                " Parcela: " + Parcela + " Mormant " + Mormant;
        }
    }
}
