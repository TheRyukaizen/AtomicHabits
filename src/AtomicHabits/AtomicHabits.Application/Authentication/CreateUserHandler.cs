using System;
using System.Threading;
using System.Threading.Tasks;
using AtomicHabits.Domain.Models;
using AtomicHabits.Infrastructure.Cryptography;
using AtomicHabits.Infrastructure.DAL;
using MediatR;

namespace AtomicHabits.Application.Authentication
{
    
    public class CreateUserHandler : AsyncRequestHandler<CreateUser>
    {
        private readonly HabitContext _context;
        private readonly IPasswordHasher _hasher;

        public CreateUserHandler(HabitContext context, IPasswordHasher hasher)
        {
            _context = context;
            _hasher = hasher;
        }

        protected override async Task Handle(CreateUser request, CancellationToken cancellationToken)
        {
            var user = new User
            {
                Email = request.Email,
                CreatedAt = DateTime.Now,
                CreatedBy = request.UserName,
                UserName = request.UserName,
                MarketingMailsAllowed = false, // TODO: Implement
                PasswordHash = _hasher.Hash(request.Password)
            };

            await _context.Users.AddAsync(user, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

        }
    }
}