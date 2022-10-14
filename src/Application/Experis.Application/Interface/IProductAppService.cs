using Experis.Application.DTO;

namespace Experis.Application.Interface
{
    public interface IProductAppService
    {
        int Create(ProductDTO productDTO);
        int Update(ProductDTO productDTO);
        List<ProductDTO> GetAll();
        ProductDTO GetById(int id);
        int Delete(int id);
    }
}
