using Experis.Domain.Entities;

namespace Experis.Domain.Interfaces.Repository
{
    public interface IProductRepository
    {
        int Create(Product product);
        int Update(Product product);
        List<Product> GetAll();
        Product GetById(int id);
        int Delete(int id);
    }
}
