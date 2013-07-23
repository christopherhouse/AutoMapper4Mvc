using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThirteenDaysAWeek.AutoMapper4Mvc.ActionFilters.Http;

namespace ThirteenDaysAWeek.AutoMapper4Mvc.Tests.ActionFilters.Http
{
    [TestClass()]
    public class AutoMapAttributeTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_Should_Throw_ArgumentNullException_If_SourceType_Is_Null()
        {
            // Arrange
            Type sourceType = null;
            Type destinationType = typeof (object);

            // Act
            AutoMapAttribute attribute = new AutoMapAttribute(sourceType, destinationType);

            // Assert
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_Should_Throw_ArgumentNullException_If_DestinationType_Is_Null()
        {
            // Arrange
            Type sourceType = typeof (object);
            Type destinationType = null;

            // Act
            AutoMapAttribute attribute = new AutoMapAttribute(sourceType, destinationType);

            // Assert
        }

        [TestMethod()]
        public void Constructor_Should_Set_SourceType_Property()
        {
            // Arrange

            // Act

            // Assert
            Assert.Fail();
        }

        [TestMethod()]
        public void Constructor_Should_Set_DestinationType_Property()
        {
            // Arrange

            // Act

            // Assert
            Assert.Fail();
        }
    }
}
