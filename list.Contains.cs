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
            bool check = list.Contains(1);
            if (check == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("Deo");
            }
        }
    }
}
