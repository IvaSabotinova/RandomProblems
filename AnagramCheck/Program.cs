

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


//ChatGPT version - not perfect, valid only for letters
//string str1 = "listen";
//string str2 = "silent";
//bool result = AreAnagrams(str1, str2);
//Console.WriteLine(result);  // Output: True

//string str3 = "112233";
//string str4 = "123321";
//bool result2 = AreAnagrams(str3, str4);
//Console.WriteLine(result2);  // Output: False
// static bool AreAnagrams(string str1, string str2)
//{
//    // Remove any whitespace and convert both strings to lowercase
//    str1 = str1.Replace(" ", "").ToLower();
//    str2 = str2.Replace(" ", "").ToLower();

//    // Check if the lengths of the strings are equal
//    if (str1.Length != str2.Length)
//    {
//        return false;
//    }

//    // Create character frequency counters for both strings
//    int[] counter1 = new int[26];
//    int[] counter2 = new int[26];

//    // Update the counters for each character in the first string
//    foreach (char c in str1)
//    {
//        counter1[c - 'a']++;
//    }

//    // Update the counters for each character in the second string
//    foreach (char c in str2)
//    {
//        counter2[c - 'a']++;
//    }

//    // Check if the character frequency counters are equal
//    for (int i = 0; i < 26; i++)
//    {
//        if (counter1[i] != counter2[i])
//        {
//            return false;
//        }
//    }

//    // If all checks passed, the strings are anagrams
//    return true;
//}