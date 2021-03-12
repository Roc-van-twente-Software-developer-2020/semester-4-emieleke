using System;

namespace opdracht2
{
    using System;

    namespace opdracht2
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("write amount of prime numbers shown: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int j;
                bool p = false;
                for (int i = 2; i <= n; i++)
                {
                    for (j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            p = true;
                        }
                    }
                    if (!p)
                    {
                        Console.WriteLine(j);
                    }
                    else
                    {
                        p = false;
                    }
                }
            }
        }
    }
}
