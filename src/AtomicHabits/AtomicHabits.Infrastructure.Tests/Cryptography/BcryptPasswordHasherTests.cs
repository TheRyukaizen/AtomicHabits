using AtomicHabits.Infrastructure.Cryptography;
using Xunit;

namespace AtomicHabits.Infrastructure.Tests.Cryptography
{
    public class BcryptPasswordHasherTests
    {
        [Fact]
        public void ShouldHashPassword()
        {
            var sut = new BcryptPasswordHasher();
            var verySecret = "Hello World";


            var hashedSecret = sut.Hash(verySecret);
            
            Assert.NotEqual(verySecret, hashedSecret);
        }

        [Fact]
        public void ShouldCorrectlyVerifyHash()
        {
            var sut = new BcryptPasswordHasher();
            var verySecret = "Hello World";

            var hashedSecret = sut.Hash(verySecret);

            Assert.True(sut.Verify(verySecret, hashedSecret));
            Assert.NotEqual(verySecret, hashedSecret);
        }

        [Fact]
        public void ShouldNotVerifyIncorrectHash()
        {
            var sut = new BcryptPasswordHasher();
            var verySecret = "Hello World";

            var hashedSecret = sut.Hash(verySecret);

            Assert.False(sut.Verify("Hi!", hashedSecret));
            Assert.NotEqual(verySecret, hashedSecret);
        }
    }
}