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

public partial class compulsory : System.Web.UI.Page
{
    string k;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            ibox.msg = "";
            //********************************* Begin Knowledge dropdown ************
            ddlknowledge.Items.Add(new ListItem("- Select One -", "-1"));
            Scoreservice s = new Scoreservice();
            DataSet ds = s.getRatingScore();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string scoreval = ds.Tables[0].Rows[i]["Score"].ToString();
                string scorename = ds.Tables[0].Rows[i]["point"].ToString();
                //Response.Write(dept);
                ddlknowledge.Items.Add(new ListItem(scorename, scoreval));
                ddlhelpful.Items.Add(new ListItem(scorename, scoreval));
                ddlcourteous.Items.Add(new ListItem(scorename, scoreval));
                ddlresponsesive.Items.Add(new ListItem(scorename, scoreval));
                ddltimeliness.Items.Add(new ListItem(scorename, scoreval));
                ddlease.Items.Add(new ListItem(scorename, scoreval));
                ddlclarify.Items.Add(new ListItem(scorename, scoreval));
                ddlcontent.Items.Add(new ListItem(scorename, scoreval));
                ddlaccess.Items.Add(new ListItem(scorename, scoreval));
                ddloverall.Items.Add(new ListItem(scorename, scoreval));
            }
        }
        catch (Exception ex)
        {
            ErrorLog err = new ErrorLog(ex);
        }
    }
}
