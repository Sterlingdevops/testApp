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
using System.Text;
using System.IO;
public partial class admin_Report : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (grddisplay.Rows.Count == 0)
        {

            lblmsg.Visible = true;
            lblmsg.Text = "No Record to display. The reason is that no department has been rated.  <br/><br/> Kindly Send mails to Staff to start rating departments.";
            Button1.Enabled = false;
            
        }
        else
        {
            lblmsg.Visible = false;
            Button1.Enabled = true;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //Export the GridView to Excel
        //PrepareGridViewForExport(grddisplay);
        ExportGridView();
    }
    private void ExportGridView()
    {
        string attachment = "attachment; filename=SurveyReport_" + DateTime.Now.ToString() + ".xls";

        Response.ClearContent();

        Response.AddHeader("content-disposition", attachment);

        Response.ContentType = "application/ms-excel";

        StringWriter sw = new StringWriter();

        HtmlTextWriter htw = new HtmlTextWriter(sw);

        grddisplay.RenderControl(htw);
        //Response.Write(style);

        Response.Write(sw.ToString());

        Response.End();

    }
    public override void VerifyRenderingInServerForm(Control control)
    {

    }
}
