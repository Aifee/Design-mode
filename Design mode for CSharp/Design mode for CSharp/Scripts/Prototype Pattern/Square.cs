using System;

namespace Design_mode_for_CSharp.Scripts.Prototype_Pattern
{
    [Serializable]
    public class Square : Shape
    {
        public Square()
        {
            type = "Square";
        }

        public override void draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}