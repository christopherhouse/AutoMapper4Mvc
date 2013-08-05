using System.Collections.Generic;
using System.Reflection;

namespace ThirteenDaysAWeek.AutoMapper4Mvc.Configuration.LoadStrategies
{
    public interface IProfileLoadStrategy
    {
        IEnumerable<Assembly> GetAssembliesToScan();
    }
}
