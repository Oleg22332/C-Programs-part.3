int[] array = {1, 5, 5, 10, 8, 9};
void PrintArrayReverse(int[] arr, int i)
{
    if (i < 0)
    {
        return;
    }
    Console.WriteLine(arr[i]);
    PrintArrayReverse(arr, i - 1);
}
PrintArrayReverse(array, array.Length - 1);