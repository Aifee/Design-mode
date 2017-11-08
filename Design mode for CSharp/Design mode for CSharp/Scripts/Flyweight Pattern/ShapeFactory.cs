using System;
using System.Collections.Generic;

namespace Design_mode_for_CSharp.Scripts.Flyweight_Pattern
{
    public class ShapeFactory
    {
        private static readonly Dictionary<string, IShape> circleMap = new Dictionary<string, IShape>();

        public static IShape getCircle(string color)
        {
            IShape shape = null;
            if (!circleMap.TryGetValue(color, out shape))
            {
                shape = new Circle(color);
                circleMap.Add(color, shape);
                Console.WriteLine("Creating circle of color : " + color);
            }
            return shape;
        }
    }
}