using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Decorator_Pattern
{
    /// <summary>
    /// ConreteDecorator 技能：Q
    /// </summary>
    public class Skill_Q :Skills
    {
        private string skillName;

        public Skill_Q(IHero hero, string skillName)
            : base(hero)
        {
            this.skillName = skillName;
        }
        public override void learnSkills()
        {
            Console.WriteLine("学习了技能Q:" +skillName);
            base.learnSkills();
        }
    }
}
