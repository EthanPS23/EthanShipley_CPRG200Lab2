using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData.Tests
{
    // test that the residential calcs are correct
    [TestClass()]
    public class CustomerTests1
    {
        [TestMethod()]
        public void CalculateChargeTest()
        {
            //Arrange
            int kwh = 0;
            decimal expectedChrg = 6.00m;
            //create the customer c
            CustomerData.Customer c = new CustomerData.Customer('R', "unknown", 0);
            //calculate the charge
            decimal actualChrg = c.CalculateCharge(kwh);
            //Asssert
            Assert.AreEqual(actualChrg, expectedChrg);
        }
    }
    // test that the residential calcs are correct
    [TestClass()]
    public class CustomerTests2
    {
        [TestMethod()]
        public void CalculateChargeTest()
        {
            //Arrange
            int kwh = 1001;
            decimal expectedChrg = 58.052m;
            //create the customer c
            CustomerData.Customer c = new CustomerData.Customer('R', "unknown", 0);
            //calculate the charge
            decimal actualChrg = c.CalculateCharge(kwh);
            //Asssert
            Assert.AreEqual(actualChrg, expectedChrg);
        }
    }

    // test that the commercial calcs are correct
    [TestClass()]
    public class CustomerTests3
    {
        [TestMethod()]
        public void CalculateChargeTest()
        {
            //Arrange
            int kwh = 0;
            decimal expectedChrg = 60.00m;
            //create the customer c
            CustomerData.Customer c = new CustomerData.Customer('C', "unknown", 0);
            //calculate the charge
            decimal actualChrg = c.CalculateCharge(kwh);
            //Asssert
            Assert.AreEqual(actualChrg, expectedChrg);
        }
    }
    // test that the commercial calcs are correct
    [TestClass()]
    public class CustomerTests4
    {
        [TestMethod()]
        public void CalculateChargeTest()
        {
            //Arrange
            int kwh = 1001;
            decimal expectedChrg = 60.045m;
            //create the customer c
            CustomerData.Customer c = new CustomerData.Customer('C', "unknown", 0);
            //calculate the charge
            decimal actualChrg = c.CalculateCharge(kwh);
            //Asssert
            Assert.AreEqual(actualChrg, expectedChrg);
        }
    }

    // test that the industrial calcs are correct
    [TestClass()]
    public class CustomerTests5
    {
        [TestMethod()]
        public void CalculateChargeTest()
        {
            //Arrange
            int kwh = 0;
            int kwh_OffPk = 0;
            decimal expectedChrg = 116.00m;
            //create the customer c
            CustomerData.Customer c = new CustomerData.Customer('I', "unknown", 0);
            //calculate the charge
            decimal actualChrg = c.CalculateCharge(kwh, kwh_OffPk);
            //Asssert
            Assert.AreEqual(actualChrg, expectedChrg);
        }
    }
    // test that the industrial calcs are correct
    [TestClass()]
    public class CustomerTests6
    {
        [TestMethod()]
        public void CalculateChargeTest()
        {
            //Arrange
            int kwh = 1001;
            int kwh_OffPk = 1001;
            decimal expectedChrg = 116.093m;
            //create the customer c
            CustomerData.Customer c = new CustomerData.Customer('I', "unknown", 0);
            //calculate the charge
            decimal actualChrg = c.CalculateCharge(kwh, kwh_OffPk);
            //Asssert
            Assert.AreEqual(actualChrg, expectedChrg);
        }
    }
}