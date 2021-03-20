using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mince(37, 200));
            Console.WriteLine();
            Console.WriteLine(Mince2(37, 200));
            Console.ReadKey();
        }
        /*
        public static string Mince(int cena, int platba)
        {
            int vracenaCastka = platba - cena;
            if (platba > cena)
            {
                while (vracenaCastka > 0)
                {
                    if (vracenaCastka >= 50)
                    {
                        Console.WriteLine("50");
                        Mince(cena, platba - 50);
                    }
                    else if (vracenaCastka >= 20)
                    {
                        Console.WriteLine("20");
                        Mince(cena, platba - 20);
                    }
                    else if (vracenaCastka >= 10)
                    {
                        Console.WriteLine("10");
                        Mince(cena, platba - 10);
                    }
                    else if (vracenaCastka >= 5)
                    {
                        Console.WriteLine("5");
                        Mince(cena, platba - 5);
                    }
                    else if (vracenaCastka >= 2)
                    {
                        Console.WriteLine("2");
                        Mince(cena, platba - 2);
                    }
                    else if (vracenaCastka >= 1)
                    {
                        Console.WriteLine("1");
                        Mince(cena, platba - 1);
                    }
                    break;
                }
            }
            else if (platba < cena)
            {
                return "-1";
            }
            else if (platba == cena)
            {
                return "0";
            }
            return "0";
        }
        */
        public static string Mince(int cena, int platba)
        {
            int[] mince = { 50, 20, 10, 5, 2, 1 };
            int index = 0;
            int vracenaCastka = platba - cena;
            while (vracenaCastka > 0)
            {
                if (vracenaCastka >= mince[index])
                {
                    Console.WriteLine("Vrátit: {0}", mince[index]);
                    Mince(cena, platba - mince[index]);
                    break;
                }
                if (vracenaCastka < mince[index])
                {
                    index++;
                }
            }
            return "Mince vráceny";
        }
        public static int Mince2(int cena, int platba)
        {
            int[] mince = { 50, 20, 10, 5, 2, 1 };
            int index = 0;
            int vracenaCastka = platba - cena;
            while (vracenaCastka > 0)
            {
                if (vracenaCastka >= mince[index])
                {
                    Console.WriteLine("Vrátit: {0}", mince[index]);
                    Mince2(cena, platba - mince[index]);
                    break;
                }
                if (vracenaCastka < mince[index])
                {
                    index++;
                }
            }
            return 0;
        }
    }
}
