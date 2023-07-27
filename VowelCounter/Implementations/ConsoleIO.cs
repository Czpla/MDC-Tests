using VowelCounter.Interfaces;

namespace VowelCounter.Implementations
{
    public class ConsoleIO : IInput, IOutput
    {
        public string? GetInput(string message)
        {
            Console.Write(message);
            
            return Console.ReadLine();
        }

        public void ShowOutput(string message)
        {
            Console.WriteLine(message);
        }
    }
}