using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulomek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ulomek u1 = new Ulomek(1, 2);
            Ulomek u2 = new Ulomek(3, 4);
            Ulomek u3 = new Ulomek(1, 3);
            Ulomek u4 = new Ulomek(1, 2);

            Ulomek vsota = u1 + u2;
            Console.WriteLine(vsota);

            Ulomek razlika = u3 - u2;
            Console.WriteLine(razlika);

            Ulomek produkt = u2 * u1;
            Console.WriteLine(produkt);

            Ulomek deljenje = u1 / u2;
            Console.WriteLine(deljenje);

            Console.WriteLine("Preverjamje Array.Sort");
            Ulomek[] ulomki = {
            new Ulomek(1, 3),
            new Ulomek(3, 4),
            new Ulomek(1, 2)
            };

            Array.Sort(ulomki);

            foreach (var ulomek in ulomki)
            {
                Console.WriteLine(ulomek);
            }
        }
    }
}
