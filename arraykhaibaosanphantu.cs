using System;
using System.Text;

namespace arraykhaibaosan
{
    class Program
    {
        static void Main (string[] args)
        {
            int[] stt = new int[5] { 1, 2, 3, 4, 5 };
            foreach (int i in stt)
            {
                Console.WriteLine(i);
            }
            Random ran = new Random();
            int[] ranstt = new int[5] { ran.Next() % 10, ran.Next() % 10, ran.Next() % 10, ran.Next() % 10, ran.Next() % 10, };
            foreach (int a in ranstt)
            {
                Console.WriteLine (a);
            }
        }
    }
}
