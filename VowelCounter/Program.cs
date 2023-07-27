using VowelCounter.Implementations;
using VowelCounter.Helpers;

namespace VowelCounter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var consoleIO = new ConsoleIO();
            var vowelCounter = new VowelCounterHelper();

            string input = consoleIO.GetInput("Enter a sentence: ")!;
            int vowelCount = vowelCounter.CountVowels(input);
            consoleIO.ShowOutput($"Number of vowels in the sentence: {vowelCount}");
        }
    }
}