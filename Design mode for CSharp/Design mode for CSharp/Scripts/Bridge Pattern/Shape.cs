using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Bridge_Pattern
{
    public abstract class Shape
    {
        protected IDrawAPI drawAPI;
        protected Shape(IDrawAPI drawAPI)
        {
            this.drawAPI = drawAPI;
        }
        public abstract void draw();
    }
}
