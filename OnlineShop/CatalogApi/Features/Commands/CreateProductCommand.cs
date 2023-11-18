using CatalogApi.Models;
using MediatR;
using System.Security.Principal;

namespace CatalogApi.Features.Commands
{
    public class CreateProductCommand : IRequest<int>
    {
        public Product Product { get; set; }
    }
}
