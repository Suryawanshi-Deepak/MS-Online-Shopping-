using CustomerApi.Commands;
using CustomerApi.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CustomerApi.Handlers
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, Unit>
    {
        private readonly ApplicationDbContext _context;
        public UpdateUserHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var existingUser = await _context.Users.FindAsync(request.UserId);

            if (existingUser == null)
            {
                throw new Exception($"Product with {request.UserId} Id not found.");
            }

            existingUser.UserName = request.User.UserName;
            existingUser.Password = request.User.Password;
            existingUser.ContactNo = request.User.ContactNo;
            existingUser.UserType = request.User.UserType;
            existingUser.Address = request.User.Address;

            
            await _context.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
