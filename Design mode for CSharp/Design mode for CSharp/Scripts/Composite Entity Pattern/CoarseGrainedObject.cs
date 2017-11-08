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
    public class CoarseGrainedObject
    {
        private DependentObject1 do1 = new DependentObject1();
        private DependentObject2 do2 = new DependentObject2();

        public void setData(String data1, String data2)
        {
            do1.setData(data1);
            do2.setData(data2);
        }

        public string[] getData()
        {
            return new string[] { do1.getData(), do2.getData() };
        }
    }
}