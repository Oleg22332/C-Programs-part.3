int Enumeration(int a, int b)
{
    if (a == b)
    {
        return b;
    }
    System.Console.WriteLine(a);
    return Enumeration(a + 1, b);
}
System.Console.WriteLine(Enumeration(1, 10));