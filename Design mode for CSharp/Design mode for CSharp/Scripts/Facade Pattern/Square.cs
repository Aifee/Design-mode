using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Facade_Pattern
{
    public class Square : IShape
    {
        public void draw()
        {
            Console.WriteLine("Square::draw()");
        }
    }
}
