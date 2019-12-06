using Microsoft.VisualStudio.TestTools.UnitTesting;
using NackaBoatRentals.Helpers;

namespace TestDrivenDevelopment_UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestHoursA()
        {
            //Arrange
            int rentMinutes = 123;
            
            //123 minutes is equivalent to 2hours 3 minutes which according to the requirements should be considered 3 hours
            int expected = 3;

           //Act
            int actual = CostCalculationsHelper.TotalHours(rentMinutes);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestHoursB()
        {
            //Arrange
            int rentMinutes = 23;
            //0 hour 23 minutes according to the requirements should be considered 1 hour
            int expected = 1;

            //Act
            int actual = CostCalculationsHelper.TotalHours(rentMinutes);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestHoursC()
        {
            //Arrange
            int rentMinutes = 500;

            //8 hours 20minutes according to the requirements should be considered 9 hours
            int expected = 9;

            //Act
            int actual = CostCalculationsHelper.TotalHours(rentMinutes);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestHoursD()
        {
            //Arrange
            int rentMinutes = 700;

            //11 hours 20minutes according to the requirements should be considered 12 hours
            int expected = 12;

            //Act
            int actual = CostCalculationsHelper.TotalHours(rentMinutes);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestHoursE()
        {
            //Arrange
            int rentMinutes = 60;

            //1 hours 0minutes according to the requirements should be considered 1 hour
            int expected = 1;

            //Act
            int actual = CostCalculationsHelper.TotalHours(rentMinutes);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestHoursF()
        {
            //Arrange
            int rentMinutes = 180;

            //3 hours 0minutes according to the requirements should be considered 3 hour
            int expected = 3;

            //Act
            int actual = CostCalculationsHelper.TotalHours(rentMinutes);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestHoursG()
        {
            //Arrange
            int rentMinutes = 5;

            //0 hours 5minutes according to the requirements should be considered 1 hour
            int expected = 1;

            //Act
            int actual = CostCalculationsHelper.TotalHours(rentMinutes);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void BoatTestA()
        {
            //Arrange
            string boatCategoryA= "jolly-boat";
            int totminsA = 123;
            int expectedA = 80;

            //Act
            int actualA = CostCalculationsHelper.TotalCost(boatCategoryA, totminsA);

            //Assert
            Assert.AreEqual(expectedA, actualA);

        }
        [TestMethod]
        public void BoatTestB()
        {
            //Arrange
            string boatCategoryB = "< 40 feet";
            int totminsB = 140;
            int expectedB = 99;

            //Act
            int actualB = CostCalculationsHelper.TotalCost(boatCategoryB, totminsB);

            //Assert
            Assert.AreEqual(expectedB, actualB);
        }
        [TestMethod]
        public void BoatTestC()
        {
            //Arrange
            string boatCategoryC = ">= 40 feet";
            int totminsC = 130;
            int expectedC = 117;

            //Act
            int actualC = CostCalculationsHelper.TotalCost(boatCategoryC, totminsC);

            //Assert
            Assert.AreEqual(expectedC, actualC);
        }
        [TestMethod]
        public void BoatTestD()
        {
            //Arrange
            string boatCategoryD = "jolly-boat";
            int totminsD = 23;
            int expectedD = 60;

            //Act
            int actualD = CostCalculationsHelper.TotalCost(boatCategoryD, totminsD);

            //Assert
            Assert.AreEqual(expectedD, actualD);

        }
        [TestMethod]
        public void BoatTestE()
        {
            //Arrange
            string boatCategoryE = "< 40 feet";
            int totminsE = 500;
            int expectedE =177;

            //Act
            int actualE = CostCalculationsHelper.TotalCost(boatCategoryE, totminsE);

            //Assert
            Assert.AreEqual(expectedE, actualE);

        }
        [TestMethod]
        public void BoatTestF()
        {
            //Arrange
            string boatCategoryF = ">= 40 feet";
            int totminsF = 1000;
            int expectedF = 313;

            //Act
            int actualF = CostCalculationsHelper.TotalCost(boatCategoryF, totminsF);

            //Assert
            Assert.AreEqual(expectedF, actualF);

        }
        [TestMethod]
        public void BoatTestG()
        {
            //Arrange
            string boatCategoryF = "jolly-boat";
            int totminsF = 60;
            int expectedF = 60;

            //Act
            int actualF = CostCalculationsHelper.TotalCost(boatCategoryF, totminsF);

            //Assert
            Assert.AreEqual(expectedF, actualF);

        }
    }
}
