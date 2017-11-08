using System.Collections.Generic;

namespace Design_mode_for_CSharp.Scripts.Filter_Pattern
{
    public class CriteriaMale : ICriteria
    {
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> malePersons = new List<Person>();
            foreach (Person person in persons)
            {
                if (person.getGender().ToUpper().Equals("MALE"))
                {
                    malePersons.Add(person);
                }
            }
            return malePersons;
        }
    }
}