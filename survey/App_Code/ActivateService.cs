using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public class ActivateService
{
    public bool Activestate()
    {
        Connect c = new Connect("spd_GetActivestate");
        DataSet ds = c.query("statusflag");

        Activate a = new Activate();
       bool rr= Convert.ToBoolean(ds.Tables[0].Rows[0]["statusflag"].ToString());

        return rr;
    }


}
