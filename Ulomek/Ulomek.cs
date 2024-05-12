using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulomek
{
    internal class Ulomek : IComparable<Ulomek>
    {
        public int stevec { get; set; }
        public int imenovalec { get; set; }

        public Ulomek(int stevec, int imenovalec)
        {
            if (imenovalec == 0)
                throw new ArgumentException("Imenovalec ne more biti nič.");

            this.stevec = stevec;
            this.imenovalec = imenovalec;
        }

        public override string ToString()
        {
            return stevec + "/" + imenovalec;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, null))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != this.GetType())
                return false;

            Ulomek other = (Ulomek)obj;
            return (stevec * other.imenovalec == imenovalec * other.stevec);
        }

        public static bool operator ==(Ulomek u1, Ulomek u2)
        {
            return u1.Equals(u2);
        }

        public static bool operator !=(Ulomek u1, Ulomek u2)
        {
            return !(u1 == u2);
        }

        public static Ulomek operator +(Ulomek u1, Ulomek u2)
        {
            int lcm = LCM(u1.imenovalec, u2.imenovalec);
            int stevec1 = u1.stevec * (lcm / u1.imenovalec);
            int stevec2 = u2.stevec * (lcm / u2.imenovalec);

            return new Ulomek(stevec1 + stevec2, lcm).Poenostavi();
        }

        public static Ulomek operator -(Ulomek u1, Ulomek u2)
        {
            int lcm = LCM(u1.imenovalec, u2.imenovalec);
            int stevec1 = u1.stevec * (lcm / u1.imenovalec);
            int stevec2 = u2.stevec * (lcm / u2.imenovalec);

            return new Ulomek(stevec1 - stevec2, lcm).Poenostavi();
        }

        public static Ulomek operator *(Ulomek u1, Ulomek u2)
        {
            return new Ulomek(u1.stevec * u2.stevec, u1.imenovalec * u2.imenovalec).Poenostavi();
        }

        public static Ulomek operator *(Ulomek u, int n)
        {
            return new Ulomek(u.stevec * n, u.imenovalec).Poenostavi();
        }

        public static Ulomek operator /(Ulomek u1, Ulomek u2)
        {
            if (u2.stevec == 0)
            {
                throw new DivideByZeroException("Deljenje z ulomkom, ki ima stevec enak 0.");
            }
            return new Ulomek(u1.stevec * u2.imenovalec, u1.imenovalec * u2.stevec).Poenostavi();
        }

        public override int GetHashCode()
        {
            return (imenovalec * stevec) + (imenovalec - stevec);
        }

        private static int LCM(int a, int b)
        {
            return (a / GCD(a, b)) * b;
        }


        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public int CompareTo(Ulomek other)
        {
            if (other == null) return 1;

            long thisNumerator = this.stevec * other.imenovalec;
            long otherNumerator = other.stevec * this.imenovalec;

            return thisNumerator.CompareTo(otherNumerator);
        }

        public Ulomek Poenostavi()
        {
            int gcd = GCD(Math.Abs(stevec), Math.Abs(imenovalec));
            stevec /= gcd;
            imenovalec /= gcd;

            return this;
        }
    }
}
