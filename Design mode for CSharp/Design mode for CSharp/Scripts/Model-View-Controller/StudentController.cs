/*
 *************************************************************
 * Copyright (c) 2017 - 2019 liuaf
 * Create time：2017/11/8 14:35:32
 * Created by：liuaf
 * Contact information：329737941@qq.com
 **************************************************************
 */

using System;

namespace Design_mode_for_CSharp.Scripts.Model_View_Controller
{
    public class StudentController
    {
        private Student model;
        private StudentView view;

        public StudentController(Student model, StudentView view)
        {
            this.model = model;
            this.view = view;
        }

        public void setStudentName(String name)
        {
            model.setName(name);
        }

        public String getStudentName()
        {
            return model.getName();
        }

        public void setStudentRollNo(String rollNo)
        {
            model.setRollNo(rollNo);
        }

        public String getStudentRollNo()
        {
            return model.getRollNo();
        }

        public void updateView()
        {
            view.printStudentDetails(model.getName(), model.getRollNo());
        }
    }
}