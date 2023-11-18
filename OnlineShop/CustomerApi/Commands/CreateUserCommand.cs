using CustomerApi.Models;
using MediatR;

namespace CustomerApi.Commands
{
    public class CreateUserCommand : IRequest<int>
    {
        public User User { get; set; }
    }
}
