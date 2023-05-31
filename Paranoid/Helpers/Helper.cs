namespace Paranoid.Helpers
{
    public static class Helper
    {
        public static string CapitalizeFirstLetter(string word)
        {
            if (word.Length == 0)
                return "";
            else if (word.Length == 1)
                return char.ToUpper(word[0]).ToString();
            else
                return char.ToUpper(word[0]) + word.Substring(1);
        }
    }
}
