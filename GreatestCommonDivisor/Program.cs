
Console.WriteLine(GreatestCommonDivisor(9,2));


static int GreatestCommonDivisor(int a, int b)
{
    int remainder;

    while (b != 0)
    {
        remainder = a % b;
        a = b;
        b = remainder;
    }

    return a;

    //int smaller = a;
    //if (a > b)
    //{
    //    smaller = b;
    //}
    //int gcd = 1;
    //for (int i = 1; i <= smaller; i++)
    //{
    //    if (a % i == 0 && b % i == 0)
    //    {
    //        gcd = i;
    //    }
    //}
    //if (a == 0)
    //{
    //    gcd = b;
    //}
    //if (b == 0){
    //    gcd = a;
    //}
    //return gcd;
    //  return b == 0 ? a : GreatestCommonDivisor(b, a % b);
}