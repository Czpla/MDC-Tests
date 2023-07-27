namespace PrimeNumbers 
{
    public class Program
    {
        private const int NumberOfPrimesToPrint = 10;

        public static void Main()
        {
            int primeCount = 0;
            int currentNumber = 2;

            Console.WriteLine("First {0} prime numbers:", NumberOfPrimesToPrint);

            while (primeCount < NumberOfPrimesToPrint)
            {
                if (IsPrime(currentNumber))
                {
                    Console.Write(currentNumber + " ");
                    primeCount++;
                }

                currentNumber += currentNumber == 2 ? 1 : 2;
            }

            Console.WriteLine();
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            if (number == 2)
                return true;

            if (number % 2 == 0)
                return false;

            int maxDivisor = (int)Math.Sqrt(number);
            
            for (int divisor = 3; divisor <= maxDivisor; divisor += 2)
            {
                if (number % divisor == 0)
                    return false;
            }

            return true;
        }
    }
}