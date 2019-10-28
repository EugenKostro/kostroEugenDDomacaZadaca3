using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kostroEugenDomacaZadaca3
{
    class Program
    {
        static void Main(string[] args)
        {


            float ocjene, prosjekOcjena = 0, brojac = 0;
            Console.WriteLine("Upisi ocjene: ");
        nazad:
            ocjene = Convert.ToInt32(Console.ReadLine());

            do
            {

                if (ocjene == 1)
                {
                    Console.WriteLine("Prosjek ocjena je 1!! ");
                    goto dalje;
                }
                if (ocjene < 1 || ocjene > 5)
                {
                    Console.WriteLine("Ocjena ne postoji: Upisi ponovno!");
                    goto nazad;
                }
                prosjekOcjena = prosjekOcjena + ocjene;
                brojac++;
                ocjene = Convert.ToInt32(Console.ReadLine());
            }

            prosjekOcjena = prosjekOcjena / brojac;
            Console.WriteLine("Ovo je vas prosjek:  " + prosjek);

            dalje:

            Console.ReadKey();

        }
    }
}
