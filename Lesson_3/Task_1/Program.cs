double CalculateFormula(int a, int b, int c, int d)
{
    double numinator = a * b;
    int denuminator = c + d;
    double result = numinator / denuminator;
    return result;
}

System.Console.WriteLine(CalculateFormula(2, 2, 1, 3));