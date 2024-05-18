char[,] matrix = {
    {'с', 'т', 'р'},
    {'о', 'к', 'а'}
};
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        System.Console.Write(matrix[i,j]);
    }
}