using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektor3D
{
    internal class Vektor3D : IComparable<Vektor3D>
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vektor3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vektor3D operator +(Vektor3D a, Vektor3D b) => new Vektor3D(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        public static Vektor3D operator -(Vektor3D a, Vektor3D b) => new Vektor3D(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        public static Vektor3D operator *(Vektor3D a, double b) => new Vektor3D(a.X * b, a.Y * b, a.Z * b);
        public static Vektor3D operator /(Vektor3D a, double b) => new Vektor3D(a.X / b, a.Y / b, a.Z / b);

        public double Velikost() => Math.Sqrt(X * X + Y * Y + Z * Z);

        public int CompareTo(Vektor3D other)
        {
            if (other == null) return 1;
            return this.Velikost().CompareTo(other.Velikost());
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Vektor3D)) return false;
            Vektor3D other = (Vektor3D)obj;
            return X == other.X && Y == other.Y && Z == other.Z;
        }

        public override int GetHashCode() => (X, Y, Z).GetHashCode();

        public override string ToString() => $"({X}, {Y}, {Z})";
    }
}
