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

}
