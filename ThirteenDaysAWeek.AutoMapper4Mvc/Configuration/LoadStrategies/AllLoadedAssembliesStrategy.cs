using System;
using System.Collections.Generic;
using System.Reflection;

namespace ThirteenDaysAWeek.AutoMapper4Mvc.Configuration.LoadStrategies
{
    /// <summary>
    /// AllLoadedAssembliesStrategy is an IProfileLoadStrategy implementation that returns
    /// a list of all assemblies loaded into the AppDomain
    /// </summary>
    public class AllLoadedAssembliesStrategy : IProfileLoadStrategy
    {
        /// <summary>
        /// Returns a list of all assemblies loaded into the current AppDomain
        /// </summary>
        /// <returns>A list of assemblies to scan for AutoMapper profiles</returns>
        public IEnumerable<Assembly> GetAssembliesToScan()
        {
            return AppDomain.CurrentDomain.GetAssemblies();
        }
    }
}