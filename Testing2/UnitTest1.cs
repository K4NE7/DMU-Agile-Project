using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingOrders
{
    [TestClass]
    public class tstOrders
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrders anOrder = new clsOrders();

            Assert.IsNotNull(anOrder);
        }

        [TestMethod]
        public void IdOrderOk()
        {
            clsOrders anOrder = new clsOrders();

            int testData = 1;

            anOrder.orderID = testData;

            Assert.AreEqual(anOrder.orderID, testData);
        }

        [TestMethod]
        public void customerIdOrderOk()
        {
            clsOrders anOrder = new clsOrders();

            int testData = 5;

            anOrder.customerID = testData;

            Assert.AreEqual(anOrder.customerID, testData);
        }

        [TestMethod]
        public void orderDateOrderOk()
        {
            clsOrders anOrder = new clsOrders();

            DateTime testData = DateTime.Now.Date;

            anOrder.orderDate = testData;

            Assert.AreEqual(anOrder.orderDate, testData);
        }

        [TestMethod]
        public void keySentOrderOk()
        {
            clsOrders anOrder = new clsOrders();

            Boolean testData = true;

            anOrder.keySent = testData;

            Assert.AreEqual(anOrder.keySent, testData);
        }

        [TestMethod]
        public void extraDetailsOrderOk()
        {
            clsOrders anOrder = new clsOrders();

            String testData = "Steam";

            anOrder.extraDetails = testData;

            Assert.AreEqual(anOrder.extraDetails, testData);
        }

        [TestMethod]
        public void staffIdOrderOk()
        {
            clsOrders anOrder = new clsOrders();

            int testData = 1;

            anOrder.staffID = testData;

            Assert.AreEqual(anOrder.staffID, testData);
        }

    }
}
