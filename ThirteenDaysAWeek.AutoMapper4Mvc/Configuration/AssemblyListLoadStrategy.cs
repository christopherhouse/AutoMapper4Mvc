using System.Collections.Generic;
using System.Reflection;

namespace ThirteenDaysAWeek.AutoMapper4Mvc.Configuration
{
    public class AssemblyListLoadStrategy : List<Assembly>, IProfileLoadStrategy
    { 
        public IEnumerable<Assembly> GetAssembliesToScan()
        {
            return this;
        }
    }
}
