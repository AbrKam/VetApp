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

        public static T NotNull<T>(T value, string paramName) where T : class
        {
            if (value is null)
            {
                throw new ArgumentNullException(paramName);
            }

            return value;
        }

        public static void ValidateStartAndEnd(DateTime startAt, DateTime endAt)
        {
            if (startAt >= endAt)
                throw new ArgumentException("End date must be after start date!");
        }
    }
}