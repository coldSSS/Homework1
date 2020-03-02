using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork3_2
{
    abstract class Shape
    {
        abstract public bool IsLegal();
        abstract public double Area { get; }
    }

    class Rectangle : Shape
    {
        private double width;
        private double height;
        public Rectangle(double width, double length)
        {
            this.width = width;
            this.height = length;
        }
        public override double Area
        {
            get
            {
                if (!IsLegal())
                {
                    return -1;
                }
                return width * height;
            }
        }
        public override bool IsLegal()
        {
            return width > 0 && height > 0;
        }


    }

    class Square : Shape
    {
        private double side;
        public Square(double side)
        {
            this.side = side;
        }
        public override double Area
        {
            get
            {
                if (!IsLegal())
                {
                    return -1;
                }
                return side * side;
            }
        }
        public override bool IsLegal()
        {
            return side > 0;
        }


    }
    class Triangle : Shape
    {
        private double aSide, bSide, cSide;
        public Triangle(double ASide, double BSide, double CSide)
        {
            this.aSide = ASide;
            this.bSide = BSide;
            this.cSide = CSide;
        }
        public override double Area
        {
            get
            {
                if (!IsLegal())
                {
                    return -1;
                }
                double l = (aSide + bSide + cSide) / 2;
                return Math.Sqrt(l * (l - aSide) * (l - bSide) * (l - cSide));
            }
        }
        public override bool IsLegal()
        {
            return aSide > 0 && bSide > 0 && cSide > 0 &&
                aSide + bSide > cSide &&
                aSide + cSide > bSide &&
                bSide + cSide > aSide;
        }
    }

    class ShapeFactory
    {
        public Triangle CreateTriangle(double ASide, double BSide, double CSide)
        {
            Triangle production = new Triangle(ASide, BSide, CSide);
            if (!production.IsLegal()) 
            {
                return null;
            }
            return production;
        }
        public Rectangle CreateRectangle(double width, double height) 
        {
            Rectangle production = new Rectangle(width, height);
            if (!production.IsLegal())
            {
                return null;
            }
            return production;
        }

        public Square CreateSquare(double side) 
        {
            Square production = new Square(side);
            if (!production.IsLegal())
            {
                return null;
            }
            return production;
        }

        public Shape CreateRandomShape() 
        {
            Shape production = null;
            while (production == null)
            {
                switch (GetRandomNumber(1, 4))
                {
                    case 1:
                        production = CreateTriangle(GetRandomNumber(1, 100), GetRandomNumber(1, 100), GetRandomNumber(1, 100));
                        break;
                    case 2:
                        production = CreateRectangle(GetRandomNumber(1, 100), GetRandomNumber(1, 100));
                        break;
                    default:
                        production = CreateSquare(GetRandomNumber(1, 100));
                        break;
                }
            }

            return production;

        }

        public static int GetRandomNumber(int min, int max)
        {
            Random r = new Random();
            System.Threading.Thread.Sleep(10);
            return r.Next(min, max + 1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape r = new Rectangle(5,6);
            Shape s = new Square(7);
            Shape t = new Triangle(3, 4, 5);

            Console.WriteLine(r.Area);
            Console.WriteLine(s.Area);
            Console.WriteLine(t.Area);

            ShapeFactory factory = new ShapeFactory();

            Shape[] shapeGroup = new Shape[10];
            for (int i = 0; i < shapeGroup.Length; i++) 
            {
                shapeGroup[i] = factory.CreateRandomShape();
            }

            for (int i = 0; i < shapeGroup.Length; i++) 
            {
                Console.WriteLine(shapeGroup[i].Area);
            }

            Console.ReadLine();
        }
    }
}
