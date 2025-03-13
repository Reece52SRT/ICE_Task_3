using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Task_3
{
    internal class Circle : Shape, ICalculateArea
    {
        public double Radius { get; set; }
        public Circle(string name, double radius) : base(name)
        {
            this.Radius = radius;
        }

        public void ICalculateArea()
        {
            double circleArea = Math.PI * Math.Pow(Radius, 2);
            Console.WriteLine($"The total area is: {circleArea}\n");
        }
    }
}
