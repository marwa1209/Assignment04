using Assignment03.interfaces.question1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03.question1Classes
{
    internal class Circle : ICircle
    {
        public double Radius { get; set; }
        public Circle(double r)
        {
            Radius = r;
        }
        public double Area => Math.PI * Radius * Radius;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle: Radius = {Radius}, Area = {Area}");
        }
    }
}
