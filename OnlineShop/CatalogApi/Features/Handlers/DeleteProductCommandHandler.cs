using CatalogApi.DbContexts;
using CatalogApi.Features.Commands;
using MediatR;

namespace CatalogApi.Features.Handlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand,Unit>
    {
        private readonly CatalogDbContext _dbContext;
        public DeleteProductCommandHandler(CatalogDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var productToDelete = await _dbContext.Products.FindAsync(request.ProductId);
            if (productToDelete == null)
            {
                throw new Exception($"Product with {request.ProductId} Id not found");
            }

            _dbContext.Products.Remove( productToDelete );
            await _dbContext.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
