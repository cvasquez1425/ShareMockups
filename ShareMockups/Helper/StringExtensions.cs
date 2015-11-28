namespace ShareMockups.Helper
{
    public static class StringExtensions
    {
        public static double ToDouble(this string data)
        {
            double result = double.Parse(data);
            return result;
        }

        public static bool IsValidPostalCode(this string value)
        {
            return value.Length == 5 || value.Length == 9;
        }


    }
}