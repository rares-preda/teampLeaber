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
        public string Descriere { get; set; }

        public StadiuSolutionareModel(int _id, string _descriere)
        {
            Id = _id;
            Descriere = _descriere;
        }

        public StadiuSolutionareModel(string _descriere)
        {
            Descriere = _descriere;
        }

        public override string ToString()
        {
            return Descriere;
        }

        public bool IsValid()
        {
            if (Descriere != "")
                return true;

            ErrorHandling.ErrorHandling.Instance.HandleError("Stadiu de solutionare invalid.");
            return false;
        }
    }
}
