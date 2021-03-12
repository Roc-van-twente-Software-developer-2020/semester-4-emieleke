using System;

namespace opdracht4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[10];
            int[] array2 = new int[10];
            int[] array3 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(10, 99);
                array2[i] = random.Next(10, 99);
                array3[i] = array[i] + array2[i];
            }
            Console.WriteLine(string.Join(", ", array));
            Console.WriteLine(string.Join(", ", array2));
            Console.WriteLine(string.Join(", ", array3));
        }
    }
}
