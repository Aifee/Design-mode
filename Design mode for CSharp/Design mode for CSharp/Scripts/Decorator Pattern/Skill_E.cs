using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Decorator_Pattern
{
    /// <summary>
    /// ConreteDecorator 技能：E
    /// </summary>
    public class Skill_E : Skills
    {
        private string skillName;

        public Skill_E(IHero hero, string skillName)
            : base(hero)
        {
            this.skillName = skillName;
        }
        public override void learnSkills()
        {
            Console.WriteLine("学习了技能E:" +skillName);
            base.learnSkills();
        }
    }
}
