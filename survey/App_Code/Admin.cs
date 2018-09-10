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
/// Summary description for Admin
/// </summary>
public class Admin
{

    private string username;
    private int status;
    private DateTime lastLogOn;
    private int id;
    private string addedBy;


    public string getAddedBy()
    {
        return this.addedBy;
    }

    public void setAddedBy(string addedBy)
    {

        this.addedBy = addedBy;

    }

    public string getUserName() {
        return this.username;
    }

    public void setUserName(string username) {

        this.username = username;

    }

    public int getStatus() {
        return this.status;
    }
    public void setStatus(int status){
        this.status = status;
   }


    public DateTime getLastLogOn() {
        return this.lastLogOn;
    }

    public void setLastLogOn(DateTime dt) {
        this.lastLogOn = dt;
    }

    public int getId() {

        return this.id;
       
    }

    public void setId(int id) {
        this.id = id;
    }
	public Admin()
	{
	}
}
