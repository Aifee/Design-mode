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
    public class CustomerFactory
    {
        public static readonly string[] names = { "Rob", "Joe", "Julie" };

        public static AbstractCustomer getCustomer(string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].ToLower().Equals(name.ToLower()))
                {
                    return new RealCustomer(name);
                }
            }
            return new NullCustomer();
        }
    }
}