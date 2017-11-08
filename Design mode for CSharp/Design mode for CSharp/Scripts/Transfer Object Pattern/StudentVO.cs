﻿/*
 *************************************************************
 * Copyright (c) 2017 - 2019 liuaf
 * Create time：2017/11/8 14:35:32
 * Created by：liuaf
 * Contact information：329737941@qq.com
 **************************************************************
 */

namespace Design_mode_for_CSharp.Scripts.Transfer_Object_Pattern
{
    public class StudentVO
    {
        private string name;
        private int rollNo;

        public StudentVO(string name, int rollNo)
        {
            this.name = name;
            this.rollNo = rollNo;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getRollNo()
        {
            return rollNo;
        }

        public void setRollNo(int rollNo)
        {
            this.rollNo = rollNo;
        }
    }
}