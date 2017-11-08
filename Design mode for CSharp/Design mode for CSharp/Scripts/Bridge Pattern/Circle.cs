using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Bridge_Pattern
{
    public class Circle : Shape
    {
        private int x;
        private int  y;
        private int radius;

        public Circle(int x, int y, int radius, IDrawAPI drawAPI)
            : base(drawAPI)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void draw()
        {
            drawAPI.drawCircle(radius, x, y);
        }
    }
}
