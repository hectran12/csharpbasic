using System;
using System.Text;
using System.Collections.Generic;

namespace list
{
    class Program
    {
        static void Main (string[] args)
        {
            hoclist();
        }
        static void hoclist ()
        {
            List<string> ds = new List<string>();
            ds.Add("Trần");
            ds.Add("Trọng");
            ds.Add("Hòa");
            for (int i = 0; i < ds.Count; i++)
            {
                string s = ds[i];
                Console.WriteLine(s);
            }
        }
    }
}
