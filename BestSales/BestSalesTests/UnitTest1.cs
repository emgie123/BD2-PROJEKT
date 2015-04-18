using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BestSales.Models.DbInsert;
using BestSales;
namespace BestSalesTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RandomCarGenerator generator = new RandomCarGenerator();

            generator.InsertRandomCar();
        }
    }
}
