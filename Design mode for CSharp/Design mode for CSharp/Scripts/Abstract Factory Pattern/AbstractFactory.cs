using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Abstract_Factory_Pattern
{
    public abstract class AbstractFactory
    {
        public abstract Color getColor(Type type);
        public abstract Color getColor<T>() where T : Color;
        public abstract Shape getShape(Type type);
        public abstract Shape getShape<T>() where T : Shape;
    }
}
