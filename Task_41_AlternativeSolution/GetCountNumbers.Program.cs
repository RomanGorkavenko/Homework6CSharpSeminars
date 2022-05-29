partial class Program
{
    static int GetCountNumbers(int[] num)
    {
        int length = num.Length;
        int count = 0;
        for (int i = 0; i < length; i++)
        {
            if (num[i] > 0) count++;
        }
        return count;
    }
}