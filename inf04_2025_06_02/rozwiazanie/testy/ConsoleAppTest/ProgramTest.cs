using ConsoleApp;

namespace ConsoleAppTest
{
    public class ProgramTest
    {
        [Fact]
        public void CaesarCipher_WithInputAtBeginningOfAlphabet_ShiftsLettersForward()
        {
            string input = "abc";
            int key = 3;

            string result = Program.CaesarCipher(input, key);

            Assert.Equal("def", result);
        }

        [Fact]
        public void CaesarCipher_WithInputAtEndOfAlphabet_WrapsAround()
        {
            string input = "xyz";
            int key = 3;

            string result = Program.CaesarCipher(input, key);

            Assert.Equal("abc", result);
        }

        [Fact]
        public void CaesarCipher_WithNegativeKey_ShiftsLettersBackward()
        {
            string input = "def";
            int key = -3;

            string result = Program.CaesarCipher(input, key);

            Assert.Equal("abc", result);
        }

        [Fact]
        public void CaesarCipher_WithKeyGreaterThanAlphabetLength_NormalizesKey()
        {
            string input = "abc";
            int key = 29;

            string result = Program.CaesarCipher(input, key);

            Assert.Equal("def", result);
        }

        [Fact]
        public void CaesarCipher_WithSpaces_PreservesSpaces()
        {
            string input = "ab cd";
            int key = 2;

            string result = Program.CaesarCipher(input, key);

            Assert.Equal("cd ef", result);
        }
    }
}