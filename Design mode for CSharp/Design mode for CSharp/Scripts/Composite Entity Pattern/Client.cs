/*
 *************************************************************
 * Copyright (c) 2017 - 2019 liuaf
 * Create time：2017/11/8 14:35:32
 * Created by：liuaf
 * Contact information：329737941@qq.com
 **************************************************************
 */

using System;

namespace Design_mode_for_CSharp.Scripts.Composite_Entity_Pattern
{
    public class Client
    {
        private CompositeEntity compositeEntity = new CompositeEntity();

        public void printData()
        {
            for (int i = 0; i < compositeEntity.getData().Length; i++)
            {
                Console.WriteLine("Data: " + compositeEntity.getData()[i]);
            }
        }

        public void setData(String data1, String data2)
        {
            compositeEntity.setData(data1, data2);
        }
    }
}