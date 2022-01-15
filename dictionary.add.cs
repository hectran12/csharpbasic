using System;
using System.Text;

namespace test
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập kí tự: ");
            string kitu = Convert.ToString(Console.ReadLine());
            Console.Write("Nhập kí tự cần tách: ");
            char tach = Convert.ToChar(Console.ReadLine());
            string[] mang = kitu.Split(tach);
            Dictionary<string,string> map = new Dictionary<string,string>();
            int a = 0;
            foreach (string s in mang)
            {
                a++;
                Console.Write("{0} => Nhập key cho {1}: ", a,s);
                string key = Convert.ToString (Console.ReadLine());
                map.Add(key, s);
            }
            Console.WriteLine("Kết quả là: ");
            foreach (KeyValuePair<string,string> acc in map)
            {
                Console.WriteLine("Key {0} => Value {1}",acc.Key, acc.Value);
            }
        }
    }
}
