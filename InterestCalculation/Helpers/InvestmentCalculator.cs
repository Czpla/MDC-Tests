namespace InterestCalculation.Helpers
{
    public class InvestmentCalculator
    {
        public decimal CalculateFinalValue(decimal initialCapital, decimal interestRate, int investmentTimeInMonths)
        {
            // Assuming monthly compound interest
            decimal monthlyInterestRate = interestRate / 100 / 12;
            decimal finalValue = initialCapital * (decimal)Math.Pow(1 + (double)monthlyInterestRate, investmentTimeInMonths);
            return finalValue;
        }
    }
}
