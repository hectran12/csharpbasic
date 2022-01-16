using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.Write("Nhap gia tri muon dua vao dictionary: ");
            string giatri = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap ki tu ngan cach o moi gia tri: ");
            char ngancach = Convert.ToChar(Console.ReadLine());
            string[] mang = giatri.Split(ngancach);
            Dictionary<int,string> map = new Dictionary<int,string>();
            int a = 0;
            foreach (string i in mang)
            {
                a++;
                while (true)
                {
                    Console.Write("{0} => Nhap key cho gia tri {1}: ", a, i);
                    int key = Convert.ToInt32(Console.ReadLine());
                    bool check = map.ContainsKey(key);
                    if (check == true)
                    {
                        Console.WriteLine("Key da ton tai!");
                    } else
                    {
                        map.Add(key, i);
                        break;
                    }
            
                }

            }
            map.Clear();
            if (map .Count == 0)
            {
                Console.Write("CO cai nnitj");
            } else
            {
                Console.Write(" cos 1 do");
            }
        }
    }
}
