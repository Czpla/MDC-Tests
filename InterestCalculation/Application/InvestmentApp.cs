using InterestCalculation.Helpers;

namespace InterestCalculation.Application
{
    public class InvestmentApp
    {
        private readonly InputReader inputReader;
        private readonly OutputWriter outputWriter;
        private readonly InvestmentCalculator investmentCalculator;

        public InvestmentApp()
        {
            inputReader = new InputReader();
            outputWriter = new OutputWriter();
            investmentCalculator = new InvestmentCalculator();
        }

        public void Run()
        {
            decimal initialCapital = inputReader.ReadDecimal("Enter the initial capital: ");
            decimal interestRate = inputReader.ReadDecimal("Enter the interest rate (%): ");
            int investmentTimeInMonths = inputReader.ReadInt("Enter the investment time (in months): ");

            decimal finalValue = investmentCalculator.CalculateFinalValue(initialCapital, interestRate, investmentTimeInMonths);

            outputWriter.DisplayFinalValue(finalValue);
        }
    }
}