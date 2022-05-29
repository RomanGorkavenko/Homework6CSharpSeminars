partial class Program
{
    static void ExceptionHandling(string[] numbers)
    {
        int length = numbers.Length;
        bool yesInt;
        for (int i = 0; i < length; i++)
        {
            yesInt = int.TryParse(numbers[i], out int result);
            if (yesInt)
            {
                Program.resultNumbers[i] = result;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0}", numbers[i]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" -> Некорректный ввод!");
            }
        }
    }
}