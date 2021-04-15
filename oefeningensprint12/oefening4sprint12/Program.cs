using System;

namespace oefening4sprint12
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Hallo ik ben emiel en ik ben 17 jaar";
            char[] spaces = { ' ' };
            string[] words = sentence.Split(spaces);
            int count = 0;
            foreach (string word in words)
            {
                count++;
                Console.WriteLine(count);
            }

        }
    }
}
