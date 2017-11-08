/*
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

namespace Design_mode_for_CSharp.Scripts.Iterator_Pattern
{
    public class NameRepository : IContainer
    {
        public static string[] names = {"Robert" , "John" ,"Julie" , "Lora"};
        public IIterator getIterator()
        {
            return new NameIterator();
        }

        private class NameIterator : IIterator
        {
            private int index;
            public bool hasNext()
            {
                if (index < names.Length)
                {
                    return true;
                }
                return false;
            }

            public object next()
            {
                if (this.hasNext())
                {
                    return names[index++];
                }
                return null;
            }
        }
    }
}
