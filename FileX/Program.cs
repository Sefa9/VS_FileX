using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace FileX
{
    class Program:Intro
    {
        
        static void Main(string[] args)
        {
            Console.SetWindowPosition(0, 0);
            new Intro();

            Console.ForegroundColor = ConsoleColor.Green;
            int durum = -2;
            do
            {
                Console.Write("Dosya Yazmak İçin 1, Dosya Silmek İçin 2'yi seçin: ");
                durum = int.Parse(Console.ReadLine());
                if (durum==1)
                {
                    Console.Write("Dosya yolu girin: ");
                    string yol = Console.ReadLine();
                    yol = String.Format(@"{0}", yol);
                    Console.Write("Kaç adet oluşturulsun? : ");
                    int adet = int.Parse(Console.ReadLine());
                    Console.Write("Dosya'da ne yazsın? : ");
                    string yazilacak = Console.ReadLine();
                    for (int i = 0; i < adet; i++)
                    {
                            File.WriteAllText(yol + "\\Dosya" + i + ".txt", yazilacak);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("                                  {0}. dosya {1} adıyla oluşturuldu.", i, "Dosya" + i);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("                                  ---------------------###----------------------");
                        Thread.Sleep(10);
                    }
                }
                else if (durum==2)
                {
                    Console.Write("Dosya yolu girin: ");
                    string yol = Console.ReadLine();
                    yol = String.Format(@"{0}", yol);
                    Console.Write("Kaç adet kaldırılsın? : ");
                    int adet = int.Parse(Console.ReadLine());
                    for (int i = 0; i < adet; i++)
                    {
                        File.Delete(yol + "\\Dosya" + i + ".txt");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("                                  {0}. dosya {1} adıyla kaldırıldı.", yol + "/" + "/Dosya" + i, "Dosya" + i);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("                                  ---------------------###----------------------");
                    }
                }
            } while (durum != -1);


           
            /**/


        }
    }
}
