using CatalogApi.Features.Commands;
using MediatR;
using CatalogApi.DbContexts;

namespace CatalogApi.Features.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand,int>
    {
        private readonly CatalogDbContext _dbContext;
        public CreateProductCommandHandler(CatalogDbContext dbContexts)
        {
            _dbContext = dbContexts;
        }

        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            _dbContext.Products.Add(request.Product);
            await _dbContext.SaveChangesAsync();

            return request.Product.ProductId;
        }
    }
}
