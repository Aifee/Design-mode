/*
 *************************************************************
 * Copyright (c) 2017 - 2019 liuaf
 * Create time：2017/11/8 14:35:32
 * Created by：liuaf
 * Contact information：329737941@qq.com
 **************************************************************
 */

using System;

namespace Design_mode_for_CSharp.Scripts.Service_Locator_Pattern
{
    public class Service2 : IService
    {
        public string getName()
        {
            return "Service2";
        }

        public void execute()
        {
            Console.WriteLine("Executing Service2");
        }
    }
}