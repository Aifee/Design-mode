using System.Collections.Generic;

namespace Design_mode_for_CSharp.Scripts.Filter_Pattern
{
    public class CriteriaFemale : ICriteria
    {
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> femalePersons = new List<Person>();
            foreach (Person person in persons)
            {
                if (person.getGender().ToUpper().Equals("FEMALE"))
                {
                    femalePersons.Add(person);
                }
            }
            return femalePersons;
        }
    }
}