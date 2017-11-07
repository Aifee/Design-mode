﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Builder_Pattern
{
    public class Wrapper : IPacking
    {
        public string pack()
        {
            return "Wrapper";
        }
    }
}