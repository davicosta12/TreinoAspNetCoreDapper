using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using TreinoAspNetCore.Database;
using TreinoAspNetCore.Models;
using TreinoAspNetCore.Repositories;

namespace TreinoAspNetCore.Services
{
    public class ProductServices
    {
        private readonly AuthenticationServices _authenticationService;

        public ProductServices(AuthenticationServices authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public async Task<List<Product>> GetProductList()
        {
            var token = await _authenticationService.GetToken();
            var client = new RestClient("https://oms.ajsy.com.br/api/Produtos/Lista?isActive=true");
            var request = new RestRequest("", Method.GET);

            request.AddHeader("authorization", "Bearer " + token);

            IRestResponse response = await client.ExecuteGetAsync<List<Product>>(request);

            // var response = client.Get<List<Product>>(request);

            var productList = JsonSerializer.Deserialize<List<Product>>(response.Content);

            return productList;
        }

    }
}
