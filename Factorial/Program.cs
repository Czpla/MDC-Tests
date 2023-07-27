namespace Factorial
{

    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Factorial Calculator");
            Console.WriteLine("--------------------");

            try
            {
                Console.Write("Enter a non-negative integer: ");
                int number = int.Parse(Console.ReadLine()!);

                if (number < 0)
                {
                    Console.WriteLine("Error: Please enter a non-negative integer.");
                }
                else
                {
                    ulong factorial = CalculateFactorial(number);
                    Console.WriteLine($"The factorial of {number} is: {factorial}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid non-negative integer.");
            }
        }

        public static ulong CalculateFactorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("The number must be non-negative integer.", nameof(number));
            }

            ulong factorial = 1;

            for (int i = 2; i <= number; i++)
            {
                factorial *= (ulong)i;
            }

            return factorial;
        }
    }
}