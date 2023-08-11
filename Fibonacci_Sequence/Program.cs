
int number = int.Parse(Console.ReadLine());

long []array = new long [number];

long firstNumber = 0;
long secondNumber = 1;

array[0] = firstNumber;
array[1] = secondNumber;

if (number == 1 || number == 2)
{
    Console.WriteLine("Input number should be at least 3");
}
else
{
    for (int i = 2; i < number; i++)
    {
        long resultNumber = firstNumber + secondNumber;
        firstNumber = secondNumber;
        secondNumber = resultNumber;
        array[i] = resultNumber;
    }
    Console.WriteLine(string.Join(", ", array));
}



