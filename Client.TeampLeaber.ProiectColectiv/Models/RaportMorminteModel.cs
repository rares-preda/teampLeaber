using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.TeampLeaber.ProiectColectiv.Models
{
    public class RaportMorminteModel
    {
        public ParcelaModel Parcela { get; set; }
        public MormantModel Mormant { get; set; }
        public ConcesionarModel Concesionar { get; set; }
        public string NumarChitanta { get; set; }
        public List<InmormantareModel> Inmormantari { get; set; }

        public RaportMorminteModel(ParcelaModel parcela, MormantModel mormant, ConcesionarModel concesionar, List<InmormantareModel> inmormantari)
        {
            Parcela = parcela;
            Mormant = mormant;
            Concesionar = concesionar;
            Inmormantari = inmormantari;
        }

        public override string ToString()
        {
            string raport = "Parcela: " + Parcela.Denumire + "; Mormant: " + Mormant.Numar.ToString() + "; ";
            if (Concesionar != null)
            {
                raport += "Concesionar: " + Concesionar.Nume + " " + Concesionar.Prenume + "; Chitanta: " + NumarChitanta + "; ";
            }
            return raport;
        }
    }
}
