using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AutoMapper;

namespace ThirteenDaysAWeek.AutoMapper4Mvc.Configuration
{
    public static class ProfileLoader
    {
        public static void LoadProfiles()
        {
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
        }
    }
}
