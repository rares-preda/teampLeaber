using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.TeampLeaber.ProiectColectiv.Models
{
    public class DecedatModel
    {
        public string Cnp { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public List<ActeModel> Acte { get; set; }
    }
}
