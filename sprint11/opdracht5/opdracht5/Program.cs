using System;

namespace opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 6, 2, 5, 4, 1 };
            int t;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        t = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = t;
                    }
                }
            }
        }
    }
}
