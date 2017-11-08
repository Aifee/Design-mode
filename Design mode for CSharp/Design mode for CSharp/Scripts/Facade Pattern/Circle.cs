using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Facade_Pattern
{
    public class Circle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Circle::draw()");
        }
    }
}
