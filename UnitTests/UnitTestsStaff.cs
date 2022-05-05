using EstateMaintenance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests
{
    public class UnitTestsStaff
    {
        [Fact]
        public void StaffTeamMemberTypeTest()
        {
            //Arrange
            TeamMember staffToTest;

            //Act
            staffToTest = new TeamMember("Simon", "Wests", "scmwest", "Simon123!");

            //Assert
            Assert.Equal(Enums.StaffType.TEAM_MEMBER, staffToTest.Type);

        }
    }
}