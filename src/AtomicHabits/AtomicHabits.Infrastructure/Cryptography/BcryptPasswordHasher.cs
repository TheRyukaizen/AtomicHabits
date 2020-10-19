﻿using System.Security.Cryptography;
using System.Text;

namespace AtomicHabits.Infrastructure.Cryptography
{
    public class BcryptPasswordHasher : IPasswordHasher
    {
        public string Hash(string password) 
            => BCrypt.Net.BCrypt.EnhancedHashPassword(password);

        public bool Verify(string password, string hash) => BCrypt.Net.BCrypt.EnhancedVerify(password, hash);

    }
}