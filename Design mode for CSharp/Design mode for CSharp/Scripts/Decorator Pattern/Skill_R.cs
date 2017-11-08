using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Decorator_Pattern
{
    /// <summary>
    /// ConreteDecorator 技能：R
    /// </summary>
    public class Skill_R : Skills
    {
        private string skillName;

        public Skill_R(IHero hero, string skillName)
            : base(hero)
        {
            this.skillName = skillName;
        }
        public override void learnSkills()
        {
            Console.WriteLine("学习了技能R:" +skillName);
            base.learnSkills();
        }
    }
}
