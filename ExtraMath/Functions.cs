namespace ExtraMath
{
    public static class Functions
    {
        public static long Factorial(int value)
        {
            const int largestCalculableArgument = 20;
            if (value < 0 || value > largestCalculableArgument)
                throw new ArgumentOutOfRangeException(nameof(value));
            if (value == 0)
                return 1;
            long result = value;
            while (--value > 1)
                result *= value;
            return result;
        }
    }
}