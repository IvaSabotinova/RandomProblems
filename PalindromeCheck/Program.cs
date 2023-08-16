

string input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("String cannot be null or whitespace");
    return;
}

char[] output = input.ToCharArray().Reverse().ToArray();

bool isPalindrome = false;

if (input == new string(output))
{
    isPalindrome = true;   
}

Console.WriteLine(isPalindrome);
