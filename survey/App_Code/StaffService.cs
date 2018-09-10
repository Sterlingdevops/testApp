using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Data;
using System.Configuration;
using System.Collections;

public class StaffService
{
    public string err;
    public Staff getUserDetails(string username)
    {
        ldap l = new ldap();
        return l.GetInfo(username);
    }

    public bool login(string username, string password)
    {
        ldap l = new ldap();
        if (l.login(username, password))
        {
            return true;
        }
        else
        {
            err = l.err;
            return false;
        }
    }

    public Staff[] searchStaff(string username)
    {
        Staff[] staffs;

        Connect cc = new Connect("spd_searchStaff");
        cc.addparam("username",username);
        DataSet ds = cc.query("staffs");
        int arraySize = ds.Tables["staffs"].Rows.Count;
        staffs = new Staff[arraySize];

        Staff staff = new Staff();

        for (int i = 0; i < ds.Tables["staffs"].Rows.Count; i++)
        {
            staff.accountStatus =(Convert.ToInt32(ds.Tables[0].Rows[i]["accountStatus"].ToString()));
            staff.cardnumber = ds.Tables[0].Rows[i]["cardnumber"].ToString();
           // staff.communicator = ds.Tables[0].Rows[i]["communicator"].ToString();
            staff.country = ds.Tables[0].Rows[i]["country"].ToString();
            staff.deptName = ds.Tables[0].Rows[i]["deptName"].ToString();
           // staff.email = ds.Tables[0].Rows[i]["email"].ToString();
           // staff.firstName = ds.Tables[0].Rows[i]["firstName"].ToString();
            //staff.fullName = ds.Tables[0].Rows[i]["fullName"].ToString();
            staff.gender = ds.Tables[0].Rows[i]["gender"].ToString();
            staff.grade = ds.Tables[0].Rows[i]["grade"].ToString();
          //  staff.jobTitle = ds.Tables[0].Rows[i]["jobTitle"].ToString();
           // staff.lastName = ds.Tables[0].Rows[i]["lastName"].ToString();
           // staff.mobile = ds.Tables[0].Rows[i]["mobile"].ToString();
            staff.mstatus = ds.Tables[0].Rows[i]["mstatus"].ToString();
            staff.officeLocation = ds.Tables[0].Rows[i]["officeLocation"].ToString();
            staff.region = ds.Tables[0].Rows[i]["region"].ToString();
            staff.stateName = ds.Tables[0].Rows[i]["state"].ToString();
            staff.unitName = ds.Tables[0].Rows[i]["unitName"].ToString();
            staff.userId = Convert.ToInt32(ds.Tables[0].Rows[i]["userId"].ToString());
            staff.username = ds.Tables[0].Rows[i]["username"].ToString();

            staffs[i] = staff;
        }
        return staffs;
    }

}
