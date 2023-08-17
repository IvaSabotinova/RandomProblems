
Console.WriteLine(string.Join(", ", SumOfTwoNumber(new int[] { 1, -2, 3, 8, 9, 10, 11, 0, 7, 4, 13 }, 11)));
static List<(int, int)> SumOfTwoNumber(int[] array, int number)
{
    List<(int, int)> list = new List<(int, int)>();
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] + array[j] == number)
            {
                list.Add((i, j));
            }
        }
    }
    return list;
}
