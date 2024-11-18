﻿using System.Globalization;

namespace Store.Reviews;

public class ReviewValidation
{
    internal record LocalizedWord(string Text, CultureInfo Culture);

    private static IEnumerable<LocalizedWord> DisallowedWords { get; } = ReviewHelper.LoadDisallowedWords();

    public static string StringValidation(string data, char replacementChar, CultureInfo culture)
    {
        var words = DisallowedWords
            .Where(word => culture.Equals(CultureInfo.InvariantCulture) || culture.Equals(word.Culture))
            .Select(word => word.Text);

        foreach (string word in words)
        {
            data = data.Replace(word, replacementChar.ToString(), ignoreCase: true, culture);
        }
        return data;
    }
}
