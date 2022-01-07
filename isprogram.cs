using System;
using System.Text;
namespace projectis
{
    class Program
    {
        /// <summary>
        /// Auth 
        /// </summary>
        static void AdCode()
        {
            string auth, des, lang;
            auth = "Trong Hoa";
            des = "Check in and out project";
            lang = "C# Basic";
            Console.WriteLine("Auth: " + auth);
            Console.WriteLine("Des: " + des);
            Console.WriteLine("Lang: " + lang);
        }
        /// <summary>
        /// Bar function
        /// </summary>
        /// <param name="amount">Amount</param>
        static void bar(int amount)
        {
            for (int i = 1; i <= amount; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Menu your choose
        /// </summary>
        static void Menu()
        {
            string menu;
            menu = "Enter [1] to check if the unique number is\n";
            menu += "Enter [2] to check if the unique number is v2\n";
            menu += "Enter [3] to check if the unique string is (ONLY 1 COUNT CHAR , EX: A)\n";
            menu += "Enter [4] to check if the unique lower is (ONLY 1 COUNT CHAR , EX: A)\n";
            menu += "Enter [5] to check if the unique upper is (ONLY 1 COUNT CHAR , EX: A)\n";
            menu += "Enter [6] to check if the unique whitespace is (ONLY 1 COUNT CHAR , EX: A)\n";
            Console.Write(menu);
        }
        /// <summary>
        /// check digit
        /// </summary>
        /// <returns>ans</returns>
        static string isDigit()
        {
            Console.Write("Input text: ");
            try
            {
                char number = Convert.ToChar(Console.ReadLine());
                bool Ketqua = Char.IsDigit(number);
                if (Ketqua == true)
                {
                    return number + " this is the number";
                }
                else
                {
                    return number + " this is not a number";
                }
            } catch
            {
                return "is not a number";
            }
            
        }
        /// <summary>
        /// check digit
        /// </summary>
        /// <returns>ans</returns>
        static string isnum()
        {
            Console.Write("Input text: ");
            try
            {
                char number = Convert.ToChar(Console.ReadLine());
                bool Ketqua = Char.IsNumber(number);
                if (Ketqua == true)
                {
                    return number + " this is the number";
                }
                else
                {
                    return number + " this is not a number";
                }
            }
            catch
            {
                return "is not a number";
            }

        }
        /// <summary>
        /// check string
        /// </summary>
        /// <returns>ans</returns>
        static string checkstring()
        {
            try
            {
                Console.Write("Input text: ");
                char input = Convert.ToChar(Console.ReadLine());
                bool ketqua = Char.IsLetter(input);
                if (ketqua == true)
                {
                    return input + " is string";
                } else
                {
                    return input + " is not string";
                }
            }catch
            {
                return "is not string";
            }
        }
        /// <summary>
        /// CHECK LOWER
        /// </summary>
        /// <returns>ans</returns>
        static string checklower()
        {
            try
            {
                Console.Write("Input text: ");
                char input = Convert.ToChar(Console.ReadLine());
                bool ketqua = char.IsLower(input);
                if (ketqua == true)
                {
                    return input + " is lower";
                }
                else
                {
                    return input + " is not lower";
                }
            }
            catch
            {
                return "is not lower";
            }
        }
        /// <summary>
        /// check upper
        /// </summary>
        /// <returns>ans</returns>
        static string checkupper()
        {
            try
            {
                Console.Write("Input text: ");
                char input = Convert.ToChar(Console.ReadLine());
                bool ketqua = char.IsUpper(input);
                if (ketqua == true)
                {
                    return input + " is upper";
                }
                else
                {
                    return input + " is not upper";
                }
            }
            catch
            {
                return "is not upper";
            }
        }
        /// <summary>
        /// check white space
        /// </summary>
        /// <returns>ans</returns>
        static string checkspace()
        {
            try
            {
                Console.Write("Input text: ");
                char input = Convert.ToChar(Console.ReadLine());
                bool ketqua = char.IsWhiteSpace(input);
                if (ketqua == true)
                {
                    return input + " is WhiteSpace";
                }
                else
                {
                    return input + " is not WhiteSpace";
                }
            }
            catch
            {
                return "is not WhiteSpace";
            }
        }

        static void run()
        {
            bar(30);
            AdCode(); // banner 
            bar(30);
            Menu(); // menu
            bar(30);
            Console.Write("Enter the number you want to make: ");
            int input;
            input = Convert.ToInt32(Console.ReadLine());
            bar(30);
            if (input == 1)
            {
                Console.WriteLine(isDigit()); // check digit
            }
            else if (input == 2)
            {
                Console.WriteLine(isnum()); // check digit
            }
            else if (input == 3)
            {
                Console.WriteLine(checkstring()); // check string
            }
            else if (input == 4)
            {
                Console.WriteLine(checklower()); // check lower
            }
            else if (input == 5)
            {
                Console.WriteLine(checkupper()); // check upper
            }
            else if (input == 6)
            {
                Console.WriteLine(checkspace()); // check white space
            }
            bar(30);
            // reload
            Console.Write("Enter để tiếp tục");
            Console.ReadLine();
            Console.Clear();
        }
        /// <summary>
        /// main
        /// </summary>
        /// <param name="args">ans</param>
        static void Main (string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // set ouput console -> utf 8
            while (true)
            {
                run(); // run
            }
  
        }

      
    }
}
