using System.Collections.Generic;
using System.Reflection;

namespace ThirteenDaysAWeek.AutoMapper4Mvc.Configuration.LoadStrategies
{
    /// <summary>
    /// IProfileLoadStrategy defines an interface for classes that provide a strategy for
    /// scanning for AutoMapper profiles
    /// </summary>
    public interface IProfileLoadStrategy
    {
        /// <summary>
        /// Returns a list of assemblies to scan for AutoMapper profiles
        /// </summary>
        /// <returns>A list of assemblies that should be scanned for profiles.</returns>
        IEnumerable<Assembly> GetAssembliesToScan();
    }
}
