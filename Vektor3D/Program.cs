using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektor3D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vektor3D v1 = new Vektor3D(1, 2, 3);
            Vektor3D v2 = new Vektor3D(4, 5, 6);
            Vektor3D v3 = new Vektor3D(1, 1, 1);

            // Test vsota
            Vektor3D vsota = v1 + v2;
            Console.WriteLine($"Vsota {v1} in {v2} je {vsota}");

            // Test množenje s skalarjem
            Vektor3D produkt = v1 * 2;
            Console.WriteLine($"{v1} pomnožen z 2 je {produkt}");

            // Test velikost vektorja
            Console.WriteLine($"Velikost vektorja {v1} je {v1.Velikost()}");

            // Test Array.Sort
            Vektor3D[] vektorji = { v1, v2, v3 };
            Array.Sort(vektorji);
            Console.WriteLine("Sortirani vektorjev po velikosti:");
            foreach (var v in vektorji)
            {
                Console.WriteLine(v);
            }
        }
    }
}
