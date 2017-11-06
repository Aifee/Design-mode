﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Factory_Pattern
{
    public class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Inside Circle.draw() method.");
        }
    }
}
