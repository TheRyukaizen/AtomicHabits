using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
using AtomicHabits.Application.Authentication.DTOs;
using AtomicHabits.Infrastructure.DAL;
using AtomicHabits.Infrastructure.MediatR;
using MediatR;

namespace AtomicHabits.Application.Authentication
{
    
    public class CreateUser : ValidatingRequestHandler<ValidatedResponse<CreateUserDto>, bool>
    {
        private readonly HabitContext _context;

        public CreateUser(HabitContext context)
        {
            _context = context;
        }
        
        public Task<bool> Handle(CreateUserDto request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}