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

    [TestClass]
    public class TstStaffValid
    {
        // Test data which should pass regardless
        private string staffFullName = "Oscar Soanes";
        private string staffEmail = "oscarsoanes@kores.co.uk";
        private string staffPassword = "password123";
        private string staffDOB = "15/01/2002";
        private string staffSalary = "12345.67";

        // Testing data for staff full name
        [TestMethod]
        public void StaffFullNameMinLessOne()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";
            string staffFullName = "";

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffFullNameMin()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";
            string staffFullName = "O";

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffFullNamePlusOne()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";
            string staffFullName = "Os";

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffFullNameMaxLessOne()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";
            string staffFullName = "";
            staffFullName = staffFullName.PadRight(69, 'O');

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffFullNameMax()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";
            string staffFullName = "";
            staffFullName = staffFullName.PadRight(70, 'O');

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffFullNameMaxPlusOne()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";
            string staffFullName = "";
            staffFullName = staffFullName.PadRight(71, 'O');

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffFullNameMid()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";
            string staffFullName = "";
            staffFullName = staffFullName.PadRight(35, 'O');

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffFullNameExtreme()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";
            string staffFullName = "";
            staffFullName = staffFullName.PadRight(500, 'O');

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreNotEqual(error, "");
        }

        // testing data for staffDOB
        [TestMethod]
        public void StaffDateOfBirthMinLessOne()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";
            
            // Creating the test date
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-120).AddDays(-1);

            string staffDOB = TestDate.ToString();

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffDateOfBirthMinExtreme()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";

            // Creating the test date
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-500);

            string staffDOB = TestDate.ToString();

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void StaffDateOfBirthMin()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";

            // Creating the test date
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-120);

            string staffDOB = TestDate.ToString();

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffDateOfBirthMaxPlusOne()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";

            // Creating the test date
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-12).AddDays(1);

            string staffDOB = TestDate.ToString();

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffDateOfBirthMaxExtreme()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";

            // Creating the test date
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(500);

            string staffDOB = TestDate.ToString();

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffDateOfBirthMaxLessOne()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";

            // Creating the test date
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-12).AddDays(-1);

            string staffDOB = TestDate.ToString();

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffDateOfBirthMax()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";

            // Creating the test date
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-12);

            string staffDOB = TestDate.ToString(); 

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffDateOfBirthInvalid()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";

            // Creating the test date
            string staffDOB = "I am not a date";

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreNotEqual(error, "");
        }

        // Testing data for staff email
        [TestMethod]
        public void StaffEmailMinLessOne()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";
            string staffEmail = "os@kores.co.uk";

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffEmailMin()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";
            string staffEmail = "oso@kores.co.uk";

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffEmailPlusOne()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";
            string staffEmail = "osso@kores.co.uk";

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffEmailMaxLessOne()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";
            string staffEmail = "";
            staffEmail = staffEmail.PadRight(89, 'O');

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffEmailMax()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";
            string staffEmail = "";
            staffEmail = staffEmail.PadRight(90, 'O');

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffEmailMaxPlusOne()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";
            string staffEmail = "";
            staffEmail = staffEmail.PadRight(91, 'O');

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffEmailMid()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";
            string staffEmail = "";
            staffEmail = staffEmail.PadRight(45, 'O');

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffEmailExtreme()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";
            string staffEmail = "";
            staffEmail = staffEmail.PadRight(500, 'O');

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreNotEqual(error, "");
        }

        // Testing data for staff email
        [TestMethod]
        public void StaffPasswordMinLessOne()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";
            string staffPassword = "passwor";

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffPasswordMin()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";
            string staffPassword = "password";

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffPasswordPlusOne()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";
            string staffPassword = "password1";

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffPasswordMaxLessOne()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";
            string staffPassword = "";
            staffPassword = staffPassword.PadRight(49, 'O');

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffPasswordMax()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";
            string staffPassword = "";
            staffPassword = staffPassword.PadRight(50, 'O');

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffPasswordMaxPlusOne()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";
            string staffPassword = "";
            staffPassword = staffPassword.PadRight(51, 'O');

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffPasswordMid()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";
            string staffPassword = "";
            staffPassword = staffPassword.PadRight(25, 'O');

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffPasswordExtreme()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";
            string staffPassword = "";
            staffPassword = staffPassword.PadRight(300, 'O');

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreNotEqual(error, "");
        }

        // testing data for staffSalary
        [TestMethod]
        public void StaffSalaryMinLessOne()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";
            string staffSalary = "-0.01";
            

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffSalaryMinExtreme()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";
            string staffSalary = "-29847.37";

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void StaffSalaryMin()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";
            string staffSalary = "0.00";

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffSalaryInvalid()
        {
            // Creating instance of class & variables
            clsStaff staffMember = new clsStaff();
            string error = "";
            string staffSalary = "I am not a date";

            // testing new data above & original test data
            error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
            Assert.AreNotEqual(error, "");
        }
    }
}
