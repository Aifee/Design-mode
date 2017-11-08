/*
 *************************************************************
 * Copyright (c) 2017 - 2019 liuaf
 * Create time：2017/11/8 14:35:32
 * Created by：liuaf
 * Contact information：329737941@qq.com
 **************************************************************
 */

using System;

namespace Design_mode_for_CSharp.Scripts.Command_Pattern
{
    public class Stock
    {
        private string name = "ABC";
        private int quantity = 10;

        public void buy()
        {
            Console.WriteLine("Stock [ Name: {0}, Quantity: {1} ] bought", name, quantity);
        }

        public void sell()
        {
            Console.WriteLine("Stock [ Name: {0}, Quantity: {1} ] sold", name, quantity);
        }
    }
}