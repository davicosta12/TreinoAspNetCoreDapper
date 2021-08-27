using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreinoAspNetCore.Models;

namespace TreinoAspNetCore.Repositories.Contracts
{
    public interface IProductsRepository
    {
        Task SaveProducts();
    }
}
