using System;
using System.Collections.Generic;
using System.Text;

namespace listrange
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhap ki tu: ");
            string kitu = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap ki tu ngan cach: ");
            string kitusplit = Convert.ToString(Console.ReadLine());
            string[] vs = kitu.Split(Convert.ToChar(kitusplit));
            List<string> test = new List<string> (vs);
            Console.Write("Mang ban dau:\n");
            int i = 0;
            foreach (string v in test)
            {
                i++;
                Console.Write("{0} => {1}\n",i,v);
            }
            Console.WriteLine("AddRange(test)");
            test.AddRange(test);
            i = 0;
            foreach (string v in test)
            {
                i++;
                Console.Write("{0} => {1}\n", i, v);
            }
            Console.WriteLine("RemoveRange(2,2)");
            test.RemoveRange(2, 2);
            i = 0;
            foreach (string v in test)
            {
                i++;
                Console.Write("{0} => {1}\n", i, v);
            }
            Console.WriteLine("InsertRange(3,vs)");
            test.InsertRange(3, vs);
            i = 0;
            foreach (string v in test)
            {
                i++;
                Console.Write("{0} => {1}\n", i, v);
            }
            Console.WriteLine("GetRange(2, 3).ToArray()");
            string[] ad = test.GetRange(2, 3).ToArray();
            i = 0;
            foreach (string v in test)
            {
                i++;
                Console.Write("{0} => {1}\n", i, v);
            }
        }
    }
}
