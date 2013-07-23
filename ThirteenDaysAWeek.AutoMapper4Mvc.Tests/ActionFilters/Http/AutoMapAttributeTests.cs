using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThirteenDaysAWeek.AutoMapper4Mvc.ActionFilters.Http;

namespace ThirteenDaysAWeek.AutoMapper4Mvc.Tests.ActionFilters.Http
{
    [TestClass()]
    public class AutoMapAttributeTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
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
            Type sourceType = typeof (int);
            Type destinationType = typeof (string);

            // Act
            AutoMapAttribute attribute = new AutoMapAttribute(sourceType, destinationType);

            // Assert
            Assert.AreEqual(sourceType, attribute.SourceType);
        }

        [TestMethod()]
        public void Constructor_Should_Set_DestinationType_Property()
        {
            // Arrange
            Type sourceType = typeof (int);
            Type destinationType = typeof (string);

            // Act
            AutoMapAttribute attribute = new AutoMapAttribute(sourceType, destinationType);

            // Assert
            Assert.AreEqual(destinationType, attribute.DestinationType);
        }
    }
}
