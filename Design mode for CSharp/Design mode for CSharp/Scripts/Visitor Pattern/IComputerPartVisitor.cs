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

namespace Design_mode_for_CSharp.Scripts.Visitor_Pattern
{
    public interface IComputerPartVisitor
    {
        void visit(Computer computer);
        void visit(Mouse mouse);
        void visit(Keyboard keyboard);
        void visit(Monitor monitor);
    }
}
