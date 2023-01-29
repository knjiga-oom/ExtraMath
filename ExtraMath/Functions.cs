namespace ExtraMath
{
    public static class Functions
    {
        public static long Factorial(int value)
        {
            long result = value;
            while (--value > 1)
                result *= value;
            return result;
        }
    }
}