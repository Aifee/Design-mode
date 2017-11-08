using System;

namespace Design_mode_for_CSharp.Scripts.Prototype_Pattern
{
    [Serializable]
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            type = "Rectangle";
        }

        public override void draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}