namespace Project48.Extensions
{
    public static class StringExtensions
    {
        public static int ExtractNumber(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            int start = input.IndexOf('#');
            if (start >= 0 && int.TryParse(input[(start + 1)..], out int result))
                return result;

            return 0; // fallback if no number found
        }
    }
}
