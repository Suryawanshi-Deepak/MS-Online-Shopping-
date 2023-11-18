using MediatR;

namespace CatalogApi.Features.Commands
{
    public class DeleteProductCommand : IRequest<Unit>
    {
        public int ProductId { get; set; }
    }
}
