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
            clsStaffCollection allStaffMembers = new clsStaffCollection();
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

            allStaffMembers.staffList = TestList;

            Assert.AreEqual(allStaffMembers.staffList, TestList);
        }

        [TestMethod]
        public void ThisStaffMemberOK()
        {
            clsStaffCollection staffList = new clsStaffCollection();
            clsStaff testStaffMember = new clsStaff();

            testStaffMember.staffId = 1;
            testStaffMember.staffFullName = "Bob Al";
            testStaffMember.staffEmail = "bobal@kores.co.uk";
            testStaffMember.staffPassword = "abcdefghijk";
            testStaffMember.staffSalary = 78213.11;
            testStaffMember.staffDOB = DateTime.Now.Date.AddYears(-53);
            testStaffMember.administrator = true;

            staffList.ThisStaffMember = testStaffMember;

            Assert.AreEqual(staffList.ThisStaffMember, testStaffMember);
            
        }

        public void ListAndCountOK()
        {
            clsStaffCollection staffList = new clsStaffCollection();
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
            staffList.ThisStaffMember = testStaffMember;

            Assert.AreEqual(staffList.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection staffList = new clsStaffCollection();
            clsStaff staffMember = new clsStaff();
            Int32 PrimaryKey = 0;

            staffMember.staffId = 1;
            staffMember.staffFullName = "Bob Al";
            staffMember.staffEmail = "bobal@kores.co.uk";
            staffMember.staffPassword = "abcdefghijk";
            staffMember.staffSalary = 78213.11;
            staffMember.staffDOB = DateTime.Now.Date.AddYears(-53);
            staffMember.administrator = true;

            staffList.ThisStaffMember = staffMember;
            PrimaryKey = staffList.Add();

            staffMember.staffId = PrimaryKey;
            staffList.ThisStaffMember.Find(PrimaryKey);

            Assert.AreEqual(staffList.ThisStaffMember, staffMember);
        }
    }
}
