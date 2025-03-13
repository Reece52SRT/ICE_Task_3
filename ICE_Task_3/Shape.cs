using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Task_3
{
    public abstract class Shape
    {
        protected string Name;

        public Shape (string name)
        {
            this.Name = name;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Shape Name: {Name}");
        }
    }
}
