using System;
using System.Text;

namespace array
{
    class Program
    {
        static void Main (string[] args)
        {
            string[] mang_string = new string[5];
            Console.WriteLine(mang_string.Length); // mang kieu string
            int[] mang_int = new int[5];
            Console.WriteLine(mang_int.Length); // mang kieu int 
            char[] mang_char = new char[5];
            Console.WriteLine(mang_char.Length); // mang kieu char
            bool[] mang_bool = new bool[5];
            Console.WriteLine(mang_bool.Length); // mang kieu bool
            float[] mang_float = new float[5];
            Console.WriteLine (mang_float.Length); // mang kieu float
        }
    }
}
