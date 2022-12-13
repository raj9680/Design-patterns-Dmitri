//using System;

//namespace Liskov_Substitution_Principle // Good
//{
//    // For Rectangle
//    public class Rectangle
//    {
//        public int Width { get; set; }
//        public int Height { get; set; }

//        public Rectangle()
//        {

//        }

//        public Rectangle(int width, int height)
//        {
//            Width = width;
//            Height = height;
//        }

//        public override string ToString()
//        {
//            return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
//        }
//    }

//    // For Square
//    public class Square : Rectangle
//    {
//        public new int Width { set { base.Width = base.Height = value; } }
//        public new int Height { set { base.Width = base.Height = value; } }
//    }

//    // Mains
//    class Program
//    {
//        static public int Area(Rectangle r) => r.Height * r.Width;
//        static void Main(string[] args)
//        {
//            Rectangle rc = new Rectangle(2, 3);
//            Console.WriteLine($"{rc} has area of {Area(rc)}");

//            Rectangle sq = new Square();
//            sq.Height = 4;
//            Console.WriteLine($"{sq} has area of {Area(sq)}");
//        }
//    }
//}
