using EstateMaintenance;
using Xunit;

namespace UnitTests
{
    public class UnitTestsProperties
    {
        [Fact]
        public void CommercialPropertyToStringTest()
        {
            //Arrange
            Commercial propertyToTest;

            //Act
            propertyToTest = new Commercial("123 Street", "Simons Socks", Enums.CommericalType.OFFICE, 1200, new Tenant("Simon", "West"));
            var testString = propertyToTest.ToString();

            //Assert
            Assert.Equal("Address: 123 Street Name: Simons Socks Type: OFFICE Size: 1200", testString);

        }
    }
}