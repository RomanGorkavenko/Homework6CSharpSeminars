partial class Program
{
    static void PrintInputUser(int[] array)
    {
        string print = " ";
        foreach (int i in array)
        {
            print += $", {i}";
        }
        print = print.Remove(1, 2);
        print += ".";
        Console.Write($"{print}");
    }
}