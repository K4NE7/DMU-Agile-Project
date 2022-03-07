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
            // create instance of DB connection
            clsDataConnection DB = new clsDataConnection();

            // check for the staff member to search for and excute stored procedure
            DB.AddParameter("@staffID", staffId);
            DB.Execute("sproc_tblStaff_FilterByStaffID");

            // check if a record is found (should only be 1 or 0)

            if (DB.Count == 1)
            {
                privStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                privStaffFullName = Convert.ToString(DB.DataTable.Rows[0]["StaffFullName"]);
                privStaffEmail = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                privStaffPassword = Convert.ToString(DB.DataTable.Rows[0]["StaffPassword"]);
                privStaffDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffDOB"]);
                privStaffSalary = Convert.ToDouble(DB.DataTable.Rows[0]["StaffSalary"]);
                privAdministrator = Convert.ToBoolean(DB.DataTable.Rows[0]["Administrator"]);

                return true;
            }

            // nothing was found
            else
            {
                return false;
            }
        }

        public string Valid(string fullName, string email, string password, string dateOfBirth, string salary)
        {
            String Error = "";
            DateTime DateTemp;
            Double SalaryTemp;

            // Testing full name
            if (fullName.Length == 0)
            {
                Error = Error + "The staff fullname must not be blank : ";
            }
            if (fullName.Length > 70)
            {
                Error = Error + "The staff fullname must be less than 70 characters : ";
            }

            // Testing email
            if (email.Length > 90)
            {
                Error = Error + "The staff email must be less than 90 characters : ";
            }
            if (email.Length < 15)
            {
                Error = Error + "The staff email is too small to be valid : ";
            }

            // Testing password
            if (password.Length > 50)
            {
                Error = Error + "The staff password must be less than 50 characters : ";
            }
            if (password.Length < 8)
            {
                Error = Error + "The staff password is too small to be valid : ";
            }
            
            // Testing date of birth
            try
            {
                DateTemp = Convert.ToDateTime(dateOfBirth);
                if (DateTemp < DateTime.Now.Date.AddYears(-120))
                {
                    Error = Error + "The staff date of birth exceeds the maximum limit (120 years ago) : ";
                }
                if (DateTemp > DateTime.Now.Date.AddYears(-12))
                {
                    Error = Error + "The staff date of birth exceeds the minimum limit (12 years ago) : ";
                }
            } catch {
                Error = Error + "The date was not a valid date : ";
            }

            // Testing salary
            try
            {
                SalaryTemp = Convert.ToDouble(salary);
                if (SalaryTemp < 0)
                {
                    Error = Error + "The salary cannot be negative : ";
                }
            } catch {
                Error = Error + "The salary was not a valid number : ";
            }



            return Error;
        }

    }

}