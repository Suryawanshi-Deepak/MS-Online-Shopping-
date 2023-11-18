using CatalogApi.DbContexts;
using CatalogApi.Features.Commands;
using MediatR;

namespace CatalogApi.Features.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Unit>
    {
        private readonly CatalogDbContext _dbContext;
        public UpdateProductCommandHandler(CatalogDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var existingProduct = await _dbContext.Products.FindAsync(request.ProductId);

            if (existingProduct == null)
            {
                throw new Exception($"Product with {request.ProductId} Id not found.");
            }

            existingProduct.Description = request.UpdateProduct.Description;
            existingProduct.Price = request.UpdateProduct.Price;
            existingProduct.Availability = request.UpdateProduct.Availability;

            await _dbContext.SaveChangesAsync();

            return Unit.Value;

        }
    }
}
