using System.Data.SqlClient;
using System.Threading.Tasks;
using TreinoAspNetCore.Database;
using TreinoAspNetCore.Models;
using TreinoAspNetCore.Repositories.Contracts;

namespace TreinoAspNetCore.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly DbConnectionFactory _dbConnectionFactory;

        public ProductsRepository(DbConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;
        }

        public async Task SaveProducts()
        {
            using (var conn = _dbConnectionFactory.CreateConnection())
            {
                string sql = @"
                    INSERT INTO produtosativos(productId,
                                                refId,
                                                name,
                                                releaseDate,
                                                cor,
                                                isActive)
                    VALUES(@productId,
                           @refId,
                           @name,
                           @releaseDate,
                           @cor,
                           @isActive)";

                conn.
                
            }
        }
    }
}
