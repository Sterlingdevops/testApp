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

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ibox.msg = "";
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        ibox.msg = "";
        //check if the Rating is still active
        ActivateService acs = new ActivateService();
        AdminService admin = new AdminService();
       
        string une = txtUne.Text.Trim();
        if (une == "")
        {
            ibox.css = false;
            ibox.msg = "Enter your username";
            return;
        }

        if (txtPwd.Text == "")
        {
            ibox.css = false;
            ibox.msg = "Enter your password";
            return;
        }

        bool stat = admin.isAdmin(txtUne.Text);

        if (!acs.Activestate() && !stat)//if rating is closed and the user is not admin
        {
            ibox.msg = "Sorry Rating has been closed by the Administrator.";
            ibox.css = false;
            return;
        }
        StaffService ss = new StaffService();

        try
        {
            if (ss.login(une, txtPwd.Text))
            {
                //get staff department
                Staff st = ss.getUserDetails(une);

                //ensure temp staff are not able to logon
                if (st.description == "Temp")
                {
                    ibox.css = false;
                    ibox.msg = "Sorry, Temporary staffs are not allowed on this platform.";
                    return;
                }

                Session["username"] = une;
                Session["fullname"] =st.fullName;
               
                Session["deptname"] = st.deptName;           
                Rating r = new Rating();
                RatingService rs = new RatingService();

                string username=Session["username"].ToString();
                Session["currUser"] = une;
                Response.Redirect("myprofile.aspx");
            }
            else
            {
                ibox.css = false;
                ibox.msg = ss.err;
            }
           
        }
        catch (Exception ex)
        {
            ErrorLog err = new ErrorLog(ex);
        }
    }
}
