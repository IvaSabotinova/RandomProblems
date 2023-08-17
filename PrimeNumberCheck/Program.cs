


Console.WriteLine(IsPrime(19));

static bool IsPrime(int number)
{
    bool isPrime = false;
    int count = 0;
	if (number > 1)
	{
        isPrime = true;
        for (int i = 1; i <= number; i++)
        {

            if (number % i == 0)
            {
                count++;
                if (count > 2)
                {
                    isPrime = false;
                    break;
                }
            }
        }
    }
  
	return isPrime;
}