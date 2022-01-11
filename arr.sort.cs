using System;

namespace sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mang = { 1, 4, 3, 2, 7, 6, 5, 8, 9, 10, 11, 12 };
            Console.Write("Normal:\n");
            foreach (int i in mang)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Sort:");
            Array.Sort(mang);
            foreach (int i in mang)
            {
                Console.WriteLine(i);
            }
        }
    }
}
