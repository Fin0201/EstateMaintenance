using EstateMaintenance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests
{
    public class UnitTestsIssues
    {
        [Fact]
        public void MajorIssueToStringTest()
        {
            //Arrange
            MajorIssue majorIssue;

            //Act
            majorIssue = new MajorIssue("Water Damage", new DateTime(2022, 01, 01), Enums.IssueSeverity.HIGH);
            string? majorIssueString = majorIssue.ToString();

            //Assert
            Assert.Equal("Description: Water Damage Priority: HIGH Created On: 01/01/2022 00:00:00", majorIssueString);
            Assert.IsType<MajorIssue>(majorIssue);

        }

        [Fact]
        public void MajorIssueCheckTypeTest()
        {
            //Arrange
            MajorIssue majorIssue;

            //Act
            majorIssue = new MajorIssue("Water Damage", new DateTime(2022, 01, 01), Enums.IssueSeverity.HIGH);

            //Assert
            Assert.IsType<MajorIssue>(majorIssue);

        }
    }
}