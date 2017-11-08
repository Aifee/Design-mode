using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Filter_Pattern
{
    public interface ICriteria
    {
        List<Person> meetCriteria(List<Person> persons);
    }
}
