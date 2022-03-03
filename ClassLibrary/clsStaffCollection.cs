using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> staffMembers = new List<clsStaff>();

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
        public clsStaff ThisStaffMember { get; set; }
    }
}