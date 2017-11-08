using System.Collections.Generic;

namespace Design_mode_for_CSharp.Scripts.Filter_Pattern
{
    public class CriteriaSingle : ICriteria
    {
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> singlePersons = new List<Person>();
            foreach (Person person in persons)
            {
                if (person.getMaritalStatus().ToUpper().Equals("SINGLE"))
                {
                    singlePersons.Add(person);
                }
            }
            return singlePersons;
        }
    }
}