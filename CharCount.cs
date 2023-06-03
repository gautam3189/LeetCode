public class CharCounter
{
    public int CountCharacters(string[] words, string chars)
    {
        var sortedChars = chars.ToArray().GroupBy(c => c).Select(s => new { k = s.Key, c = s.Count() });

        var result = 0;
        for (int i = 0; i < words.Length; i++)
        {
            var wordToCompare = words[i].ToArray().GroupBy(c => c).Select(s => new { k = s.Key, c = s.Count() }); ;
            if (wordToCompare.All(c => sortedChars.Any(a => a.k == c.k && a.c >= c.c)))
            {
                result += words[i].Length;
            }
        }
        return result;
    }


}