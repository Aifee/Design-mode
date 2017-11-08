/*
 *************************************************************
 * Copyright (c) 2017 - 2019 liuaf
 * Create time：2017/11/8 14:35:32
 * Created by：liuaf
 * Contact information：329737941@qq.com
 **************************************************************
 */

using System;

namespace Design_mode_for_CSharp.Scripts.Intercepting_Filter_Pattern
{
    public class Target : IFilter
    {
        public void execute(string request)
        {
            Console.WriteLine("Executing request: " + request);
        }
    }
}