namespace TourismUtilities
{
    public class FinancialCalculator
    {
        public decimal CalculateTotalCost(decimal nightlyRate, int nights)
        {
            return nightlyRate * nights;
        }

        public decimal ApplyDiscount(decimal totalCost, decimal discountPercentage)
        {
            return totalCost - (totalCost * (discountPercentage / 100));
        }
    }
}
