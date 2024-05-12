using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kocka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kocka k1 = new Kocka(3);
            Kocka k2 = new Kocka(4);
            Kocka k3 = new Kocka(2);

            // Test Prostornina
            Console.WriteLine($"Prostornina kocke k1 z dolžino stranice {k1.DolzinaStranice} je {k1.Prostornina()}");

            // Test Povrsina
            Console.WriteLine($"Površina kocke k1 je {k1.Povrsina()}");

            // Test Vsota dveh kock
            Kocka sumKocka = k1 + k2;
            Console.WriteLine($"Vsota dolžin stranic k1 in k2 je kocka s stranico {sumKocka.DolzinaStranice}");

            // Test množenje s skalarjem
            Kocka scaledKocka = k1 * 1.5;
            Console.WriteLine($"{k1} skalirana z 1.5 ima dolžino stranice {scaledKocka.DolzinaStranice}");

            // Test Array.Sort
            Kocka[] cubes = { k1, k2, k3 };
            Array.Sort(cubes);
            Console.WriteLine("Sortirane kocke:");
            foreach (var k in cubes)
            {
                Console.WriteLine(k);
            }
        }
    }
}
