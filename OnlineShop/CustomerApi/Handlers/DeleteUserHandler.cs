using CustomerApi.Commands;
using CustomerApi.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CustomerApi.Handlers
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, Unit>
    {
        private readonly ApplicationDbContext _context;
        public DeleteUserHandler(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var userToDelete = await _context.Users.FindAsync(request.UsertId);
            if (userToDelete == null)
            {
                throw new Exception($"Product with {request.UsertId} Id not found");
            }

            _context.Users.Remove(userToDelete);
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
