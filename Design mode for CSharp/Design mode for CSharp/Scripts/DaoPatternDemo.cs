/*
 *************************************************************
 * Copyright (c) 2017 - 2019 liuaf
 * Create time：2017/11/8 14:35:32
 * Created by：liuaf
 * Contact information：329737941@qq.com
 **************************************************************
 */

using Design_mode_for_CSharp.Scripts.Data_Access_Object_Pattern;
using System;

namespace Design_mode_for_CSharp.Scripts
{
    /*
     * 数据访问对象模式
     * 数据访问对象模式（Data Access Object Pattern）或 DAO 模式用于把低级的数据访问 API 或操作从高级的业务服务中分离出来。以下是数据访问对象模式的参与者。
     * 数据访问对象接口（Data Access Object Interface） - 该接口定义了在一个模型对象上要执行的标准操作。
     * 数据访问对象实体类（Data Access Object concrete class） - 该类实现了上述的接口。该类负责从数据源获取数据，数据源可以是数据库，也可以是 xml，或者是其他的存储机制。
     * 模型对象/数值对象（Model Object/Value Object） - 该对象是简单的 POJO，包含了 get/set 方法来存储通过使用 DAO 类检索到的数据。
     */
    public class DaoPatternDemo
    {
        public DaoPatternDemo()
        {
            IStudentDao studentDao = new StudentDaoImpl();

            //输出所有的学生
            foreach (Student stu in studentDao.getAllStudents().Values)
            {
                Console.WriteLine("Student: [RollNo : " + stu.getRollNo() + ", Name : " + stu.getName() + " ]");
            }

            //更新学生
            Student student = studentDao.getStudent(0);
            student.setName("Michael");
            studentDao.updateStudent(student);

            //获取学生
            studentDao.getStudent(0);
            Console.WriteLine("Student: [RollNo : " + student.getRollNo() + ", Name : " + student.getName() + " ]");
        }
    }
}