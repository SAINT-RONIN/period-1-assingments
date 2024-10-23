using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    internal class Circle
    {
        private double _radius;
        private int _area;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Area
        {
            get { return Math.PI * _radius * _radius; }
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"\nRadius {_radius}");
            Console.WriteLine($"Area: {Area:0.00}");
        }
    }
}
