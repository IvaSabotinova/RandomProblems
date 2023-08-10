

Console.WriteLine(AnagramCheck("silent", "listen"));
File.WriteAllText("../../../text.txt", $"{AnagramCheck("silent", "listen")}");
static bool AnagramCheck(string first, string second)
{
    if (first.Count() != second.Count())
    {
        return false;
    }
    else
    {
        List<char> firstWord = new List<char>(first);
        List<char> secondWord = new List<char>(second);

        foreach (char c in firstWord)
        {
            if (secondWord.Contains(c))
            {
                int index = secondWord.IndexOf(c);
                secondWord.RemoveAt(index);
            }
            else
            {
                break;
            }
        }
        return secondWord.Count == 0;
       
    }
}
