using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.TeampLeaber.ProiectColectiv.Models
{
    public class ContractModel
    {
        public ContractModel(string Numar, DateTime DataEliberare, DateTime DataExpirare,
                             ChitantaModel Chitanta, CimitirModel cimitirModel,
                                ParcelaModel parcela, MormantModel mormant)
        {
            this.Numar = Numar;
            this.DataEliberare = DataEliberare;
            this.DataExpirare = DataExpirare;
            this.Chitanta = Chitanta;
            this.Cimitir = cimitirModel;
            this.Parcela = parcela;
            this.Mormant = mormant;
        }

        public bool isValid()
        {
            List<string> errorMessages = new List<string>();
            if (this.Numar != null && this.DataEliberare != null && this.DataExpirare != null && this.Chitanta != null && this.Cimitir != null && this.Parcela != null && this.Mormant != null)
            { 
                
                if ( !this.Chitanta.isValid() ) 
                {
                    return false;
                }
                if( !this.Cimitir.IsValid() ) {
                    return false;
                }
                if (!this.Parcela.IsValid() ) {
                    return false;
                }
                if( !this.Mormant.isValid() ) {
                    return false;
                }

                if (this.Numar == "")
                {
                    errorMessages.Add("Chitanta nu are numar");
                }
            }
            else
            {
                errorMessages.Add("ParcelaModel invalid");
            }

            if (errorMessages.Count() == 0)
            {
                return true;
            }
            else
            {
                ErrorHandling.ErrorHandling.Instance.HandleErrors(errorMessages);
                return false;
            }
        }

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
