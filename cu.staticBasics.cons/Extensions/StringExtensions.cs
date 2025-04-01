namespace cu.staticBasics.cons.Extensions;

public static class StringExtensions
{
    public static string GetFirstLetter(this string word)
    {
        //return the first letter of the word

        return word[0].ToString();
        // return word.Substring(0, 1).ToUpper();
    }
}