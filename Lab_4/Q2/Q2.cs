﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4.Q2
{
    internal class Q2
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "BMW";
            car.Model = "X5";
            car.Year = 2022;
            Console.WriteLine("Car = " + car.Show);
        }
    }
    class Car
    {
        private string make, model;
        private int year;
        public string Make
        {
            set
            {
                make = value;
            }
        }
        public string Model
        {
            set
            {
                model = value;
            }
        }
        public int Year
        {
            set
            {
                year = value;
            }
        }
        public object Show
        {
            get
            {
                return make + " " + model + " " + year;
            }
        }
    }
}
