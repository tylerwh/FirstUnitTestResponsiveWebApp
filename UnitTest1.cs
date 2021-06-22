using FirstResponsiveWebAppHochstetler.Models;
using System;
using Xunit;

namespace MyFirstXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void TestAgeTodayPass()
        {
            // Arrange
            Person testJohn = new Person();
            testJohn.FirstName = "John";
            testJohn.LastName = "Doe";
            testJohn.DateOfBirth = new DateTime(1990, 02, 14);

            int expected = 31;
            int actual;

            // Act
            actual = (int)testJohn.AgeToday();

            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TestAgeTodayZero()
        {
            // Arrange
            DateTime dynamicDOB = new DateTime();
            dynamicDOB = DateTime.Now;
            int year = dynamicDOB.Year - 1;
            int month = dynamicDOB.Month;
            int day = dynamicDOB.Day + 1;

            Person testJohn = new Person();
            testJohn.FirstName = "John";
            testJohn.LastName = "Doe";
            testJohn.DateOfBirth = new DateTime(year, month, day);

            int expected = 0;
            int actual;

            // Act
            actual = (int)testJohn.AgeToday();

            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TestFirstName()
        {
            // Arrange
            Person testJohn = new Person();
            testJohn.FirstName = "John";
            testJohn.LastName = "Doe";
            testJohn.DateOfBirth = new DateTime(1990, 02, 14);

            string expected = "John";
            string actual;

            // Act
            actual = testJohn.FirstName;

            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TestLastName()
        {
            // Arrange
            Person testJohn = new Person();
            testJohn.FirstName = "John";
            testJohn.LastName = "Doe";
            testJohn.DateOfBirth = new DateTime(1990, 02, 14);

            string expected = "Doe";
            string actual;

            // Act
            actual = testJohn.LastName;

            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TestDOB()
        {
            // Arrange
            Person testJohn = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = new DateTime(1990, 02, 14)
            };

            DateTime expected = new DateTime(1990, 02, 14);
            DateTime actual;

            // Act
            actual = testJohn.DateOfBirth;

            // Assert
            Assert.Equal(expected, actual);

        }
    }
}
