using Palindrome.Interfaces;

namespace Palindrome.Implementations
{
    public class SimplePalindromeChecker : IPalindromeChecker
    {
        public bool IsPalindrome(string word)
        {
            // Clean the word by removing any non-alphanumeric characters and converting to lowercase
            string cleanedWord = new string(word.Where(char.IsLetterOrDigit).ToArray()).ToLower();

            int left = 0;
            int right = cleanedWord.Length - 1;

            while (left < right)
            {
                if (cleanedWord[left] != cleanedWord[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
    }
}