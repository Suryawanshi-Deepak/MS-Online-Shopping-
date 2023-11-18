using CustomerApi.Models;
using MediatR;

namespace CustomerApi.Commands
{
    public class UpdateUserCommand : IRequest<Unit>
    {
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
