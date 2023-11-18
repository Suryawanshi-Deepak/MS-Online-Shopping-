using CustomerApi.Models;
using MediatR;

namespace CustomerApi.Commands
{
    public class GetUserCommand : IRequest<User>
    {
        public int UserId { get; set; }
    }
}
