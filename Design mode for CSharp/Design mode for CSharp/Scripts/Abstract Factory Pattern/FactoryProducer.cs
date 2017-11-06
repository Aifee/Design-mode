using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Abstract_Factory_Pattern
{
    public class FactoryProducer
    {
        public static AbstractFactory getFactory(Type type)
        {
            return Activator.CreateInstance(type) as AbstractFactory;
        }
        public static AbstractFactory getFactory<T>() where T : AbstractFactory
        {
            return Activator.CreateInstance<T>();
        }
    }
}
