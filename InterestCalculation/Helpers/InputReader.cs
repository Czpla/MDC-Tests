namespace InterestCalculation.Helpers
{
    public class InputReader
    {
        public decimal ReadDecimal(string message)
        {
            return ReadInput<decimal>(message, decimal.TryParse, "decimal");
        }

        public int ReadInt(string message)
        {
            return ReadInput<int>(message, int.TryParse, "integer");
        }

        public int ReadInt(string message, int minValue, int maxValue)
        {
            return ReadInput<int>(message, int.TryParse, "integer", value => value >= minValue && value <= maxValue);
        }

        private T ReadInput<T>(string message, TryParseDelegate<T> tryParse, string typeName, Func<T, bool>? validate = null)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine()!;
                if (tryParse(input, out T value))
                {
                    if (validate == null || validate(value))
                    {
                        return value;
                    }
                    else if (validate != null)
                    {
                        Console.WriteLine($"Invalid input. Please enter a valid {typeName} value between the specified range.");
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid input. Please enter a valid {typeName} value.");
                }
            }
        }

        private delegate bool TryParseDelegate<T>(string s, out T result);
    }
}