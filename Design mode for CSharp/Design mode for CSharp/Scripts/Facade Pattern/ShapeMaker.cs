﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Facade_Pattern
{
    public class ShapeMaker
    {
        private IShape circle;
        private IShape rectangle;
        private IShape square;

        public ShapeMaker()
        {
            circle = new Circle();
            rectangle = new Rectangle();
            square = new Square();
        }

        public void drawCircle()
        {
            circle.draw();
        }
        public void drawRectangle()
        {
            rectangle.draw();
        }
        public void drawSquare()
        {
            square.draw();
        }
    }
}
