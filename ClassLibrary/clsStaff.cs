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

            // check if a record is found (only can be 1 or 0)

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
    }
}