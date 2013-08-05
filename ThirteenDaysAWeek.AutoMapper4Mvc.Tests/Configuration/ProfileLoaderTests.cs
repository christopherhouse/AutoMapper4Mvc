using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ThirteenDaysAWeek.AutoMapper4Mvc.Configuration;
using ThirteenDaysAWeek.AutoMapper4Mvc.Configuration.LoadStrategies;

namespace ThirteenDaysAWeek.AutoMapper4Mvc.Tests.Configuration
{
    [TestClass()]
    public class ProfileLoaderTests
    {
        private Mock<IProfileLoadStrategy> _mockProfileLoadStrategy;

        [TestInitialize()]
        public void Setup()
        {
            _mockProfileLoadStrategy = new Mock<IProfileLoadStrategy>();
        }

        [TestMethod()]
        public void LoadProfiles_Should_Configure_AutoMapper_With_Registered_Profiles()
        {
            // Arrange
            Assembly dynamicAssembly = CreateAssembly();

            

            _mockProfileLoadStrategy.Setup(it => it.GetAssembliesToScan())
                                    .Returns(new List<Assembly>(new[] {dynamicAssembly}));

            // Act
            ProfileLoader.LoadProfiles(_mockProfileLoadStrategy.Object);

            // Assert
            _mockProfileLoadStrategy.VerifyAll();
        }

        private Assembly CreateAssembly()
        {
            AppDomain currentAppDomain = AppDomain.CurrentDomain;
            AssemblyName assemblyName = new AssemblyName("TestAssembly");

            AssemblyBuilder assemblyBuilder = currentAppDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);

            ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule("TestModule");
            TypeBuilder typeBuilder = moduleBuilder.DefineType("TestProfile", TypeAttributes.Public | TypeAttributes.Class, typeof (Profile));

            Type t = typeBuilder.CreateType();

            var x = Activator.CreateInstance(t) as Profile;

            string s = x.ProfileName;
            
            return assemblyBuilder;
        }
    }
}
