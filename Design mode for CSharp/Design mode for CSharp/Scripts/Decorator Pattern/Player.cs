namespace Design_mode_for_CSharp.Scripts.Decorator_Pattern
{
    public class Player
    {
        public Player()
        {
            IHero hero = new BlindMonk("李青");

            Skills skills = new Skills(hero);
            Skills r = new Skill_R(skills, "猛龙摆尾");
            Skills e = new Skill_E(r, "天雷破/摧筋断骨");
            Skills w = new Skill_W(e, "金钟罩/铁布衫");
            Skills q = new Skill_Q(w, "天音波/回音击");
            //学习技能
            q.learnSkills();
        }
    }
}