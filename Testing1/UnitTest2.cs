using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection allStaffMembers = new clsStaffCollection();

            Assert.IsNotNull(allStaffMembers);
        }

        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection clsStaffCollection = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();

            clsStaff TestItem = new clsStaff();
            TestItem.staffId = 1;
            TestItem.staffFullName = "Jane Smith";
            TestItem.staffSalary = 18712.11;
            TestItem.staffEmail = "janesmith@kores.co.uk";
            TestItem.staffPassword = "mypassword1";
            TestItem.staffDOB = DateTime.Now.Date.AddYears(-23);
            TestItem.administrator = false;

            TestList.Add(TestItem);

            clsStaffCollection.staffList = TestList;

            Assert.AreEqual(clsStaffCollection.staffList, TestList);
        }

        [TestMethod]
        public void ThisStaffMemberOK()
        {
            clsStaffCollection clsStaffCollection = new clsStaffCollection();
            clsStaff testStaffMember = new clsStaff();

            testStaffMember.staffId = 1;
            testStaffMember.staffFullName = "Bob Al";
            testStaffMember.staffEmail = "bobal@kores.co.uk";
            testStaffMember.staffPassword = "abcdefghijk";
            testStaffMember.staffSalary = 78213.11;
            testStaffMember.staffDOB = DateTime.Now.Date.AddYears(-53);
            testStaffMember.administrator = true;

            clsStaffCollection.ThisStaffMember = testStaffMember;

            Assert.AreEqual(clsStaffCollection.ThisStaffMember, testStaffMember);

        }

        public void ListAndCountOK()
        {
            clsStaffCollection clsStaffCollection = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff testStaffMember = new clsStaff();

            testStaffMember.staffId = 1;
            testStaffMember.staffFullName = "Bob Al";
            testStaffMember.staffEmail = "bobal@kores.co.uk";
            testStaffMember.staffPassword = "abcdefghijk";
            testStaffMember.staffSalary = 78213.11;
            testStaffMember.staffDOB = DateTime.Now.Date.AddYears(-53);
            testStaffMember.administrator = true;

            TestList.Add(testStaffMember);
            clsStaffCollection.ThisStaffMember = testStaffMember;

            Assert.AreEqual(clsStaffCollection.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection clsStaffCollection = new clsStaffCollection();
            clsStaff staffMember = new clsStaff();
            Int32 PrimaryKey = 0;

            // Initial data
            staffMember.staffId = 1;
            staffMember.staffFullName = "Bob Al";
            staffMember.staffEmail = "bobal@kores.co.uk";
            staffMember.staffPassword = "abcdefghijk";
            staffMember.staffSalary = 78213.11;
            staffMember.staffDOB = DateTime.Now.Date.AddYears(-53);
            staffMember.administrator = true;

            // Adding record
            clsStaffCollection.ThisStaffMember = staffMember;
            PrimaryKey = clsStaffCollection.Add();

            staffMember.staffId = PrimaryKey;
            clsStaffCollection.ThisStaffMember.Find(PrimaryKey);

            Assert.AreEqual(clsStaffCollection.ThisStaffMember, staffMember);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStaffCollection clsStaffCollection = new clsStaffCollection();
            clsStaff staffMember = new clsStaff();

            // Initial data
            int PrimaryKey = 0;
            staffMember.staffId = 1;
            staffMember.staffFullName = "Bob Al";
            staffMember.staffEmail = "bobal@kores.co.uk";
            staffMember.staffPassword = "abcdefghijk";
            staffMember.staffSalary = 78213.11;
            staffMember.staffDOB = DateTime.Now.Date.AddYears(-53);
            staffMember.administrator = true;

            // Add record
            clsStaffCollection.ThisStaffMember = staffMember;
            PrimaryKey = clsStaffCollection.Add();
            staffMember.staffId = PrimaryKey;

            // Updated original data
            staffMember.staffId = 1;
            staffMember.staffFullName = "John Al";
            staffMember.staffEmail = "johnal@kores.co.uk";
            staffMember.staffPassword = "changedpassword";
            staffMember.staffSalary = 43921.11;
            staffMember.staffDOB = DateTime.Now.Date.AddYears(-53);
            staffMember.administrator = false;

            // Updating record by finding primary key
            clsStaffCollection.ThisStaffMember = staffMember;
            clsStaffCollection.Update();

            clsStaffCollection.ThisStaffMember.Find(PrimaryKey);

            Assert.AreEqual(clsStaffCollection.ThisStaffMember, staffMember);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStaffCollection clsStaffCollection = new clsStaffCollection();
            clsStaff staffMember = new clsStaff();

            Int32 PrimaryKey = 0;

            // Initial data
            staffMember.staffId = 1;
            staffMember.staffFullName = "Test Delete Record";
            staffMember.staffEmail = "testdelete@kores.co.uk";
            staffMember.staffPassword = "pleasedeleteme";
            staffMember.staffSalary = 404;
            staffMember.staffDOB = DateTime.Now.Date.AddYears(-34);
            staffMember.administrator = false;

            // Adding record
            clsStaffCollection.ThisStaffMember = staffMember;
            PrimaryKey = clsStaffCollection.Add();

            // Find record
            clsStaffCollection.ThisStaffMember.Find(PrimaryKey);

            // Deleting record
            clsStaffCollection.Delete();

            Boolean Found = clsStaffCollection.ThisStaffMember.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
    }
}
