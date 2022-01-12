using System;
using System.Text;

namespace manghaichieu
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.Write("Nhap so dong: ");
            int dong = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            int cot = Convert.ToInt32(Console.ReadLine());
            int[,] mang = new int[dong, cot];
            Random r = new Random();
            for (int i = 0; i < dong; i++)
            {
                for(int j = 0; j < cot; j++)
                {
                    mang[i, j] = r.Next(100);
                }
            }
            for (int i = 0; i < mang.GetLength(0); i++)
            {
                for(int j = 0;j < mang.GetLength(1); j++)
                {
                    Console.Write(mang[i, j] + "\t");
                }
            }
        }
    }
}
