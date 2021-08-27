using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreinoAspNetCore.Models.Authentication
{
    public class Empresa
    {
        public int idGrupo { get; set; }
        public int idRede { get; set; }
        public int branchId { get; set; }
        public string codigoFilial { get; set; }
        public string filial { get; set; }
        public string usuario { get; set; }
        public string email { get; set; }
        public string urlLogo { get; set; }
        public bool isOperador { get; set; }
        public bool isAdmin { get; set; }
        public bool enviaProduto { get; set; }
        public bool enviaPreco { get; set; }
        public int maxDop { get; set; }
        public int maxDopArray { get; set; }
        public int arrayInputMax { get; set; }
    }
}
