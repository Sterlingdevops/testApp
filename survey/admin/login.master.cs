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

public partial class login : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ActivateService acs = new ActivateService();
        AdminService admin = new AdminService();

        try
        {
            bool stat = admin.isAdmin(Session["username"].ToString());

            if (!stat)
            {
                Response.Redirect("../logout.aspx");
            }
        }
        catch (Exception ex)
        {
            ErrorLog err = new ErrorLog(ex);
            Response.Redirect("../logout.aspx");
        }
    }
}
