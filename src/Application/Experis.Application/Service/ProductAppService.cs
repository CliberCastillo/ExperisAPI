using AutoMapper;
using Experis.Application.DTO;
using Experis.Application.Interface;
using Experis.Domain.Interfaces.Repository;

namespace Experis.Application.Service
{
    public class ProductAppService : IProductAppService
    {
        private readonly IProductRepository _productRepository;

        public readonly IMapper _mapper;
        public ProductAppService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public int Create(ProductDTO productDTO)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public ProductDTO GetById(int id)
        {
            return _mapper.Map<ProductDTO>(_productRepository.GetById(1));
        }

        public int Update(ProductDTO productDTO)
        {
            throw new NotImplementedException();
        }
    }
}
