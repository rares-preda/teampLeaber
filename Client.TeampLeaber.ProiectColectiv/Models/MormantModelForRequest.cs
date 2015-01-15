using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Client.TeampLeaber.ProiectColectiv.Models;

namespace Client.TeampLeaber.ProiectColectiv.Models
{
    public class MormantModelForRequest
    {
        public int IdParcela { get; set; }
        public MormantModel Mormant { get; set; }

        public MormantModelForRequest(int idParcela, MormantModel mormant)
        {
            this.IdParcela = idParcela;
            this.Mormant = mormant;
        }
    }
}
