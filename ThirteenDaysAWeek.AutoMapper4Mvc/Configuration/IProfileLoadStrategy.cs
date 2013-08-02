using System.Collections.Generic;
using System.Reflection;

namespace ThirteenDaysAWeek.AutoMapper4Mvc.Configuration
{
    public interface IProfileLoadStrategy
    {
        IEnumerable<Assembly> GetAssembliesToScan();
    }

    public class AllLoadedAssembliesStrategy : IProfileLoadStrategy
    {
        public IEnumerable<Assembly> GetAssembliesToScan()
        {
            throw new System.NotImplementedException();
        }
    }
}
