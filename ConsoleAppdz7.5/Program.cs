﻿using System;
using System.Text;

namespace PrototypeFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            
            IFigure figure = new Rectangle(10, 20);
            IFigure clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            figure = new Circle(15);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            
            figure = new Triangle(29, 25, 48);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            Console.Read();
        }
    }

    interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }

    class Rectangle : IFigure
    {
        int width;
        int height;

        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }

        public IFigure Clone()
        {
            return new Rectangle(this.width, this.height);
        }

        public void GetInfo()
        {
            Console.WriteLine("Прямокутник довжиною {0} і шириною {1}", height, width);
        }
    }

    class Circle : IFigure
    {
        int radius;

        public Circle(int r)
        {
            radius = r;
        }

        public IFigure Clone()
        {
            return new Circle(this.radius);
        }

        public void GetInfo()
        {
            Console.WriteLine("Круг радіусом {0}", radius);
        }
    }

    class Triangle : IFigure
    {
        private int c;
        private int a;
        private int b;

        public Triangle(int c, int a,int b)
        {
            this.c = c;
            this.a = a;
            this.b = b;
        }

        public IFigure Clone()
        {
            return new Triangle(this.c, this.a,this.b);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Трикутник із основою {c} та сторонами {a} {b}");
        }
    }
}
