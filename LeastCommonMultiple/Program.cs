
int p, q, x, y, lcm;
p = x = 20;
q = y = 25;

while (x != y)
{
    if (x > y)
        x = x - y;
    else
        y = y - x;
}

lcm = (p * q) / x;
Console.WriteLine("LCM of " + p + " and " + q + " is: " + lcm);
