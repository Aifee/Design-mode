using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Decorator_Pattern
{
    /// <summary>
    /// ConcreteComponent 具体英雄盲僧
    /// </summary>
    public class BlindMonk : IHero
    {
        private string name;

        public BlindMonk(string name)
        {
            this.name = name;
        }


        public void learnSkills()
        {
            Console.WriteLine(name + "学习了以上技能！");
        }
    }
}
