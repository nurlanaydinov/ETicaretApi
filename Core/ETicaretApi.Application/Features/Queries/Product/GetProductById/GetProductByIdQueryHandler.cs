using ETicaretApi.Application.Repositeries;
using MediatR;
using P = ETicaretApi.Domain.Entities;

namespace ETicaretApi.Application.Features.Queries.Product.GetProductById
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQueryRequest, GetProductByIdQueryResponse>
    {
        private readonly IProductReadRepository _productReadRepository;

        public GetProductByIdQueryHandler(IProductReadRepository productReadRepository)
        {
            _productReadRepository = productReadRepository;
        }

        public async Task<GetProductByIdQueryResponse> Handle(GetProductByIdQueryRequest request, CancellationToken cancellationToken)
        {
            P.Product product = await _productReadRepository.GetByIdasync(request.Id, false);
            return new()
            {
                Name = product.Name,
                Stock = product.Stock,
                Price = product.Price
            };
        }
    }
}
