using Dapper;
using Experis.Domain.Entities;
using Experis.Domain.Interfaces.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Experis.Infrastructure.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IConfiguration _configuration;
        public ProductRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public int Create(Product product)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("Conexion")))
            {
                connection.Open();
                return connection.Execute("CreateProduct", product, commandType: CommandType.StoredProcedure);
            }
        }

        public int Delete(int id)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("Conexion")))
            {
                connection.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", id);
                return connection.Execute("DeleteProduct", param, commandType: CommandType.StoredProcedure);
            }
        }

        public List<Product> GetAll()
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("Conexion")))
            {
                connection.Open();
                var nose= connection.Query<Product>("GetAllProduct").ToList();
                return nose;
            }
        }

        public Product GetById(int id)
        {
            try
            {
                using (var connection = new SqlConnection(_configuration.GetConnectionString("Conexion")))
                {
                    connection.Open();
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@Id", id);
                    return connection.Query<Product>("GetByIdProduct", param, commandType: CommandType.StoredProcedure).First();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int Update(Product product)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("Conexion")))
            {
                connection.Open();
                return connection.Execute("UpdateProduct", product, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
