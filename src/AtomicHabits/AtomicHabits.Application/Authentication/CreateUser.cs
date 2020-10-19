using System.ComponentModel.DataAnnotations;
using MediatR;

namespace AtomicHabits.Application.Authentication
{
    public class CreateUser : IRequest
    {
        [Required, MaxLength(255)]
        public string UserName { get; set; }

        [Required, MinLength(8)]
        public string Password { get; set; }
        
        [Required, EmailAddress] public string Email { get; set; }
    }
}