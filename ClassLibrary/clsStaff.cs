using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private bool privAdministrator;
        private DateTime privStaffDOB;
        private Double privStaffSalary;
        private String privStaffFullName;
        private String privStaffEmail;
        private String privStaffPassword;
        private int privStaffID;



        public bool administrator
        {
            get { return privAdministrator; }
            set { privAdministrator = value; }
        }
        public DateTime staffDOB
        {
            get { return privStaffDOB; }
            set { privStaffDOB = value; }
        }
        public string staffFullName
        {
            get { return privStaffFullName;  }
            set { privStaffFullName = value; }
        }
        public string staffEmail
        {
            get { return privStaffEmail; }
            set { privStaffEmail = value; } 
        }
        public string staffPassword
        {
            get { return privStaffPassword; }
            set { privStaffPassword = value; }
        }
        
        public double staffSalary
        {
            get { return privStaffSalary; }
            set { privStaffSalary = value; }
        }
        public int staffId
        {
            get { return privStaffID; }
            set { privStaffID = value; }
        }

        public bool Find(int staffId)
        {
            privAdministrator = true;
            privStaffDOB = Convert.ToDateTime("15/01/2002");
            privStaffEmail = "oscarsoanes@kores.co.uk";
            privStaffFullName = "Oscar Soanes";
            privStaffPassword = "I-h4te-sql";
            privStaffSalary = 1.99;
            privStaffID = 10;
            return true;
        }
    }
}