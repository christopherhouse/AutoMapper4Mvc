using System.Collections.Generic;
using System.Reflection;

namespace ThirteenDaysAWeek.AutoMapper4Mvc.Configuration.LoadStrategies
{
    /// <summary>
    /// AssemblyListLoadStrategy is an IProfileLoadStrategy that subclasses List&lt;Assembly&gt; so that
    /// specific assemblies can be added to a list of assemblies to scan for AutoMapper profiles
    /// </summary>
    public class AssemblyListLoadStrategy : List<Assembly>, IProfileLoadStrategy
    { 
        /// <summary>
        /// Returns the list of assemblies to scan for AutoMapper profiles
        /// </summary>
        /// <returns>A list of assemblies to scan for AutoMapper profiles</returns>
        public IEnumerable<Assembly> GetAssembliesToScan()
        {
            return this;
        }
    }
}
