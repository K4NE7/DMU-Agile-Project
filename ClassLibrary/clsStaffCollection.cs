using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> staffMembers = new List<clsStaff>();
        clsStaff staff = new clsStaff();

        // Constructor
        public clsStaffCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");

            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsStaff staffMember = new clsStaff();

                staffMember.staffId = Convert.ToInt32(DB.DataTable.Rows[Index]["staffID"]);
                staffMember.staffFullName = Convert.ToString(DB.DataTable.Rows[Index]["staffFullName"]);
                staffMember.staffEmail = Convert.ToString(DB.DataTable.Rows[Index]["staffEmail"]);
                staffMember.staffPassword = Convert.ToString(DB.DataTable.Rows[Index]["staffPassword"]);
                staffMember.staffDOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["staffDOB"]);
                staffMember.staffSalary = Convert.ToDouble(DB.DataTable.Rows[Index]["staffSalary"]);
                staffMember.administrator = Convert.ToBoolean(DB.DataTable.Rows[Index]["administrator"]);

                staffMembers.Add(staffMember);
                Index++;
            }
        }

        public List<clsStaff> staffList
        {
            get { return staffMembers; }
            set { staffMembers = value; }
        }
        public int Count
        {
            get { return staffMembers.Count; }
            set { }
        }
        public clsStaff ThisStaffMember
        {
            get
            {
                return staff;
            }
            set
            {
                staff = value;
            }
        }

       

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@staffFullName", staff.staffFullName);
            DB.AddParameter("@staffEmail", staff.staffEmail);
            DB.AddParameter("@staffPassword", staff.staffPassword);
            DB.AddParameter("@staffDOB", staff.staffDOB);
            DB.AddParameter("@staffSalary", staff.staffSalary);
            DB.AddParameter("@administrator", staff.administrator);

            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@staffId", staff.staffId);
            DB.AddParameter("@staffFullName", staff.staffFullName);
            DB.AddParameter("@staffEmail", staff.staffEmail);
            DB.AddParameter("@staffPassword", staff.staffPassword);
            DB.AddParameter("@staffDOB", staff.staffDOB);
            DB.AddParameter("@staffSalary", staff.staffSalary);
            DB.AddParameter("@administrator", staff.administrator);

            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StaffID", staff.staffId);
            DB.Execute("sproc_tblStaff_Delete");
        }
    }
}