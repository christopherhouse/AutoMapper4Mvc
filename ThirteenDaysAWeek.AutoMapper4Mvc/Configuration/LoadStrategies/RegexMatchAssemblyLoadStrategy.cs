using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;

namespace ThirteenDaysAWeek.AutoMapper4Mvc.Configuration.LoadStrategies
{
    /// <summary>
    /// RegexMatchAssemblyLoadStrategy is an IProfileLoadStrategy implementation that
    /// returns a list of assemblies that have names matching a specified regex string
    /// </summary>
    public class RegexMatchAssemblyLoadStrategy : IProfileLoadStrategy
    {
        private readonly List<Assembly> _assemblies = new List<Assembly>();

        /// <summary>
        /// Creates an instance of the class and sets the regex that will be used
        /// to match assemblies to scan for AutoMapper profiles
        /// </summary>
        /// <param name="assemblyMatchRegex">The regex string used to match assembly names</param>
        public RegexMatchAssemblyLoadStrategy(string assemblyMatchRegex)
        {
            AddMatchingAssemblies(assemblyMatchRegex);
        }

        /// <summary>
        /// Returns the list of assemblies that match the regex passed into the constructor
        /// </summary>
        /// <returns>A list of assemblies to scan for AutoMapper profiles</returns>
        public IEnumerable<Assembly> GetAssembliesToScan()
        {
            return _assemblies;
        }

        private void AddMatchingAssemblies(string assemblyMatchRegex)
        {
            Regex regex = new Regex(assemblyMatchRegex);

            Assembly[] allAssemblies = AppDomain.CurrentDomain.GetAssemblies();

            allAssemblies.ForEach(assembly =>
                {
                    if (regex.IsMatch(assembly.FullName))
                    {
                        _assemblies.Add(assembly);
                    }
                });
        }
    }
}