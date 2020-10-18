using System;

namespace AtomicHabits.Domain.Models
{
    public class User : BaseEntity
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool MarketingMailsAllowed { get; set; }
        public string PasswordHash { get; set; }
    }
}