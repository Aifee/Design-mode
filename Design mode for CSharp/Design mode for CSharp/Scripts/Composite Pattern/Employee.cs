using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Composite_Pattern
{
    public class Employee
    {
        private string name;
        private string dept;
        private int salary;
        private List<Employee> subordinates;

        //构造函数
        public Employee(string name, string dept, int sal)
        {
            this.name = name;
            this.dept = dept;
            this.salary = sal;
            subordinates = new List<Employee>();
        }

        public void Add(Employee e)
        {
            subordinates.Add(e);
        }

        public void Remove(Employee e)
        {
            subordinates.Remove(e);
        }

        public List<Employee> getSubordinates()
        {
            return subordinates;
        }
        public override string ToString()
        {
            return string.Format("Employee :[ Name : {0}, dept : {1}, salary : {1}]", name, dept, salary); 
        }
    }
}
