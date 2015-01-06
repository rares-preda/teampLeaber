using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.TeampLeaber.ProiectColectiv.Models
{
    public class MormantModel
    {
        public int Id { get; set; }
        public string NumeCimitir { get; set;}
        public string NumeParcela { get; set; }
        public double? Suprafata { get; set; }
        public int Numar { get; set; }

        public override string ToString()
        {
            return NumeCimitir + ", " + NumeParcela + ", " + Numar + " (" + Suprafata + " mp)";
        }
    }
}
