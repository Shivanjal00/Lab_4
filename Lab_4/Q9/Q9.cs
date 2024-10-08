﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4.Q9
{
    internal class Q9
    {
        public enum Shape
        {
            Circle,
            Square,
            Triangle
        }
        public static double CalArea(Shape shape, double side1, double side2 = 0.0)
        {
            switch (shape)
            {
                case Shape.Circle:
                    return Math.PI * Math.Pow(side1, 2);
                case Shape.Square:
                    return Math.Pow(side1, 2);
                case Shape.Triangle:
                    return 0.5 * side1 * side2;
                default:
                    throw new ArgumentException("Invalid shape");
            }
        }
        static void Main(string[] args)
        {
            Shape shape = Shape.Circle;
            Console.WriteLine("The Area of " + shape + " is : " + CalArea(shape, 10.0, 0.0));
        }
    }
}
