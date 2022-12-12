using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruteforceLibrary
{
    public class Bruteforce
    {

        public IEnumerable<string> GeneratePassword(string characters, int length)
        {
            if (length == 0) yield return "";
            else
            {
                foreach (char values in characters)
                {
                    foreach (string value in GeneratePassword(characters, length - 1))
                    {
                        yield return values + value;
                    }
                }
            }
        }

        public long CalculatePossiblePasswords(int passwordLength, string passwordCharacters) => (long)Math.Pow(passwordCharacters.Length, passwordLength);
    }
}
