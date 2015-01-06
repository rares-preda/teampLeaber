using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.TeampLeaber.ProiectColectiv.Utils
{
    public class Constants
    {
        public static readonly string IP = "http://192.168.1.114";
        public static readonly string PORT = "1132";
        public static readonly string HOST = IP + ":" + PORT;
        public static readonly string LogInPath = "/api/utilizator";
        public static readonly string GetReligiiPath = "/api/religie";
        public static readonly string GetMorminteByConcesionarPath = "/api/concesionar";
        public static readonly string ProgramareInmormantarePath = "/api/inmormantare";
        public static class ErrorMessages
        {
            public static readonly string Unknown_error = "A aparut o eroare!";
            public static readonly string NO_CNP_CONCESIONAR = "Adaugati CNP-ul concesionarului";
            public static readonly string INVALID_DEAD_PERSON_PERSONAL_DATA = "Introduceti datele personale ale mortului";

            public static readonly string NO_RELIGION_SELECTED = "Va rugam alegeti o religie valida";

            public static readonly string NO_MORMANT_SELECTED = "Alegeti un mormant concesionat";
        }

    }
}
