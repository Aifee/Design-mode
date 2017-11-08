using Design_mode_for_CSharp.Scripts.Filter_Pattern;
using System;
using System.Collections.Generic;

namespace Design_mode_for_CSharp.Scripts
{
    /*
     * 过滤器模式
     * 
     * 过滤器模式（Filter Pattern）或标准模式（Criteria Pattern）是一种设计模式，
     * 这种模式允许开发人员使用不同的标准来过滤一组对象，
     * 通过逻辑运算以解耦的方式把它们连接起来。
     * 这种类型的设计模式属于结构型模式，它结合多个标准来获得单一标准。
     */
    public class FilterPatternDemo
    {
        public FilterPatternDemo()
        {
            List<Person> persons = new List<Person>();

            persons.Add(new Person("Robert", "Male", "Single"));
            persons.Add(new Person("John", "Male", "Married"));
            persons.Add(new Person("Laura", "Female", "Married"));
            persons.Add(new Person("Diana", "Female", "Single"));
            persons.Add(new Person("Mike", "Male", "Single"));
            persons.Add(new Person("Bobby", "Male", "Single"));

            ICriteria male = new CriteriaMale();
            ICriteria female = new CriteriaFemale();
            ICriteria single = new CriteriaSingle();
            ICriteria singleMale = new AndCriteria(single, male);
            ICriteria singleOrFemale = new OrCriteria(single, female);

            Console.WriteLine("Males: ");
            printPersons(male.meetCriteria(persons));

            Console.WriteLine("\nFemales: ");
            printPersons(female.meetCriteria(persons));

            Console.WriteLine("\nSingle Males: ");
            printPersons(singleMale.meetCriteria(persons));

            Console.WriteLine("\nSingle Or Females: ");
            printPersons(singleOrFemale.meetCriteria(persons));
        }

        public void printPersons(List<Person> persons)
        {
            foreach (Person person in persons)
            {
                Console.WriteLine("Person : [ Name : {0}, Gender : {1}, Marital Status : {2} ]", person.getName(), person.getGender(), person.getMaritalStatus());
            }
        }
    }
}