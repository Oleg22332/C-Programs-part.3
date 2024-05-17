int n = 5;
int[] array = {3, 4, 7, 4, 23};
int max = array[1];
for (int i = 0; i < n; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}
System.Console.WriteLine(max);