using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Builder_Pattern
{
    public class Coke : ColdDrink
    {
        public override float price()
        {
            return 30.0f;
        }
        public override string name()
        {
            return "Coke";
        }
    }
}
