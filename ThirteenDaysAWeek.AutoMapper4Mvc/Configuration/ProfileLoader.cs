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

        public static void LoadProfiles(IProfileLoadStrategy loadStrategy)
        {
            IEnumerable<Assembly> assembliesToScan = loadStrategy.GetAssembliesToScan();
            IEnumerable<Type> profiles = GetProfileTypes(assembliesToScan);

            Mapper.Initialize(configuration =>
                {
                    profiles.ForEach(type => configuration.AddProfile((Profile) Activator.CreateInstance(type)));
                });
        }

        private static IEnumerable<Type> GetProfileTypes(IEnumerable<Assembly> assembliesToScan)
        {
            Type profileType = typeof (Profile);

            IEnumerable<Type> profiles = assembliesToScan.SelectMany(assembly => assembly.GetTypes())
                .Where(type => profileType.IsAssignableFrom(type) && !type.IsAbstract && type != profileType);

            return profiles;
        }
    }
}
