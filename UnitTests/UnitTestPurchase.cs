using EstateMaintenance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests
{
    public class UnitTestPurchase
    {
        [Fact]
        public void PurchaseToString()
        {
            //Arrange
            Purchase purchase;

            TeamMember Fin

            //Act
            Fin = new TeamMember("Fin", "Edwards", "UserFin", "Password123");

            purchase = new Purchase("purchased has been done", "4.95", Fin, true);

            //Assert
            Assert.Equal("4.95", Purchase.Cost)
        }

    }
}
