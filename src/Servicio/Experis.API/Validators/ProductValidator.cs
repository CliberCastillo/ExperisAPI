using Experis.Application.DTO;
using FluentValidation;

namespace Experis.API.Validators
{
    public class ProductValidator : AbstractValidator<ProductDTO>
    {
        public ProductValidator()
        {
            RuleFor(product => product.Id).NotNull().NotEmpty();
            RuleFor(product => product.Name).NotNull().NotEmpty().Length(1, 250);
            RuleFor(product => product.Price).NotNull().NotEmpty();
            RuleFor(product => product.Stock).NotNull().NotEmpty().InclusiveBetween(1, 1000); ;
            RuleFor(product => product.Registrationdate).NotNull().NotEmpty();
        }
    }
}
