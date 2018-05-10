using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziennik
{
    class Diary
    {

        public Diary()
        {
            oceny = new List<float>();
        }
        // Stan (zmienne-pola)

        List<float> oceny;

        // Zachowania
        public void dodawanie (float ocena)
        {
            oceny.Add(ocena);            
        }

        internal DiaryStat ComputeStat()
        {
            DiaryStat stats = new DiaryStat();

            float suma = 0f;

                foreach (var ocena in oceny)
                {
                    suma += ocena;
                }

            stats.avg = suma / oceny.Count();
            stats.maxoc= oceny.Max(); 
            stats.minoc=oceny.Min(); 
      
            return stats;
        }

    }

}
