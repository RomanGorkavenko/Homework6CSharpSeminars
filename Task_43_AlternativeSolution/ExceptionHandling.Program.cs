partial class Program
{
    static void ExceptionHandling(string a1, string a2, string c1, string c2)
    {
        bool yesInt = double.TryParse(a1, out double d1);
        bool yesInt1 = double.TryParse(a2, out double d2);
        bool yesInt2 = double.TryParse(c1, out double f1);
        bool yesInt3 = double.TryParse(c2, out double f2);

        if (yesInt && yesInt1 && yesInt2 && yesInt3)
        {
            double x = (f2 - f1) / (d1 - d2);
            double y = ((f2 * d1) - (f1 * d2)) / (d1 - d2);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($" x = {x:F1}; y = {y:F1} ");
            Console.BackgroundColor = ConsoleColor.Black;

        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{a1}, {a2}, {c1}, {c2}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" -> Некорректный ввод!");
        }
    }
}