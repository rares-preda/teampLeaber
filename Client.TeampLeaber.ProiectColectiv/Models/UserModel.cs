using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.TeampLeaber.ProiectColectiv.Models
{
    public class UserModel
    {
        public static UserModel Instance { get; set; }

        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
