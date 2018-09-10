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
/// Summary description for DepartmentService
/// </summary>
public class DepartmentService
{
	public DepartmentService()
	{
		
	}

    public DataSet findAllDepts() {

        Department dept = new Department();
        Connect cc = addParamemeters(dept);
        cc.addparam("opCode","1");
        DataSet ds = cc.query("depts");
        return ds;

    }

    public DataSet findCompulsoryDepts(string deptName) {

        Connect cc = new Connect("spSurvey_findCompulsoryDepts");
        return cc.query("depts");
    }
    public DataSet findOptionalDepts(string deptName)
    {

        Connect cc = new Connect("spd_DepartmentService");
        return cc.query("depts");
    }


    public DataSet getAllPossibleDepts(string deptName) {

        new ErrorLog("Department Sent :"+deptName);
        Department dept = new Department();
        dept.setDeptName(deptName);
       
        Connect conn = addParamemeters(dept);
        conn.addparam("opCode","1");
       

        return conn.query("depts");
    }

    protected Connect addParamemeters(Department dept) {

        Connect conn = new Connect("spd_DepartmentService");
        
        conn.addparam("deptName", dept.getDeptName());
        return conn;

    
    }

    public DataSet getAllDeptIRated(string username)
    {
        Connect c = new Connect("spd_ViewdeptRated");
        c.addparam("username", username);
        DataSet ds = c.query("depts");
        return ds;
    }


   
}
