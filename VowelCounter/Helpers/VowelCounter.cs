namespace VowelCounter.Helpers
{
    public class VowelCounterHelper
    {
        public int CountVowels(string input)
        {
            int count = 0;

            foreach (char c in input)
            {
                if (IsVowel(c))
                    count++;
            }

            return count;
        }

        private bool IsVowel(char c)
        {
            char lowerChar = char.ToLower(c);

            return lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' || lowerChar == 'o' || lowerChar == 'u';
        }
    }
}
