using System;
using System.Data;
using System.Data.SqlClient;
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
public partial class admin_cSuccess : System.Web.UI.Page
{
    string rsp;
    SqlConnection conn;
    SqlCommand cmd;
    SqlDataReader dr;
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
    //staff
    public string getStaff(string deptrated)
    {
        try
        {
            rsp = "";
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString);
            string sql = "select cs,deptrated,criticalsuccess from vw_getCriticalSuccess WHERE criticalsuccess = 'Staff' and deptrated=@deptrated";

            cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 0;
            conn.Open();

            cmd.Parameters.Add("@deptrated", SqlDbType.VarChar, 200);

            cmd.Parameters["@deptrated"].Value = deptrated;

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                rsp = Convert.ToString(dr["cs"]);
            }
            else
            {
                rsp = "0";
            }


        }
        catch (Exception ex)
        {
            new ErrorLog(ex);
        }
        return rsp;
    }
    //Leadership
    public string getLeadership(string deptrated)
    {
        try
        {
            rsp = "";
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString);
            string sql = "select cs,deptrated,criticalsuccess from vw_getCriticalSuccess WHERE criticalsuccess = 'Leadership' and deptrated=@deptrated";

            cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 0;
            conn.Open();

            cmd.Parameters.Add("@deptrated", SqlDbType.VarChar, 200);

            cmd.Parameters["@deptrated"].Value = deptrated;

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                rsp = Convert.ToString(dr["cs"]);
            }
            else
            {
                rsp = "0";
            }


        }
        catch (Exception ex)
        {
            new ErrorLog(ex);
        }
        return rsp;
    }
    //Infrastructure
    public string getInfrastructure(string deptrated)
    {
        try
        {
            rsp = "";
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString);
            string sql = "select cs,deptrated,criticalsuccess from vw_getCriticalSuccess WHERE criticalsuccess = 'Infrastructure' and deptrated=@deptrated";

            cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 0;
            conn.Open();

            cmd.Parameters.Add("@deptrated", SqlDbType.VarChar, 200);

            cmd.Parameters["@deptrated"].Value = deptrated;

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                rsp = Convert.ToString(dr["cs"]);
            }
            else
            {
                rsp = "0";
            }


        }
        catch (Exception ex)
        {
            new ErrorLog(ex);
        }
        return rsp;
    }
    //Automation
    public string getAutomation(string deptrated)
    {
        try
        {
            rsp = "";
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString);
            string sql = "select cs,deptrated,criticalsuccess from vw_getCriticalSuccess WHERE criticalsuccess = 'Automation' and deptrated=@deptrated";

            cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 0;
            conn.Open();

            cmd.Parameters.Add("@deptrated", SqlDbType.VarChar, 200);

            cmd.Parameters["@deptrated"].Value = deptrated;

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                rsp = Convert.ToString(dr["cs"]);
            }
            else
            {
                rsp = "0";
            }


        }
        catch (Exception ex)
        {
            new ErrorLog(ex);
        }
        return rsp;
    }
    //Discipline
    public string getDiscipline(string deptrated)
    {
        try
        {
            rsp = "";
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString);
            string sql = "select cs,deptrated,criticalsuccess from vw_getCriticalSuccess WHERE criticalsuccess = 'Discipline' and deptrated=@deptrated";

            cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 0;
            conn.Open();

            cmd.Parameters.Add("@deptrated", SqlDbType.VarChar, 200);

            cmd.Parameters["@deptrated"].Value = deptrated;

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                rsp = Convert.ToString(dr["cs"]);
            }
            else
            {
                rsp = "0";
            }


        }
        catch (Exception ex)
        {
            new ErrorLog(ex);
        }
        return rsp;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ExportGridView();
    }
    private void ExportGridView()
    {
        string attachment = "attachment; filename=Key Success Factor Report_" + DateTime.Now.ToString() + ".xls";

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
