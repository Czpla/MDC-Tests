using Table.Interfaces;

namespace Table.Implementations
{
    public class ConsoleInputReader : IInputReader
    {
        public int ReadNumber()
        {
            Console.WriteLine("Enter a number: ");
            var input = Console.ReadLine();

            while (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Invalid input. Please enter a valid number: ");
                input = Console.ReadLine();
            }

            return int.Parse(input);
        }
    }
}