using System;
class main
{
    static int mindiff(int[] arr)
    {
        int s = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            s += Math.Abs(arr[i] - arr[i + 1]);
        }
        return s;
    }
    static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = Int32.Parse(Console.ReadLine());
        }
        Array.Sort(a);
        int res = mindiff(a);
        Console.WriteLine(res);
    }
}