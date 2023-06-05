using ETicaretApi.Application.Features.Commands.Product.CreateProduct;
using FluentValidation;

namespace ETicaretApi.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<CreateProductCommandRequest>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                   .WithMessage("Product name can't be empty")
                .MaximumLength(150)
                .MinimumLength(2)
                    .WithMessage("Product name length must be between 2 and 150");
            RuleFor(p => p.Stock)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Stock can't be null or empty!")
                .Must(s => s >= 0)
                    .WithMessage("Stock can't be negative");
            RuleFor(p => p.Price)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Price can't be null or empty!")
                .Must(s => s >= 0)
                    .WithMessage("Price can't be negative");

        }
    }
}
