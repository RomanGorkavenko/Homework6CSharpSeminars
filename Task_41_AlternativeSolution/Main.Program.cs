
partial class Program
{
    static string[] arrayNumbers = Console.ReadLine().Split().ToArray();
    static int[] resultNumbers = new int[arrayNumbers.Length];
    static void Main()
    {
        Console.Write("Введите целые числа через пробел: ");

        ExceptionHandling(Program.arrayNumbers);
        int countNumbers = GetCountNumbers(Program.resultNumbers);
        
        string caseNumber = "числа";
        if (countNumbers > 4 || countNumbers == 0) caseNumber = "чисел";
        else if (countNumbers == 1) caseNumber = "число";
        
        PrintInputUser(Program.resultNumbers);
        
        Console.Write($" -> {countNumbers} {caseNumber} больше нуля");
    }
}