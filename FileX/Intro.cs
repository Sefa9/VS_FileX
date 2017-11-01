using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace FileX
{
    class Intro
    {
        public Intro()
        {
            IntroBaslat();
        }
        string[] isimB = { "B", "a", "Ş", "L","ı","Y","o","R" };
        protected void IntroBaslat()
        {
            

            for (int i = 0; i < 1; i++)
            {
                Console.Write(" \n\n\n\n\n                            ");
                for (int j = 0; j < 1; j++)
                {
                    foreach (var item in isimB)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Beep();
                        Console.Write(item);
                        Thread.Sleep(250);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Thread.Sleep(250);
                    }
                    Console.Clear();
                }
            }
            Thread.Sleep(1000);
            for (int i = 0; i < 5; i++)
            {
                Console.Beep();
                Thread.Sleep(15);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(File.ReadAllText(@"C:\Users\Sefa\Desktop\cekbeni.txt"));
            Console.ForegroundColor = ConsoleColor.DarkCyan;

        }
    }
}
