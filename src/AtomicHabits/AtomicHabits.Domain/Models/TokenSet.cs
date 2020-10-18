using System;
using Jwt = System.String;

namespace AtomicHabits.Domain.Models
{
    public class TokenSet
    {
        public Guid Id { get; set; }
        public Jwt BearerToken { get; set; }
        public DateTime IssuedAt { get; set; }
        public int Duration { get; set; }
        public string RefreshToken { get; set; }        
        public Guid OwnerId { get; set; }
        public User Owner { get; set; }
    }
}