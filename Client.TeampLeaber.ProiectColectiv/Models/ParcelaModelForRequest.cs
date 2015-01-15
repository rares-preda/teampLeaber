using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.TeampLeaber.ProiectColectiv.Models
{
    public class ParcelaModelForRequest
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public int CimitirId { get; set; }

        public ParcelaModelForRequest(int id, string denumire, int cimitirId)
        {
            this.Id = id;
            this.Denumire = denumire;
            this.CimitirId = cimitirId;
        }
    }
}
