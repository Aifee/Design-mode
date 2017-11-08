/*
 *************************************************************
 * Copyright (c) 2017 - 2019 liuaf
 * Create time：2017/11/8 14:35:32
 * Created by：liuaf
 * Contact information：329737941@qq.com
 **************************************************************
 */

namespace Design_mode_for_CSharp.Scripts.Null_Object_Pattern
{
    public class NullCustomer : AbstractCustomer
    {
        public override string getName()
        {
            return "Not Available in Customer Database";
        }

        public override bool isNull()
        {
            return true;
        }
    }
}