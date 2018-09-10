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
public partial class admin_cattribute : System.Web.UI.Page
{
    SqlConnection conn;
    SqlCommand cmd;
    SqlDataReader dr;
    string rsp;
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
    //competence
    public string getCompetence(string deptrated)
    {
        try
        {
            rsp = "";
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString);
            string sql = "select ca,deptrated,criticalattribute from vw_getCriticalAreaByCA WHERE criticalattribute = 'Competence' and deptrated=@deptrated";

            cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 0;
            conn.Open();

            cmd.Parameters.Add("@deptrated", SqlDbType.VarChar, 200);

            cmd.Parameters["@deptrated"].Value = deptrated;

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                rsp = Convert.ToString(dr["ca"]);
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
    //Team Work
    public string getTeamWork(string deptrated)
    {
        try
        {
            rsp = "";
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString);
            string sql = "select ca,deptrated,criticalattribute from vw_getCriticalAreaByCA WHERE criticalattribute = 'Team Work' and deptrated=@deptrated";

            cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 0;
            conn.Open();

            cmd.Parameters.Add("@deptrated", SqlDbType.VarChar, 200);

            cmd.Parameters["@deptrated"].Value = deptrated;

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                rsp = Convert.ToString(dr["ca"]);
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
    //Communication
    public string getCommunication(string deptrated)
    {
        try
        {
            rsp = "";
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString);
            string sql = "select ca,deptrated,criticalattribute from vw_getCriticalAreaByCA WHERE criticalattribute = 'Communication' and deptrated=@deptrated";

            cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 0;
            conn.Open();

            cmd.Parameters.Add("@deptrated", SqlDbType.VarChar, 200);

            cmd.Parameters["@deptrated"].Value = deptrated;

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                rsp = Convert.ToString(dr["ca"]);
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
    //Attitude
    public string getAttitude(string deptrated)
    {
        try
        {
            rsp = "";
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString);
            string sql = "select ca,deptrated,criticalattribute from vw_getCriticalAreaByCA WHERE criticalattribute = 'Attitude' and deptrated=@deptrated";

            cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 0;
            conn.Open();

            cmd.Parameters.Add("@deptrated", SqlDbType.VarChar, 200);

            cmd.Parameters["@deptrated"].Value = deptrated;

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                rsp = Convert.ToString(dr["ca"]);
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
    //Responsibility
    public string getResponsibility(string deptrated)
    {
        try
        {
            rsp = "";
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString);
            string sql = "select ca,deptrated,criticalattribute from vw_getCriticalAreaByCA WHERE criticalattribute = 'Responsibility' and deptrated=@deptrated";

            cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 0;
            conn.Open();

            cmd.Parameters.Add("@deptrated", SqlDbType.VarChar, 200);

            cmd.Parameters["@deptrated"].Value = deptrated;

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                rsp = Convert.ToString(dr["ca"]);
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
        string attachment = "attachment; filename=CriticalAttributeReport_" + DateTime.Now.ToString() + ".xls";

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
