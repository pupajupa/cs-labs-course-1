using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class SquareEquation
    {
        private int a;
        private int b;
        private int c;
        private bool hasRoots;
        public int A
        {
            get { return a; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Значение a не может равняться 0");
                }
                a = value;
            }
        }
        public int B { get { return b; } set { b = value; } }
        public int C { get { return c; } set { c = value; } }
        public SquareEquation(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            hasRoots = true;
        }
        public bool HasRoots { get { return hasRoots; } private set { hasRoots = value; } }
        public void Solution(out double x1, out double x2)
        {
            double discriminant = b * b - 4.0 * a * c;
            if (discriminant < 0)
            {
                hasRoots = false;
                x1 = x2 = double.NaN;
            }
            else if (discriminant == 0)
            {
                x1 = x2 = -b + Math.Sqrt(discriminant) / (2.0 * A);
            }
            else
            {
                x1 = -b + Math.Sqrt(discriminant) / (2.0 * a);
                x2 = -b - Math.Sqrt(discriminant) / (2.0 * a);
            }
        }
        public static SquareEquation operator +(SquareEquation eq, int value)
        {
            return new SquareEquation(eq.A + value, eq.B + value, eq.C + value);
        }
        public static SquareEquation operator -(SquareEquation eq, int value)
        {
            return new SquareEquation(eq.A - value, eq.B - value, eq.C - value);
        }
        public static SquareEquation operator ++(SquareEquation eq)
        {
            return new SquareEquation(eq.A + 1, eq.B + 1, eq.C + 1);
        }
        public static SquareEquation operator --(SquareEquation eq)
        {
            return new SquareEquation(eq.A - 1, eq.B - 1, eq.C - 1);
        }
        public static SquareEquation operator *(SquareEquation eq, int value)
        {
            return new SquareEquation(eq.A * value, eq.B * value, eq.C * value);
        }
        public static SquareEquation operator /(SquareEquation eq, int value)
        {
            if (value == 0)
            {
                throw new ArgumentException("Деление на 0 невозможно");
            }
            return new SquareEquation(eq.A / value, eq.B / value, eq.C / value);
        }
        public static bool operator ==(SquareEquation eq1, SquareEquation eq2)
        {
            if (eq1 is null)
            {
                return eq2 is null;
            }

            return eq1.Equals(eq2);
        }

        public static bool operator !=(SquareEquation eq1, SquareEquation eq2)
        {
            return !(eq1 == eq2);
        }

        public static explicit operator int(SquareEquation eq)
        {
            return eq.a;
        }

        public static explicit operator SquareEquation(int a)
        {
            return new SquareEquation(a, 0, 0);
        }
        public override string ToString()
        {
            return $"{a}x^2 + {b}x + {c}";
        }
        public double this[int index]
        {
            get => index switch //switch expression
            {
                0 => a,
                1=> b,
                2=>c,
                _=> throw new IndexOutOfRangeException()
            };
            set
            {
                switch (index)
                {
                    case 0: 
                        A = (int)value; break;
                    case 1: 
                        B = (int)value; break;
                    case 2: 
                        C = (int)value; break;
                    default: 
                        throw new IndexOutOfRangeException();
                }
            }
        }
    }
}