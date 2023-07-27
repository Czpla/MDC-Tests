using Palindrome.Implementations;
using Palindrome.Interfaces;

namespace Palindrome
{
    public class Program
    {
        private static readonly IPalindromeChecker _palindromeChecker = new SimplePalindromeChecker();

        public static void Main()
        {
            Console.WriteLine("Palindrome Checker");
            Console.WriteLine("------------------");

            while (true)
            {
                Console.Write("Enter a word (or 'exit' to quit): ");
                string input = Console.ReadLine()!;

                if (input.ToLower() == "exit")
                {
                    break;
                }

                bool isPalindrome = _palindromeChecker.IsPalindrome(input);

                if (isPalindrome)
                {
                    Console.WriteLine($"{input} is a palindrome!");
                }
                else
                {
                    Console.WriteLine($"{input} is not a palindrome.");
                }

                Console.WriteLine();
            }
        }
    }
}