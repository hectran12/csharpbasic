using System;
using System.Text;
namespace truyxuat
{
    class Program
    {
        static void Main (string[] args)
        {
            string[] newchar = new string[3] { "Trần", "Trọng", "Hòa" };
            //for 
            for (int i = 0; i < newchar.Length; i++)
            {
                Console.WriteLine(newchar[i]);
            }
            //foreach 
            foreach (string a in newchar)
            {
                Console.WriteLine(a);
            }
        }
    }
}
