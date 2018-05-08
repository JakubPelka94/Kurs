using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziennik
{
    class Diary
    {
        // Stan (zmienne-pola)

        List <float> oceny= new List<float>() ;

        // Zachowania
        public void dodawanie (float ocena)
        {
            oceny.Add(ocena);            
        }
            
        public float srednia()
        {
            float suma=0 , sre=0;
            foreach (var ocena in  oceny)
            {
                suma += ocena;
            }
            sre = suma / oceny.Count();

            return sre;
        }

        public float maxocena()
        {
            return oceny.Max();
        }

        public float minocena()
        {
            return oceny.Min();
        }


    }
}
