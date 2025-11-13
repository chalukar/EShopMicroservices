using MediatR;

namespace Catalog.API.Products.CreateProduct
{
    public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price)
        : IRequest<CreateProductResponse>;
    public record CreateProductResponse(Guid Id);
    internal class CreateProducCommandtHandler : IRequestHandler<CreateProductCommand, CreateProductResponse>
    {
        public Task<CreateProductResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
} 
