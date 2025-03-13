using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Task_3
{
    internal class Rectangle : Shape, ICalculateArea
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(string name, double length, double width) : base(name)
        {
            this.Length = length;
            this.Width = width;
        }

        
        public void ICalculateArea()
        {
            double area = Length * Width;
            Console.WriteLine($"The total area is: {area}");
        }
    }
}
