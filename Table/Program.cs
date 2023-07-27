using Table.Implementations;
using Table.Interfaces;

namespace Table
{
    class Program
    {
        public static void Main()
        {
            IInputReader inputReader = new ConsoleInputReader();
            ITableGenerator tableGenerator = new TableGenerator();
            IOutputWriter outputWriter = new ConsoleOutputWriter();

            var number = inputReader.ReadNumber();
            var table = tableGenerator.GenerateTable(number);
            outputWriter.DisplayTable(table);
        }
    }
}