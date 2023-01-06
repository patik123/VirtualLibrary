namespace Helpers
{
    public class Text
    {
        public static string Capitalize(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            return char.ToUpper(text[0]) + text.Substring(1);
        }

        public static string CapitalizeAll(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            var words = text.Split(' ');
            var capitalizedWords = new List<string>();

            foreach (var word in words)
            {
                capitalizedWords.Add(Capitalize(word));
            }

            return string.Join(" ", capitalizedWords);
        }

        public static string removeWhiteSpace(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            return text.Trim();
        }
    }
}