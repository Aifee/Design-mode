using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Decorator_Pattern
{
    /// <summary>
    /// Decorator 技能栏
    /// </summary>
    public class Skills : IHero
    {
        //持有一个英雄对象接口
        private IHero hero;

        public Skills(IHero hero)
        {
            this.hero = hero;
        }
        public virtual void learnSkills()
        {
            if (hero != null)
                hero.learnSkills();
        }
    }
}
