namespace Design_mode_for_CSharp.Scripts.Builder_Pattern
{
    public abstract class ColdDrink : IItem
    {
        public IPacking packing()
        {
            return new Bottle();
        }

        public abstract float price();

        public abstract string name();
    }
}