string originalString = "потоп";
        char[] charArray = originalString.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);
if (originalString == reversedString)
{
    System.Console.WriteLine("является палиндромом");
}
else
{
    System.Console.WriteLine("не является палиндромом");
}T