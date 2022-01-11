using System;
using System.Text;

namespace clone
{
    class Program
    {
        static void Main (string[] args)
        {
            string[] arr = new string[3]
            {
                "Tran",
                "Trong",
                "Hoa"
            };
            string[] arr2 = new string[arr.Length];
            arr2 = (string[])arr.Clone();
            foreach (string s in arr2)
            {
                Console.WriteLine(s);
            }
        }
    }
}
