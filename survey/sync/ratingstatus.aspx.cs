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

public partial class sync_managerating : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int Refid = Convert.ToInt16(Request.Params["Refid"]);
        Connect cn = new Connect("spd_ToggleRATINGStatus");
        cn.addparam("@Refid", Refid);
        DataSet ds = cn.query("oldstatus");

        Response.Write(ds.Tables[0].Rows[0]["oldstatus"].ToString());
    }
}
