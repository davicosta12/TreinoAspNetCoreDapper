using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreinoAspNetCore.Models.Authentication
{
    public class AuthenticationResponse
    {
        public Empresa empresa { get; set; }
        public string token { get; set; }
    }
}
