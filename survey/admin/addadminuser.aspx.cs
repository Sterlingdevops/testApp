using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class admin_addadminuser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ibox.msg = "";

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        try {

            if (txtUne.Text == "")
            {
                ibox.msg = "You must enter the system logon name of the user you want to create as an admin";
                ibox.css = false;
                return;
            }
            Admin ad = new Admin();
            AdminService ads = new AdminService();
            if (ads.checkExistingUser(txtUne.Text))
            {
                ibox.msg = "User " + txtUne.Text + " already exists on this plaform";
                ibox.css = false;
                return;

            }

            int c = ads.createAdminUser(txtUne.Text, Session["username"].ToString());

            if (c > 0)
            {
                ibox.msg = "The User " + txtUne.Text + " has been created successfully";
                ibox.css = true;
            }
            else
            {
                ibox.msg = "The User was not created successfully.  Kindly contact the administrator";
                ibox.css = false;
            }
        
        }
        catch(Exception ex){

            new ErrorLog(ex);
        
        }
    }
}
