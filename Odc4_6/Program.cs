using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odc4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Przywitanie();
                Wiek();
                Czyszczenie();
            }
        }
        private static void Czyszczenie()
        {
            Console.ResetColor();
            Console.WriteLine("Nacisnij przycisk by podać dalej: ");
            Console.ReadKey();
            Console.Clear();
        }
        private static void Wiek()
        {
            Console.Write("Podaj swój wiek: ");
            int age;

            bool result = int.TryParse(Console.ReadLine(), out age);
            if (result == false)
            {
                Console.WriteLine("Podaj wiek jeszcze raz: ");
            }

            else
            {
                if (age <= 18)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Moze soczek cwelu");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Kurwa już podaje browarka");
                }

            }
        }
        private static void Przywitanie()
        {
            Console.Write("Podaj swoje imię: ");
            string imie = Console.ReadLine();
            Console.WriteLine("Czesc " + imie);
        }
    }
}

