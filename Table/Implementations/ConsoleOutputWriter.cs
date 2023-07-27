using Table.Interfaces;

namespace Table.Implementations
{
    public class ConsoleOutputWriter : IOutputWriter
    {
        public void DisplayTable(int[,] table)
        {
            Console.WriteLine("Table:");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{table[i, 0]} x {table[i, 1]} = {table[i, 1]}");
            }
        }
    }
}