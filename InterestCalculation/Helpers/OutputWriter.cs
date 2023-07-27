namespace InterestCalculation.Helpers
{
    public class OutputWriter
    {
        public void DisplayFinalValue(decimal finalValue)
        {
            Console.WriteLine($"The final value of your investment is: {finalValue:C}");
        }
    }
}