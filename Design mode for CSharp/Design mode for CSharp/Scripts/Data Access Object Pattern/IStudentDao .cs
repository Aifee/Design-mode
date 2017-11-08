/*
 *************************************************************
 * Copyright (c) 2017 - 2019 liuaf
 * Create time：2017/11/8 14:35:32
 * Created by：liuaf
 * Contact information：329737941@qq.com
 **************************************************************
 */

using System.Collections.Generic;

namespace Design_mode_for_CSharp.Scripts.Data_Access_Object_Pattern
{
    public interface IStudentDao
    {
        Dictionary<int, Student> getAllStudents();

        Student getStudent(int rollNo);

        void updateStudent(Student student);

        void deleteStudent(Student student);
    }
}