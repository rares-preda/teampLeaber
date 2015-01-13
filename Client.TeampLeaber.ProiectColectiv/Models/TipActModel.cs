using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.TeampLeaber.ProiectColectiv.Models
{
    public class TipActModel
    {
        public TipActModel(string name)
        {
            this.Denumire = name;
        }
        public int Id { get; set; }
        public string Denumire { get; set; }

        public override string ToString()
        {
            return this.Denumire;
        }

        internal bool IsValid()
        {
           
            if (String.IsNullOrEmpty(this.Denumire))
            {
                if (this.Denumire == String.Empty)
                return false;
            }
            return true;
        }
    }
}
