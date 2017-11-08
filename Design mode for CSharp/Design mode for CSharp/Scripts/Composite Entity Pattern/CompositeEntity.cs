/*
 *************************************************************
 * Copyright (c) 2017 - 2019 liuaf
 * Create time：2017/11/8 14:35:32
 * Created by：liuaf
 * Contact information：329737941@qq.com
 **************************************************************
 */

namespace Design_mode_for_CSharp.Scripts.Composite_Entity_Pattern
{
    public class CompositeEntity
    {
        private CoarseGrainedObject cgo = new CoarseGrainedObject();

        public void setData(string data1, string data2)
        {
            cgo.setData(data1, data2);
        }

        public string[] getData()
        {
            return cgo.getData();
        }
    }
}