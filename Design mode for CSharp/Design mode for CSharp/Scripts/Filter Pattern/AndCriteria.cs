using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Filter_Pattern
{
    public class AndCriteria : ICriteria 
    {
        private ICriteria criteria;
        private ICriteria otherCriteria;

        public AndCriteria(ICriteria criteria, ICriteria otherCriteria)
        {
            this.criteria = criteria;
            this.otherCriteria = otherCriteria;
        }
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> firstCriteriaPersons = criteria.meetCriteria(persons);
            return otherCriteria.meetCriteria(firstCriteriaPersons);
        }
    }
}
