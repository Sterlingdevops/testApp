using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for AdminService
/// </summary>
public class AdminService
{
	public AdminService()
	{
	
	}


    public Boolean isAdmin(string username){

        DataSet ds = findAdminUser(username);

        if (ds.Tables[0].Rows.Count > 0)
            return true;
        else
            return false;
                 

    }
    public DataSet findAdminUser(string username) {
        
        Admin admin = new Admin();
        admin.setUserName(username);
        Connect cc = addParameter(admin);
        cc.addparam("opCode","2");
        return cc.query("admin");
    
    }
    public int createAdminUser(string username,string addedBy)
    {

        Admin admin = new Admin();
        admin.setUserName(username);
        admin.setStatus(1);
        admin.setAddedBy(addedBy);
        Connect cc = addParameter(admin);
        cc.addparam("opCode", "3");        

        DataSet ds = cc.query("user");
        string k = "0";
        if (ds.Tables[0].Rows.Count > 0)
        {
            k = (ds.Tables[0].Rows[0]["id"].ToString());
        }

        return Convert.ToInt32(k);

    }

    public void disAbleAdminUser(string username) {
        Admin admin = new Admin();
        admin.setUserName(username);
        Connect cc = addParameter(admin);
        cc.addparam("opCode", "4");
        cc.query();
        
    }

    public void setLogOnDate(string username) { 
    
    }

    public DataSet findAllAdmin() {
        Admin admin = new Admin();
        Connect cc = addParameter(admin);
        cc.addparam("opCode", "1");
        return cc.query("admin");
    }
         

    public Connect addParameter(Admin admin) {

        Connect conn = new Connect("spd_AdministratorService");
        
        if (admin.getUserName() == null || admin.getUserName() == "")
           admin.setUserName("");               
        conn.addparam("username",admin.getUserName());

        if (admin.getAddedBy() == null || admin.getAddedBy() == "")
            admin.setAddedBy("");
        conn.addparam("addedBy", admin.getAddedBy());

        if (admin.getStatus() == 0)
            admin.setStatus(0);
        conn.addparam("status",admin.getStatus());

        return conn;

    }

    public Boolean checkExistingUser(string username)
    {
        Admin ad=new Admin();
        ad.setUserName(username);
        Connect conn = addParameter(ad);
        conn.addparam("opCode", "2");
        DataSet ds = conn.query("admin");
        if (ds.Tables[0].Rows.Count > 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
