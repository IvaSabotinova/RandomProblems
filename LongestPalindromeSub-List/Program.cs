string input = Console.ReadLine();
Console.WriteLine(GetMaxPalindromeStringLength(input));


static int GetMaxPalindromeStringLength(string input)
{
    int maxLengthOfPalindrome = 1;
    string reversedInput = new string(input.ToCharArray().Reverse().ToArray());
    for (int i = 0; i < input.Length; i++)
    {
        for (int j = 0; j < reversedInput.Length; j++)
        {
            if (input[i] == reversedInput[j])
            {
                int tempI = i;
                int count = 0;
                while (input[i] == reversedInput[j])
                {
                    count++;
                    i++;
                    j++;
                    if (maxLengthOfPalindrome < count)
                    {
                        maxLengthOfPalindrome = count;
                    }
                    if (count == input.Length || j == reversedInput.Length || i == input.Length)
                    {
                        break;
                    }
                }
                i = tempI;

            }
        }
    }

    return maxLengthOfPalindrome;
}






