using Table.Interfaces;

namespace Table.Implementations
{
    public class TableGenerator : ITableGenerator
    {
        public int[,] GenerateTable(int number)
        {
            int[,] table = new int[10, 2];

            for (int i = 0; i < 10; i++)
            {
                table[i, 0] = i + 1;
                table[i, 1] = (i + 1) * number;
            }

            return table;
        }
    }
}