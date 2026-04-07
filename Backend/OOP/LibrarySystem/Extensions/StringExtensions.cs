namespace LibrarySystem.Extensions;

internal static class StringExtensions
{
    public static string NormalizeID(this string value)
    {
        return value?.Trim().ToUpperInvariant() ?? string.Empty;
    }

    public static bool ContainsDigits(this string value)
    {
        if (string.IsNullOrEmpty(value)) return false;

        for (int i = 0; i < value.Length; i++)
        {
            if (char.IsDigit(value[i]))
                return true;
        }
        return false;
    }

    public static bool IsValidEmail(this string value)
    {
        if (string.IsNullOrEmpty(value)) return false;

        bool hasAT = false;
        bool hasDOT = false;

        for (int i = 0; i < value.Length; i++)
        {
            if (value[i] == '@') hasAT = true;
            if (value[i] == '.') hasDOT = true;
        }
        return hasAT && hasDOT;
    }
}
