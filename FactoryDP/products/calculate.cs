namespace FactoryDP.products
{
    public static class calculate
    {
        public static double CalculateDiscountedPrice(double originalPrice, double discount)
        {
            double discountDecimal = discount / 100;
            return originalPrice - originalPrice * discountDecimal;
        }
    }
}
