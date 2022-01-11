using System;

namespace daongoucmang
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mang = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            Console.Write("Normal:\n");
            foreach (int i in mang)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Reverse:");
            Array.Reverse(mang);
            foreach (int i in mang)
            {
                Console.WriteLine(i);
            }
        }
    }
}
