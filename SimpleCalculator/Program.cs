namespace SimpleCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("-----------------");

            double num1 = GetNumberFromUser("Enter the first number: ");
            char @operator = GetOperatorFromUser();
            double num2 = GetNumberFromUser("Enter the second number: ");

            double result = 0.0;

            switch (@operator)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    return;
            }

            Console.WriteLine($"Result: {result}");
        }

        private static double GetNumberFromUser(string message)
        {
            Console.Write(message);
            double number;

            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }

            return number;
        }

        private static char GetOperatorFromUser()
        {
            Console.Write("Enter the operator (+, -, *, /): ");
            char @operator;

            while (!char.TryParse(Console.ReadLine(), out @operator) || !IsValidOperator(@operator))
            {
                Console.Write("Invalid operator. Please enter a valid one (+, -, *, /): ");
            }

            return @operator;
        }

        private static bool IsValidOperator(char @operator)
        {
            return @operator == '+' || @operator == '-' || @operator == '*' || @operator == '/';
        }
    }
}
