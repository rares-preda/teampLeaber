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
        public static readonly string ReligiiPath = "/api/religie";
        public static readonly string CimitirePath = "/api/cimitir";
        public static readonly string ParcelePath = "/api/parcela";
        public static readonly string MormintePath = "/api/mormant";
        public static readonly string ConcesionarPath = "/api/concesionar";
        public static readonly string ContracteConcesionarPath = "/api/contractConcesiune";
        public static readonly string InmormantarePath = "/api/inmormantare";
        public static readonly string RaportInmormantariPath = "/api/inmormantare";
        public static readonly string TipActePath = "/api/tipAct";
        public static readonly string PrelungireContractConcesiune = "/api/ContractConcesiune/Prelungire";
        public static readonly string RenuntareContractConcesiune = "/api/ContractConcesiune";
        public static readonly string AdaugareContractConcesiune = "/api/ContractConcesiune";
        public static readonly string AdaugareConcesionariSuccessMessage = "Concesionar adaugat cu success";
        public static readonly string ActePath = "/api/act";
        public static readonly string RaportMormintePath = "/api/Mormant/Raport";
        public static readonly string PersoanaDecedataPath = "/api/PersoanaDecedata";

        public static class ErrorMessages
        {
            public static readonly string Unknown_error = "A aparut o eroare!";
            public static readonly string INVALID_CNP = "CNP invalid";
            public static readonly string NO_CNP_CONCESIONAR = "Adaugati CNP-ul concesionarului";
            public static readonly string INVALID_DEAD_PERSON_PERSONAL_DATA = "Introduceti datele personale ale mortului";
            public static readonly string NO_RELIGION_SELECTED = "Va rugam alegeti o religie valida";
            public static readonly string NO_MORMANT_SELECTED = "Alegeti un mormant concesionat";
            public static readonly string LISTA_VIDA = "Nu a fost gasit nici un rezultat.";
            public static readonly string NO_INSTANCES_MORMINTE_CONCESIONAR = "Nu exista morminte atribuite acestui concesionar";
        }

        public static string SUCCESS_MESSAGE = "Operatia a fost realizata cu succes !";
    }
}
