namespace ExtraMath
{
    public static class Functions
    {
        public static long Factorial(int value)
        {
            const int largestCalculableArgument = 20;
            if (value < 0 || value > largestCalculableArgument)
                throw new ArgumentOutOfRangeException(nameof(value));
            long result = 1;
            for (int i = 2; i <= value; ++i)
                result *= i;
            return result;
        }
    }
}