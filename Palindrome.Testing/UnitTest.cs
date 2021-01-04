
using Xunit;
using Palindrome.Client;

namespace Palindrome.Testing
{
    public class UnitTests
    {
        [Fact]
        public void Palindrome_ReturnTrue()
        {
            string a = "baab";

            bool res = PalindromeCheck.IsPalindrome(a);
            Assert.True(res, "baab should be palindrome");
        }
        [Fact]
        public void Palindrome_ReturnFalse()
        {
            string b = "dfdsafsd";

            bool res = PalindromeCheck.IsPalindrome(b);
            Assert.False(res, "it should not be palindrome");
        }
        [Fact]
        public void Palindrome_Sentence()
        {
            string b = "step on no pets";

            bool res = PalindromeCheck.IsPalindrome(b);
            Assert.True(res, "it should be palindrome");
        }


    }
}
