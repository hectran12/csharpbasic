using System;
using System.Text;
namespace copymang
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
            Array.Copy(arr, arr2 , arr.Length);
            foreach (string s in arr2)
            {
                Console.WriteLine(s);
            }
        }
    }
}
