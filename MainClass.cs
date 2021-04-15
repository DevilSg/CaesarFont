using System;

namespace CaesarFont
{
    class MainClass
    {
        static void Main(string[] args)
        {
            bool menu = true;
            int choose;

            try
            {
                while (menu)
                {
                    Console.WriteLine("1. Encrypt;\n2. Decrypt;\n0. Exit.");
                    choose = int.Parse(Console.ReadLine());
                    if (choose == 1)
                    {
                        Console.Write("Enter your message: ");
                        string message = Console.ReadLine();
                        Console.Write("Enter your key word: ");
                        string keyWord = Console.ReadLine();
                        Console.Write("Enter your key: ");
                        int key = int.Parse(Console.ReadLine());

                        Encrypt encrypt = new Encrypt(message, keyWord, key);
                    }
                    else if (choose == 2)
                    {
                        Console.Write("Enter your message: ");
                        string message = Console.ReadLine();
                        Console.Write("Enter your key word: ");
                        string keyWord = Console.ReadLine();
                        Console.Write("Enter your key: ");
                        int key = int.Parse(Console.ReadLine());

                        Decrypt decrypt = new Decrypt(message, keyWord, key);
                    }
                    else if (choose == 0)
                    {
                        menu = false;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
