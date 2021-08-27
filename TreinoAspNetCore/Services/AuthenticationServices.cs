using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using TreinoAspNetCore.Models.Authentication;

namespace TreinoAspNetCore.Services
{
    public class AuthenticationServices
    {
        public async Task<string> GetToken()
        {
            var client = new RestClient("https://oms.ajsy.com.br/api/Authentication");

            var request = new RestRequest("", Method.POST);
            request.AddJsonBody(new
            {
                branchId = 1,
                usuario = "admin",
                senha = "$ervid0r"
            });

            IRestResponse response = await client.ExecutePostAsync<AuthenticationResponse>(request);

            // var response = client.Post(request);

            var jsonElement = JsonSerializer.Deserialize<AuthenticationResponse>(response.Content);

            return jsonElement.token;
        }
    }

}
