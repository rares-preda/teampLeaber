using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.TeampLeaber.ProiectColectiv.Models
{
    public class ReligieModel
    {
        public int Id { get; set; }
        public string Denumire { get; set; }

        public override string ToString()
        {
            return Denumire;
        }
    }
}
