using System.ComponentModel.DataAnnotations;
using MediatR;

namespace AtomicHabits.Application.Authentication.DTOs
{
    public class CreateUserDto : IRequest<Unit>, IRequest<bool>
    {
        [Required, MaxLength(255)]
        public string UserName { get; set; }

        [Required, MinLength(8)]
        public string Password { get; set; }
        
        [Required, EmailAddress] public string Email { get; set; }
        
    }
}