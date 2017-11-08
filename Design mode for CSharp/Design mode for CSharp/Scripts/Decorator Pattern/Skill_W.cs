using System;

namespace Design_mode_for_CSharp.Scripts.Decorator_Pattern
{
    /// <summary>
    /// ConreteDecorator 技能：W
    /// </summary>
    public class Skill_W : Skills
    {
        private string skillName;

        public Skill_W(IHero hero, string skillName)
            : base(hero)
        {
            this.skillName = skillName;
        }

        public override void learnSkills()
        {
            Console.WriteLine("学习了技能W:" + skillName);
            base.learnSkills();
        }
    }
}