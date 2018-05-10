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
       
            D1.dodawanie(5);
            D1.dodawanie(8.5f);
            D1.dodawanie(4.7f);

           DiaryStat stats=D1.ComputeStat();

            Console.WriteLine("Srednia ocen to: "+stats.avg);
            Console.WriteLine("Max ocena to: " + stats.maxoc);
            Console.WriteLine("Min ocena to: " + stats.minoc);
            


            Diary D2 = new Diary();

            D2.dodawanie(2);
            D2.dodawanie(1.5f);
            D2.dodawanie(4.75f);

            stats = D2.ComputeStat();

            Console.WriteLine("Srednia ocen to: " + stats.avg);
            Console.WriteLine("Max ocena to: " + stats.maxoc);
            Console.WriteLine("Min ocena to: " + stats.minoc);

            Console.ReadKey();
        }
    }

}
