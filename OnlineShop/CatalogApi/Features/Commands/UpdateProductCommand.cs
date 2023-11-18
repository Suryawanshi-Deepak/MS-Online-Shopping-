using CatalogApi.Models;
using MediatR;

namespace CatalogApi.Features.Commands
{
    public class UpdateProductCommand : IRequest<Unit>
    {
        public int ProductId { get; set; }
        public Product UpdateProduct { get; set; }
    }
}
