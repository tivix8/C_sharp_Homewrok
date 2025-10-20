using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT7 {
    internal class Program {
        static void Main(string[] args)
        {
            //1
            Point p = new Point(2, 5);
            Point p1 = new Point(6, 3);
            Console.WriteLine($"Точка1: {p}");
            Console.WriteLine($"Точка2: {p1}");
            Console.WriteLine($"Расстояние: {Math.Sqrt(Math.Pow(p1.X - p.X, 2) + Math.Pow(p1.Y - p.Y, 2))}");
            //2
            Rectangle rectangle = new Rectangle(5, 8);
            rectangle.RectangleInfo();

            //3
            Book book = new Book("Название", "Автор", 2025);
            book.BookInfo();

            //4
            ComplexNumber num1 = new ComplexNumber(5, 2);
            ComplexNumber num2 = new ComplexNumber(2, 3);

            ComplexNumber sum = num1.Add(num2);
            ComplexNumber difference = num1.Subtract(num2);
            ComplexNumber product = num1.Multiply(num2);

            Console.WriteLine($"Сложение: {num1} + {num2} = {sum}");
            Console.WriteLine($"Вычитание: {num1} - {num2} = {difference}");
            Console.WriteLine($"Умножение: {num1} * {num2} = {product}");

            //5
            Color red = new Color(255, 0, 0);
            Console.WriteLine($"Красный цвет: {red} -> {red.ToHex()}");

            Color custom = new Color(128, 200, 50);
            Console.WriteLine($"Смешанный цвет: {custom} -> {custom.ToHex()}");

            //6

            SimpleDate date1 = new SimpleDate(13, 4, 2025);
            SimpleDate date2 = new SimpleDate(15, 2, 1996);

            Console.WriteLine($"{date1} - високосный: {date1.IsLeapYear()}");
            Console.WriteLine($"{date2} - високосный: {date2.IsLeapYear()}");

            //7
            Vector2D vector = new Vector2D(6, 4);
            Vector2D vector2 = new Vector2D(3, 2);

            Console.WriteLine($"длина вектора 1: {vector.Length()}");
            Console.WriteLine($"нормализованный вектор 1: {vector.Normalize()}");
            Console.WriteLine($"скалярное произведение: {vector.Dot(vector2)}");

            //8
            Money money1 = new Money(23, 73);
            Money money2 = new Money(12, 130);



            Console.WriteLine($"сумма: {money1.Add(money2)}");
            Console.WriteLine($"разница: {money1.Subtract(money2)}");
            money1.Greater(money2);

            //9
            var A = new Point(0, 0);
            var B = new Point(3, 0);
            var C = new Point(0, 4);

            var tri = new Triangle(A, B, C);

            var (ab, bc, ca) = tri.SideLengths();
            Console.WriteLine($"AB = {ab:F2}, BC = {bc:F2}, CA = {ca:F2}");
            Console.WriteLine($"Perimeter = {tri.Perimeter():F4}");
            Console.WriteLine($"Area = {tri.Area():F2}");

            //10
            Point3D pd1 = new Point3D(2, 5, 3);
            Point3D pd2 = new Point3D(2, 7, 7);
            Console.WriteLine($"Расстояние между точками: {pd1.DistanceTo(pd2)}");


        }
    }
    public struct Point {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    public struct Rectangle {
        public int Width;
        public int Height;

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void RectangleInfo()
        {
            Console.WriteLine($"Периметр: {2 * (Width + Height)}");
            Console.WriteLine($"Площадь: {Width * Height}");


        }
    }

    public struct Book {
        public string Title;
        public string Author;
        public int Year;

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }



        public void BookInfo()
        {
            Console.WriteLine($"{Title} - {Author} ({Year})");
        }
    }
    public struct ComplexNumber {
        public double Real;
        public double Imag;
        public ComplexNumber(double real, double imag)
        {
            Real = real;
            Imag = imag;
        }
        public ComplexNumber Add(ComplexNumber other)
        {

            double newReal = Real + other.Real;
            double newImag = Imag + other.Imag;
            return new ComplexNumber(newReal, newImag);
        }


        public ComplexNumber Subtract(ComplexNumber other)
        {

            double newReal = Real - other.Real;
            double newImag = Imag - other.Imag;
            return new ComplexNumber(newReal, newImag);
        }

        public ComplexNumber Multiply(ComplexNumber other)
        {

            double newReal = Real * other.Real - Imag * other.Imag;
            double newImag = Real * other.Imag + Imag * other.Real;
            return new ComplexNumber(newReal, newImag);
        }

        public override string ToString()
        {
            if (Imag >= 0)
                return $"{Real} + {Imag}i";
            else
                return $"{Real} - {Math.Abs(Imag)}i";
        }

    }

    public struct Color {
        public byte R;
        public byte G;
        public byte B;

        public Color(byte r, byte g, byte b)
        {
            R = r; G = g; B = b;
        }
        public string ToHex() => $"#{R:X2}{G:X2}{B:X2}";

        public override string ToString() => $"RGB({R}, {G}, {B})";

    }

    public struct SimpleDate {
        public int Day;
        public int Month;
        public int Year;

        public SimpleDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public bool IsLeapYear()
        {

            if (Year % 400 == 0)
                return true;
            if (Year % 100 == 0)
                return false;
            if (Year % 4 == 0)
                return true;
            return false;
        }

        public override string ToString()
        {
            return $"{Day:00}.{Month:00}.{Year}";
        }
    }

    public struct Vector2D {
        public double X;
        public double Y;

        public Vector2D(double x, double y) { X = x; Y = y; }

        public double Length()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        public Vector2D Normalize()
        {
            double length = Length();


            if (length == 0)
                return new Vector2D(0, 0);


            return new Vector2D(X / length, Y / length);
        }
        public double Dot(Vector2D other)
        {

            return X * other.X + Y * other.Y;
        }


        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    public struct Money {
        public int Rubles;
        public int Kopecks;

        public Money(int rubles, int kopecks)
        {
            Rubles = rubles;
            Kopecks = kopecks;
            Normalize();
        }

        private void Normalize()
        {
            if (Kopecks >= 100)
            {

                Rubles += Kopecks / 100;
                Kopecks = Kopecks % 100;
            }

            if (Kopecks < 0 && Rubles > 0)
            {
                Rubles -= 1;
                Kopecks += 100;
            }
        }

        public Money Add(Money other)
        {
            int totalRubles = Rubles + other.Rubles;
            int totalKopecks = Kopecks + other.Kopecks;
            return new Money(totalRubles, totalKopecks);
        }

        public Money Subtract(Money other)
        {
            int totalRubles = Rubles - other.Rubles;
            int totalKopecks = Kopecks - other.Kopecks;
            return new Money(totalRubles, totalKopecks);
        }
        public void Greater(Money other)
        {
            int thisTotal = Rubles * 100 + Kopecks;
            int otherTotal = other.Rubles * 100 + other.Kopecks;

            if (thisTotal > otherTotal)
            {
                Console.WriteLine($"{this} > {other}");
            }
            else if (thisTotal < otherTotal)
            {
                Console.WriteLine($"{other} > {this}");
            }
            else
            {
                Console.WriteLine($"{this} = {other}");
            }
        }



        public override string ToString()
        {
            return $"{Rubles} руб. {Kopecks:00} коп.";
        }
    }

    public struct Triangle {
        public Point A { get; }
        public Point B { get; }
        public Point C { get; }

        public Triangle(Point a, Point b, Point c)
        {
            A = a; B = b; C = c;
        }
        public static double Distance(Point p1, Point p2)
        {
            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }


        public (double AB, double BC, double CA) SideLengths()
        {
            double ab = Distance(A, B);
            double bc = Distance(B, C);
            double ca = Distance(C, A);
            return (ab, bc, ca);
        }


        public double Perimeter()
        {
            var (ab, bc, ca) = SideLengths();
            return ab + bc + ca;
        }


        public double Area()
        {
            var (a, b, c) = SideLengths();
            double p = (a + b + c) / 2.0;

            double insideSqrt = p * (p - a) * (p - b) * (p - c);
            if (insideSqrt <= 0) return 0.0;

            return Math.Sqrt(insideSqrt);
        }
    }

    public struct Point3D {
        public double X;
        public double Y;
        public double Z;

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public double DistanceTo(Point3D other)
        {
            return Math.Sqrt(
                Math.Pow(X - other.X, 2) +
                Math.Pow(Y - other.Y, 2) +
                Math.Pow(Z - other.Z, 2)
            );
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }
}






