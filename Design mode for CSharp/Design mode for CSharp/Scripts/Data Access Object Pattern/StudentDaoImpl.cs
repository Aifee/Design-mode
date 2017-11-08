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

namespace Design_mode_for_CSharp.Scripts.Data_Access_Object_Pattern
{
    public class StudentDaoImpl : IStudentDao
    {
        private Dictionary<int, Student> students;

        public StudentDaoImpl()
        {
            students = new Dictionary<int, Student>();
            Student student1 = new Student("Robert", 0);
            Student student2 = new Student("John", 1);
            students.Add(student1.getRollNo(), student1);
            students.Add(student2.getRollNo(), student2);
        }

        public Dictionary<int, Student> getAllStudents()
        {
            return students;
        }

        public Student getStudent(int rollNo)
        {
            return students[rollNo];
        }

        public void updateStudent(Student student)
        {
            if (students.ContainsKey(student.getRollNo()))
            {
                students[student.getRollNo()].setName(student.getName());
                Console.WriteLine("Student: Roll No " + student.getRollNo() + ", updated in the database");
            }
            else
            {
                Console.WriteLine("don't find the key{0} in students!");
            }
        }

        public void deleteStudent(Student student)
        {
            if (students.ContainsKey(student.getRollNo()))
            {
                students.Remove(student.getRollNo());
                Console.WriteLine("Student: Roll No " + student.getRollNo() + ", deleted from database");
            }
            else
            {
                Console.WriteLine("don't remove the key{0} in students!");
            }
        }
    }
}