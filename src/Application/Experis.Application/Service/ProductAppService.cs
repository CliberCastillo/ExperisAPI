using AutoMapper;
using Experis.Application.DTO;
using Experis.Application.Interface;
using Experis.Domain.Entities;
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
            return _productRepository.Create(_mapper.Map<Product>(productDTO));
        }

        public int Delete(int id)
        {
            return _productRepository.Delete(id);
        }

        public List<ProductDTO> GetAll()
        {
            return _mapper.Map<List<ProductDTO>>(_productRepository.GetAll());
        }

        public ProductDTO GetById(int id)
        {
            return _mapper.Map<ProductDTO>(_productRepository.GetById(id));
        }

        public int Update(ProductDTO productDTO)
        {
            return _productRepository.Update(_mapper.Map<Product>(productDTO));
        }
    }
}
