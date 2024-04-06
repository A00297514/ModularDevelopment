namespace UtilityLibraries;
/// <summary>
/// This class holds extension mehtods for the string data type
/// </summary>
public static class StringLibrary
{
    /// <summary>
    /// Detects whether or not the first letter is an uppercase letter.
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static bool StartsWithUpper(this string? str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return false;

        char ch = str[0];
        return char.IsUpper(ch);
    }
}