using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class TstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create instance of Customer
            clsCustomer aCustomer = new clsCustomer();

            Assert.IsNotNull(aCustomer);
        }

        [TestMethod]
        public void AdministratorCustomerOK()
        {
            //Create instance of Customer
            clsCustomer aCustomer = new clsCustomer();

            Boolean TestData = true;
            //Assign TestData to property
            aCustomer.administrator = TestData;

            Assert.AreEqual(aCustomer.administrator, TestData);
        }

        [TestMethod]
        public void IDCustomerOK()
        {
            //Create instance of Customer
            clsCustomer aCustomer = new clsCustomer();

            int TestData = 1;
            //Assign TestData to property
            aCustomer.customerId = TestData;

            Assert.AreEqual(aCustomer.customerId, TestData);
        }

        [TestMethod]
        public void FullNameCustomerOK()
        {
            //Create instance of Customer
            clsCustomer aCustomer = new clsCustomer();

            string TestData = "john bloggs";
            //Assign TestData to property
            aCustomer.customerFullName = TestData;

            Assert.AreEqual(aCustomer.customerFullName, TestData);
        }

        [TestMethod]
        public void EmailCustomerOK()
        {
            //Create instance of Customer
            clsCustomer aCustomer = new clsCustomer();

            string TestData = "johnbloggs@kores.co.uk";
            //Assign TestData to property
            aCustomer.customerEmail = TestData;

            Assert.AreEqual(aCustomer.customerEmail, TestData);
        }

        [TestMethod]
        public void EmailVerifiedCustomerOK()
        {
            //Create instance of Customer
            clsCustomer aCustomer = new clsCustomer();

            Boolean TestData = true;
            //Assign TestData to property
            aCustomer.customerEmailVerified = TestData;

            Assert.AreEqual(aCustomer.customerEmailVerified, TestData);
        }

        [TestMethod]
        public void PasswordCustomerOK()
        {
            //Create instance of Customer
            clsCustomer aCustomer = new clsCustomer();

            string TestData = "password123";
            //Assign TestData to property
            aCustomer.customerPassword = TestData;

            Assert.AreEqual(aCustomer.customerPassword, TestData);
        }

        [TestMethod]
        public void DOBCustomerOK()
        {
            //Create instance of Customer
            clsCustomer aCustomer = new clsCustomer();

            DateTime TestData = DateTime.Now.AddDays(-5840);
            //Assign TestData to property
            aCustomer.customerDOB = TestData;

            Assert.AreEqual(aCustomer.customerDOB, TestData);
        }
    }

    [TestClass]
    public class TstCustomerFind
    {
        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean found = false;

            Int32 customerId = 10;

            found = aCustomer.Find(customerId);

            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestCustomerAdministratorFound()
        {
            //Creating instance of class & variables
            clsCustomer aCustomer = new clsCustomer();
            Boolean found = false;
            Boolean OK = true;
            Int32 customerId = 10;

            found = aCustomer.Find(customerId);

            if (aCustomer.administrator != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean found = false;
            Boolean OK = true;
            Int32 customerId = 10;

            found = aCustomer.Find(customerId);

            if (aCustomer.customerId != 10)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerFullNameFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean found = false;
            Boolean OK = true;
            Int32 customerId = 10;

            found = aCustomer.Find(customerId);

            if (aCustomer.customerFullName != "john bloggs")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerEmailFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean found = false;
            Boolean OK = true;
            Int32 customerId = 10;

            found = aCustomer.Find(customerId);

            if (aCustomer.customerEmail != "johnbloggs@kores.co.uk")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerEmailVerifiedFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean found = false;
            Boolean OK = true;
            Int32 customerId = 10;

            found = aCustomer.Find(customerId);

            if (aCustomer.customerEmailVerified != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerPasswordOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean found = false;
            Boolean OK = true;
            Int32 customerId = 10;

            found = aCustomer.Find(customerId);

            if (aCustomer.customerPassword != "password123")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerDOBFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean found = false;
            Boolean OK = true;
            Int32 customerId = 10;

            found = aCustomer.Find(customerId);

            if (aCustomer.customerDOB != Convert.ToDateTime("03/11/2000"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}
