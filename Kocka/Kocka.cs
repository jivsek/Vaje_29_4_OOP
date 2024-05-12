using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kocka
{
    internal class Kocka : IComparable<Kocka>
    {
        public double DolzinaStranice { get; private set; }

        public Kocka(double dolzinaStranice)
        {
            if (dolzinaStranice <= 0)
                throw new ArgumentException("Dolžina stranice mora biti večja od 0.");
            DolzinaStranice = dolzinaStranice;
        }

        public double Prostornina() => Math.Pow(DolzinaStranice, 3);
        public double Povrsina() => 6 * Math.Pow(DolzinaStranice, 2);

        public static Kocka operator +(Kocka a, Kocka b) => new Kocka(a.DolzinaStranice + b.DolzinaStranice);
        public static Kocka operator *(Kocka a, double b) => new Kocka(a.DolzinaStranice * b);

        public int CompareTo(Kocka other)
        {
            if (other == null) return 1;
            return this.Prostornina().CompareTo(other.Prostornina());
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Kocka)) return false;
            Kocka other = (Kocka)obj;
            return DolzinaStranice == other.DolzinaStranice;
        }

        public override int GetHashCode() => DolzinaStranice.GetHashCode();

        public override string ToString() => $"Kocka z dolžino stranice {DolzinaStranice}";
    }
}
