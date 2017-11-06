using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Factory_Pattern
{
    public class ShapeFactory
    {
        public Shape GetShape(string shapeType)
        {
            if (shapeType.Equals(""))
            {
                return null;
            }
            switch (shapeType.ToLower())
            {
                case "circle":
                    return new Circle();
                    break;
                case "rectangle":
                    return new Rectangle();
                    break;
                case "square":
                    return new Square();
                    break;
            }
            return null;
        }

        public Shape GetShape(Type type)
        {
            return Activator.CreateInstance(type) as Shape;
        }
        public Shape GetShape<T>() where T : Shape
        {
            return Activator.CreateInstance<T>() as Shape;
        }
    }
    
}
