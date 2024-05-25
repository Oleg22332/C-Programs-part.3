int m = 2;
int n = 1;
int result = AckermanFunction(m, n);
static int AckermanFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return AckermanFunction(m - 1, 1);
    else
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}
Console.WriteLine($"Ackermann({m}, {n}) = {result}");