using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.TeampLeaber.ProiectColectiv.Models
{
    public class InmormantareModel
    {
        public DecedatModel Decedat { get; set; }
        public int MormantId { get; set; }
        public DateTime Data { get; set; }
        public int ReligieId { get; set; }
    }
}
