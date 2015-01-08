using Client.TeampLeaber.ProiectColectiv.Utils;
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

        public InmormantareModel(string _decedatNume, string _decedatPrenume, string  _decedatCNP, int _religieId,
                int _mormantId, DateTime _selectedDate)
        {
            this.Decedat = new DecedatModel();
            this.Decedat.Nume = _decedatNume;
            this.Decedat.Prenume = _decedatPrenume;
            this.Decedat.Cnp = _decedatCNP;
            this.ReligieId = _religieId;
            this.MormantId = _mormantId;
            this.Data = _selectedDate;

        }

        public bool IsValid()
        {
            var errors = new List<string>();

            if (!Decedat.IsValid())
                return false;

            if (this.Data == null)
                errors.Add("Data este invalida");
            if (ReligieId == 0)
                errors.Add("Alegeti o religie!");
            if (MormantId == 0)
                errors.Add("Alegeti un mormant valid!");

            if (errors.Count() > 0)
            {
                ErrorHandling.ErrorHandling.Instance.HandleErrors(errors);
                return false;
            }
            return true;
        }
    }
}
