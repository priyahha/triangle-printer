using System;
using System.Text.RegularExpressions;

public class DateExtractor
{
    public static void Main(string[] args)
    {
        string text = "The date is 06282023, and it is an important day.";
        string pattern = @"\b(0[1-9]|1[0-2])(0[1-9]|[12]\d|3[01])(\d{4})\b";

        Regex regex = new Regex(pattern);
        Match match = regex.Match(text);

        if (match.Success)
        {
            string matchedDate = match.Value;
            if (DateTime.TryParseExact(matchedDate, "MMddyyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
            {
                Console.WriteLine("Valid date found: " + date);
            }
            else
            {
                Console.WriteLine("Failed to parse the date.");
            }
        }
        else
        {
            Console.WriteLine("No valid date found.");
        }
    }
}
