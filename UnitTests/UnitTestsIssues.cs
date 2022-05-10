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
            majorIssue = new MajorIssue("Water Damage", Enums.IssueSeverity.HIGH);
            string? majorIssueString = majorIssue.ToString();

            //Assert
            Assert.IsType<MajorIssue>(majorIssue);
            Assert.Equal(majorIssueString, $"Description: Water Damage Priority: HIGH Created On: {DateTime.Now}");

        }

        [Fact]
        public void MajorIssueCheckTypeTest()
        {
            //Arrange
            MajorIssue majorIssue;

            //Act
            majorIssue = new MajorIssue("Water Damage", Enums.IssueSeverity.HIGH);

            //Assert
            Assert.IsType<MajorIssue>(majorIssue);

        }
    }
}