using System;

namespace Design_mode_for_CSharp.Scripts.Prototype_Pattern
{
    [Serializable]
    public class Circle : Shape
    {
        public Circle()
        {
            type = "Circle";
        }

        public override void draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
}