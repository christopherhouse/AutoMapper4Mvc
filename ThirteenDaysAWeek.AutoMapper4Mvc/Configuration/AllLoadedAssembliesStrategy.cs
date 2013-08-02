using System.Collections.Generic;
using System.Reflection;

namespace ThirteenDaysAWeek.AutoMapper4Mvc.Configuration
{
    public class AllLoadedAssembliesStrategy : IProfileLoadStrategy
    {
        public IEnumerable<Assembly> GetAssembliesToScan()
        {
            throw new System.NotImplementedException();
        }

        /*
                     Assembly[] assembliesToScan = AppDomain.CurrentDomain.GetAssemblies();
                    Type profileType = typeof (Profile);

                    IEnumerable<Type> profiles = assembliesToScan.SelectMany(assembly => assembly.GetTypes())
                                       .Where(type => profileType.IsAssignableFrom(type) && !type.IsAbstract && type != profileType);

                    Mapper.Initialize(configuration =>
                        {
                            foreach (Type profile in profiles)
                            {
                                configuration.AddProfile((Profile) Activator.CreateInstance(profile));
                            }
                        });
         */
    }
}