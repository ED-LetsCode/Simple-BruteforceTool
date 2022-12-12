using BruteforceLibrary;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace BruteforceConsole
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!\"§$%&/()=?*+'#äÄöÖ-_.:,;<>";
            Bruteforce bruteforce = new Bruteforce();
            int passwordLength = 5;
            
            long possiblePasswords = bruteforce.CalculatePossiblePasswords(passwordLength, characters);
            Console.WriteLine($"Possible passwords: {possiblePasswords}");
            IEnumerable<string> passwords = null;
            
            for (long i = 0; i <= possiblePasswords; i++)
            {
                passwords = bruteforce.GeneratePassword(characters, passwordLength);
            }

            passwords.ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
