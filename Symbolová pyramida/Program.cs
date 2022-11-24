using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symbolová_pyramida_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte max. 10 řádků");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte symbol");
            string symbol = Console.ReadLine();
            int pocet = 1;

            if (num <= 1 || num > 10 || symbol == string.Empty || symbol == " " || symbol.Length > 1)
            {
                Console.WriteLine("Chyba zadání\nProgram ukončete stisknutím klávesy Enter");
                Console.ReadLine();
            }
            else
            {
                num = num * 2;
                for (int radky = num; radky >= 1; radky--)
                {
                    for (int mezery = radky - 1; mezery >= 1; mezery--)
                    {
                        Console.Write(" ");
                    }
                    for (int Sym = 1; Sym <= pocet; Sym++)
                    {
                        if (pocet % 2 != 0)
                        {
                            Console.Write("{0}", symbol);
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    pocet++;
                    Console.WriteLine();
                }
                Console.WriteLine("\nProgram ukončete stisknutím klávesy Enter");
                Console.ReadLine();
            }
        }
    }
}