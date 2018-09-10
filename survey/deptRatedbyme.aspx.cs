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
public partial class deptRatedbyme : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ibox.msg = "";
        try
        {
         DepartmentService dsv = new DepartmentService();
         string username = Session["username"].ToString();
        }
        catch (Exception ex)
        {
         ErrorLog err = new ErrorLog(ex);
         Response.Redirect("logout.aspx");
        }
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ExportGridView();
    }
    private void ExportGridView()
    {
        string attachment = "attachment; filename=DeptRatedbyme_" + DateTime.Now.ToString() + ".xls";

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
