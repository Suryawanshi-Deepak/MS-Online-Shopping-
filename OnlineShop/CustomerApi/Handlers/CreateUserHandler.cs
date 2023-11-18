using CustomerApi.Commands;
using CustomerApi.Data;
using CustomerApi.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CustomerApi.Handlers
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly ApplicationDbContext _context;
        public CreateUserHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {

            _context.Users.Add(request.User);
            await _context.SaveChangesAsync();

            return request.User.UserID;
        }
    }
}
