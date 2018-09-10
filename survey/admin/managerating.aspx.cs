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

public partial class admin_managerating : System.Web.UI.Page
{
    public string getResultStatus(bool input,string Refid)
    {
        string k = "";
        try
        {
            if (input)
            {
                k += "&nbsp;<img id='result-" + Refid + "' alt='Active' src='../images/152.png' border='0' /> <a href='#' onclick='ResultStatus(" + Refid + ")'>Toggle</a>";
            }
            else
            {
                k += "&nbsp;<img id='result-" + Refid + "' alt='Disabled' src='../images/151.png' border='0' /> <a href='#' onclick='ResultStatus(" + Refid + ")'>Toggle</a>";
            }
        }
        catch (Exception ex)
        {
            ErrorLog err = new ErrorLog(ex);
        }
        return k;
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
