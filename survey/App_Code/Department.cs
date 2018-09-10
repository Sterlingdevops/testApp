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
/// Summary description for Department
/// </summary>
public class Department
{


    private int deptId;
    private string deptName;
    private int compulsory;

    public string getDeptName() {
        return this.deptName;
    }
    public void setDeptName(string deptName) {
        this.deptName = deptName;
    }

    public int getCompulsory() {
        return this.compulsory;
    }
    public void setCompulsory(int compulsory) {
        this.compulsory = compulsory;
    }

    public int getDeptId() {

        return this.deptId;
    }

    public void setDeptId(int deptId){
        this.deptId = deptId;
    }
	public Department()
	{

	}
}
