void PrintSqaures(int limit)
{
    int i = 1;
    while (i < limit)
    {
        System.Console.Write($"{i*i}, ");
        i++;
    }
    System.Console.WriteLine(limit*limit);
}
int b = Convert.ToInt32(Console.ReadLine());
PrintSqaures(b);