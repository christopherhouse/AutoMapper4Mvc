using System;
using System.Collections.Generic;
using System.Reflection;

namespace ThirteenDaysAWeek.AutoMapper4Mvc.Configuration
{
    public class AllLoadedAssembliesStrategy : IProfileLoadStrategy
    {
        public IEnumerable<Assembly> GetAssembliesToScan()
        {
            return AppDomain.CurrentDomain.GetAssemblies();
        }
    }
}