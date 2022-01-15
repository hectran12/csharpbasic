using System;
using System.Text;

namespace test
{
    class Program
    {
        static void Main (string[] args)
        {
            List<int> list = new List<int>()
            {
                1, 2, 3
            };
            int stt = 0;
            Console.WriteLine("Normal:");
            foreach (int i in list)
            {
                stt++;
                Console.WriteLine("{0} => {1}",stt,i);
            }
            Console.WriteLine("Clear:");
            list.Clear();
            if (list.Count == 0)
            {
                Console.Write("Con cai nit@");
            } else
            {
                Console.Write("Co cai nit ne");
            }
        }
    }
}
