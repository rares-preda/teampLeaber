using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.TeampLeaber.ProiectColectiv.Models
{
    public class CerereAtribuireModel
    {
        public int Id { get; set; }
        public int NumarCurent { get; set; }
        public string NumarInfocet { get; set; }
        public DateTime DataCerere { get; set; }
        public StadiuSolutionareModel StadiuSolutionare { get; set; }
        
        public CerereAtribuireModel()
        {

        }

        public CerereAtribuireModel(int _id, int _numarCurent, string _numarInfocet, DateTime _dataCerere, StadiuSolutionareModel _stadiuSolutionare)
        {
            Id = _id;
            NumarCurent = _numarCurent;
            NumarInfocet = _numarInfocet;
            DataCerere = _dataCerere;
            StadiuSolutionare = _stadiuSolutionare;
        }

        public CerereAtribuireModel(int _numarCurent, string _numarInfocet, DateTime _dataCerere, StadiuSolutionareModel _stadiuSolutionare)
	    {
            NumarCurent = _numarCurent;
            NumarInfocet = _numarInfocet;
            DataCerere = _dataCerere;
            StadiuSolutionare = _stadiuSolutionare;
	    }

        public override string ToString()
        {
            return "Nr. curent: " + NumarCurent + "; Nr. infocet: " + NumarInfocet + "; Data: " + DataCerere.ToShortDateString() + "; Stadiu: " + StadiuSolutionare.ToString();
        }

        public bool IsValid()
        {
            var errors = new List<string>();

            if (NumarCurent <= 0)
                errors.Add("Numar curent incorect.");

            if (String.IsNullOrEmpty(NumarInfocet))
                errors.Add("Numar infocet incorect.");

            if (StadiuSolutionare == null || !StadiuSolutionare.IsValid())
                errors.Add("Stadiu de solutionare incorect.");

            if (errors.Count() > 0)
            {
                ErrorHandling.ErrorHandling.Instance.HandleErrors(errors);
                return false;
            }
            return true;
        }
    }
}
