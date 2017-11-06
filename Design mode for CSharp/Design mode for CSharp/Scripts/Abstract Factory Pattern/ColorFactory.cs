using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Abstract_Factory_Pattern
{
    public class ColorFactory : AbstractFactory
    {
        public override Color getColor(Type type)
        {
            return Activator.CreateInstance(type) as Color;
        }

        public override Color getColor<T>()
        {
            return Activator.CreateInstance<T>() as Color;
        }

        public override Shape getShape(Type type)
        {
            return null;
        }

        public override Shape getShape<T>()
        {
            return null;
        }
    }
}
