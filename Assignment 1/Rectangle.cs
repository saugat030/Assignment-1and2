using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Rectangle
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public double Area { get; private set; }

        public void ComputeArea()
        {
            Area = Length * Breadth;
        }

        public void DisplayArea()
        {
            Console.WriteLine($"Area: {Area}");
        }
    }
}
