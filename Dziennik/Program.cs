using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziennik
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary D1 = new Diary();
           /*
            D1.dodawanie(5);
            D1.dodawanie(8.5f);
            D1.dodawanie(4.7f);

            float srednia = D1.srednia();
            float max = D1.maxocena();
            float min = D1.minocena();
            */

            for (; ; )
            {
                Console.WriteLine("Podaj ocene z zakresu 1-10: ");
             float ocena;
             bool result = float.TryParse(Console.ReadLine(),out ocena);

                if (ocena == 11)
                {
                    break;
                }
                
                if (result == true&&ocena <=10)
                {
                    D1.dodawanie(ocena);
                }
            }
            Console.WriteLine("Srednia ocena to: " + D1.srednia());
            Console.WriteLine("Max ocena to: " + D1.maxocena());
            Console.WriteLine("Min ocena to: " + D1.minocena());
            Console.ReadKey();
        }
    }

}
