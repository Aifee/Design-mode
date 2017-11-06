using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Abstract_Factory_Pattern
{
    public class Green : Color
    {
        public void fill()
        {
            Console.WriteLine("Inside Green::fill() method.");
        }
    }
}
