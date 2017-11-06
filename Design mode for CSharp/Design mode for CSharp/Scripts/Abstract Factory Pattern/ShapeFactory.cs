using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Abstract_Factory_Pattern
{
    public class ShapeFactory : AbstractFactory 
    {
        public override Color getColor(Type type)
        {
            return null;
        }

        public override Color getColor<T>()
        {
            return null;
        }

        public override Shape getShape(Type type)
        {
            return Activator.CreateInstance(type) as Shape;
        }

        public override Shape getShape<T>()
        {
            return Activator.CreateInstance<T>() as Shape;
        }
    }
}
