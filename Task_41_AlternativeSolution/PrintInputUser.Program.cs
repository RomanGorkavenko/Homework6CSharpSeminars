partial class Program
{
    static void PrintInputUser(int[] arrayString)
    {
        string stringArray = " ";

        for (int i = 0; i < arrayString.Length; i++)
        {
            stringArray += $"{arrayString[i]}, ";
        }
        int n = stringArray.Length;
        stringArray = stringArray.Remove(n - 2, 2);
        stringArray += " ";
        Console.Write($"{stringArray}");
    }
}