using MediatR;

namespace CustomerApi.Commands
{
    public class DeleteUserCommand : IRequest<Unit>
    {
        public int UsertId { get; set; }
    }
}
