// Раскоментируйте ниже для проверки условия
// double k1 = 5;
// double k2 = 9;
// double b1 = 2;
// double b2 = 4;

// Закоментируйте ниже для проверки условия

string[] GetFillArray()
{
    string[] array = new string[4];
    int length = array.Length;
    string namePoint = "K1";
    for (int i = 0; i < length; i++)
    {
        if(i < 2)
        {
            namePoint = $"K{i + 1}";
        }
        else namePoint = $"B{i - 1}";
        Console.Write($"Введите число для {namePoint}: ");
        array[i] = Console.ReadLine().Replace(".", ",");
    }
    return array;
}

(bool ex, double[] arr) ExceptionHandling(string[] array)
{
    double[] arrayDouble = new double[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        bool yesDouble = double.TryParse(array[i], out double d);
        if (!yesDouble)
        {
            return (false, arrayDouble);
        }
        else arrayDouble[i] = d;
    }
    return (true, arrayDouble);
}


string[] enteredValues = GetFillArray();
var count = ExceptionHandling(enteredValues);
if (count.ex)
{
    double x = (count.arr[3] - count.arr[2]) / (count.arr[0] - count.arr[1]);
    double y = ((count.arr[3] * count.arr[0]) - (count.arr[2] * count.arr[1])) / (count.arr[0] - count.arr[1]);
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($" x = {x:F1}; y = {y:F1} ");
    Console.BackgroundColor = ConsoleColor.Black;

}
else
{
    // Console.ForegroundColor = ConsoleColor.Red;
    // Console.Write($"{a1}, {a2}, {c1}, {c2}");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(" -> Некорректный ввод!");
}


// Раскоментируйте ниже для проверки
// double b3 = y - count.arr[0] * x;
// double k3 = (y - F1) / x;
// double b3 = y - count.arr[1] * x;
// double k3 = (y - count.arr[3]) / x;
// Console.WriteLine($"{count.arr[0]} = {k3:F1}; {F1} = {b3:F1}");
// Console.WriteLine($"{count.arr[0]} = {k3:F1}; {F1} = {b3:F1}");