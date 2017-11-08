using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Bridge_Pattern
{
    public class GreenCircle : IDrawAPI
    {
        public void drawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Drawing Circle[ color: green, radius: {0}, x : {1}, y : {2}]", radius, x, y);
        }
    }
}
