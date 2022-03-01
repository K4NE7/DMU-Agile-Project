using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class TstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create instance of Staff
            clsStaff staffMember = new clsStaff();
            
            Assert.IsNotNull(staffMember);
        }

        [TestMethod]
        public void AdministratorStaffOK()
        {
            // Create instance of Staff
            clsStaff staffMember = new clsStaff();

            Boolean TestData = true;
            // Assign TestData to property
            staffMember.administrator = TestData;

            Assert.AreEqual(staffMember.administrator, TestData);
        }

        [TestMethod]
        public void DOBStaffOK()
        {
            // Create instance of Staff
            clsStaff staffMember = new clsStaff();

            DateTime TestData = DateTime.Now.AddDays(-5840);
            // Assign TestData to property
            staffMember.staffDOB = TestData;

            Assert.AreEqual(staffMember.staffDOB, TestData);

        }

        [TestMethod]
        public void FullNameStaffOK()
        {
            // Create instance of Staff
            clsStaff staffMember = new clsStaff();

            string TestData = "John Smith";
            // Assign TestData to property
            staffMember.staffFullName = TestData;

            Assert.AreEqual(staffMember.staffFullName, TestData);
        }

        [TestMethod]
        public void EmailStaffOK()
        {
            // Create instance of Staff
            clsStaff staffMember = new clsStaff();

            string TestData = "johnsmith@kores.co.uk";
            // Assign TestData to property
            staffMember.staffEmail = TestData;

            Assert.AreEqual(staffMember.staffEmail, TestData);
        }

        [TestMethod]
        public void PasswordStaffOK()
        {
            // Create instance of Staff
            clsStaff staffMember = new clsStaff();

            string TestData = "password123";
            // Assign TestData to property
            staffMember.staffPassword = TestData;

            Assert.AreEqual(staffMember.staffPassword, TestData);
        }

        [TestMethod]
        public void SalaryStaffOK()
        {
            // Create instance of Staff
            clsStaff staffMember = new clsStaff();

            double TestData = 1999.99;
            // Assign TestData to property
            staffMember.staffSalary = TestData;

            Assert.AreEqual(staffMember.staffSalary, TestData);
        }

        [TestMethod]
        public void IDStaffOK()
        {
            // Create instance of Staff
            clsStaff staffMember = new clsStaff();

            int TestData = 1;
            // Assign TestData to property
            staffMember.staffId = TestData;

            Assert.AreEqual(staffMember.staffId, TestData);
        }
    }

    [TestClass]
    public class TstStaffFind
    {
        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff staffMember = new clsStaff();
            Boolean found = false;

            Int32 staffId = 10;

            found = staffMember.Find(staffId);

            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestStaffAdministratorFound()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 staffId = 10;

            found = staffMember.Find(staffId);

            // Checking if variable matches
            if (staffMember.administrator != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffDOBFound()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 staffId = 10;

            found = staffMember.Find(staffId);

            // Checking if variable matches
            if (staffMember.staffDOB != Convert.ToDateTime("15/01/2002"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffEmailFound()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 staffId = 10;

            found = staffMember.Find(staffId);

            // Checking if variable matches
            if (staffMember.staffEmail != "oscarsoanes@kores.co.uk")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffFullNameFound()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 staffId = 10;

            found = staffMember.Find(staffId);

            // Checking if variable matches
            if (staffMember.staffFullName != "Oscar Soanes")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 staffId = 10;

            found = staffMember.Find(staffId);

            // Checking if variable matches
            if (staffMember.staffId != 10)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffPasswordOK()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 staffId = 10;

            found = staffMember.Find(staffId);

            // Checking if variable matches
            if (staffMember.staffPassword != "I-h4te-sql")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffSalaryFound()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 staffId = 10;

            found = staffMember.Find(staffId);

            // Checking if variable matches
            if (staffMember.staffSalary != 1.99)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}
