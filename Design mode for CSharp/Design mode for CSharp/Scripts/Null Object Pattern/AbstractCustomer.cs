﻿/*
 *************************************************************
 * Copyright (c) 2017 - 2019 liuaf
 * Create time：2017/11/8 14:35:32
 * Created by：liuaf
 * Contact information：329737941@qq.com
 **************************************************************
 */

namespace Design_mode_for_CSharp.Scripts.Null_Object_Pattern
{
    public abstract class AbstractCustomer
    {
        protected string Name;

        public abstract bool isNull();

        public abstract string getName();
    }
}