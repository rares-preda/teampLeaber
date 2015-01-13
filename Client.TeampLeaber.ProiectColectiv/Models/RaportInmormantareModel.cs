using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.TeampLeaber.ProiectColectiv.Models
{
    public class RaportInmormantareModel
    {
        public int Id { get; set; }
        public CimitirModel Cimitir { get; set; }
        public ParcelaModel Parcela { get; set; }
        public MormantModel Mormant { get; set; }
        public DecedatModel Decedat { get; set; }
        public DateTime Date { get; set; }
        public ReligieModel Religie { get; set; }

        public RaportInmormantareModel(int id, CimitirModel cimitir, ParcelaModel parcela, MormantModel mormant, DecedatModel decedat, DateTime date, ReligieModel religie)
        {
            Id = id;
            Cimitir = cimitir;
            Parcela = parcela;
            Mormant = mormant;
            Decedat = decedat;
            Date = date;
            Religie = religie;
        }

        public override string ToString()
        {
            return "Persoana: " + this.Decedat.Cnp + " " + this.Decedat.Nume + " " + this.Decedat.Prenume +
                "; Cimitir: " + Cimitir.Denumire + "; Parcela: " + Parcela.Denumire + "; Data inmormantarii: " +
                Date.ToShortDateString() + "; Religie: " + Religie.Denumire;
        }

        public bool IsValid()
        {
            var errors = new List<string>();

            if (!Decedat.IsValid())
                return false;

            if (!Cimitir.IsValid())
                return false;

            if (!Parcela.IsValid())
                return false;

            if (Date == null || Date > DateTime.Now)
                errors.Add("Data este invalida.");
            
            if (errors.Count() > 0)
            {
                ErrorHandling.ErrorHandling.Instance.HandleErrors(errors);
                return false;
            }
            return true;
        }
    }
}
