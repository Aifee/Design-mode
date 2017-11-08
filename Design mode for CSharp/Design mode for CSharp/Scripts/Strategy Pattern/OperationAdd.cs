/*
 *************************************************************
 * Copyright (c) 2017 - 2019 liuaf
 * Create time：2017/11/8 14:35:32
 * Created by：liuaf
 * Contact information：329737941@qq.com
 **************************************************************
 */

namespace Design_mode_for_CSharp.Scripts.Strategy_Pattern
{
    public class OperationAdd : IStrategy
    {
        public int doOperation(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}