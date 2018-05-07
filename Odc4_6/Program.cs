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
            Console.Write ("Podaj swój wiek: ");
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
                    Console.WriteLine("Moze soczek cwelu");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Kurwa już podaje browarka");
                }

            }
            Console.ReadKey();
        }
            
      }
    }

