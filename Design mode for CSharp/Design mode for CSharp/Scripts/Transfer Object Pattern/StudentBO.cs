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

namespace Design_mode_for_CSharp.Scripts.Transfer_Object_Pattern
{
    public class StudentBO
    {
        //列表是当作一个数据库
        private List<StudentVO> students;

        public StudentBO()
        {
            students = new List<StudentVO>();
            StudentVO student1 = new StudentVO("Robert", 0);
            StudentVO student2 = new StudentVO("John", 1);
            students.Add(student1);
            students.Add(student2);
        }

        public void deleteStudent(StudentVO student)
        {
            students.Remove(student);
            Console.WriteLine("Student: Roll No " + student.getRollNo() + ", deleted from database");
        }

        //从数据库中检索学生名单
        public List<StudentVO> getAllStudents()
        {
            return students;
        }

        public StudentVO getStudent(int rollNo)
        {
            return students[rollNo];
        }

        public void updateStudent(StudentVO student)
        {
            students[student.getRollNo()].setName(student.getName());
            Console.WriteLine("Student: Roll No " + student.getRollNo() + ", updated in the database");
        }
    }
}