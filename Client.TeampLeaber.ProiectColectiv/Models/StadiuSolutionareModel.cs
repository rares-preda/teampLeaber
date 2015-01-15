using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.TeampLeaber.ProiectColectiv.Models
{
    public class StadiuSolutionareModel
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        
        public StadiuSolutionareModel()
        {

        }

        public StadiuSolutionareModel(int _id, string _descriere)
        {
            Id = _id;
            Denumire = _descriere;
        }

        public StadiuSolutionareModel(string _descriere)
        {
            Denumire = _descriere;
        }

        public override string ToString()
        {
            return Denumire;
        }

        public bool IsValid()
        {
            if (Denumire != String.Empty)
                return true;

            ErrorHandling.ErrorHandling.Instance.HandleError("Stadiu de solutionare invalid.");
            return false;
        }
    }
}
