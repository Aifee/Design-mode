﻿/*
 *************************************************************
 * Copyright (c) 2017 - 2019 liuaf
 * Create time：2017/11/8 14:35:32
 * Created by：liuaf
 * Contact information：329737941@qq.com
 **************************************************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Null_Object_Pattern
{
    public class RealCustomer : AbstractCustomer
    {
        public RealCustomer(string name)
        {
            this.Name = name;
        }
        public override string getName()
        {
            return Name;
        }
        public override bool isNull()
        {
            return false;
        }
    }
}
