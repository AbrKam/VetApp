namespace VetApp.Domain.Commons
{
    public static class Guard
    {
        public static string NotNullOrWhiteSpace(string value, string paramName)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException($"{paramName} cannot be empty!");

            return value.Trim();
        }
    }
}