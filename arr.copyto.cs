using System;
using System.Text;

namespace copytone
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
            arr.CopyTo (arr2, 0);
            foreach (string str in arr2)
            {
                Console.WriteLine (str);
            }
        }
    }
}
