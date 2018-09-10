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

public partial class myprofile : System.Web.UI.Page
{
    string userName;
    string departtment;
    string ct;
    double maxRating = 0.0;
    double minRating = 0.0;

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            if (Convert.ToString(Session["username"]) == "" || Session["username"] == null)
            {
                Response.Redirect("login.aspx");
            }
            RatingService rss = new RatingService();
            
            getRatingThresold();

            ct = rss.countUserRating(Session["username"].ToString());
        }
        catch (Exception ex)
        {
           ErrorLog err = new ErrorLog(ex);
           Response.Redirect("login.aspx");

         
        }
       
        lblcount.Text = "You have Rated " + "<span style='color:#990000;  font-weight:bold;'>" + ct + "</span>" + " of <span style='font-weight:bold;'>"+maxRating+"</span>";

        ibox.msg = "";        
        
        if(!Page.IsPostBack){

            proceed.Enabled = false;

            ddldept.Items.Add(new ListItem("- Select  Department to Rate -", "0"));

            try
            {
                userName = Session["username"].ToString();
                departtment = Session["deptname"].ToString();
                RatingService rServe = new  RatingService(); //in dataset

                DataSet ds = rServe.getProfileDepartments(userName,departtment);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    ibox.css = false;
                    ibox.msg = "You have already rated the maximum number of units";

                }

                else
                    proceed.Enabled = true;

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string dept = ds.Tables[0].Rows[i]["Deptname"].ToString();
                    ddldept.Items.Add(new ListItem(dept, dept));
                }
                Label1.Text = maxRating.ToString();
                //Label2.Text = minRating.ToString() ;             
                        
            }

            catch (Exception ex)
            {
                ErrorLog err = new ErrorLog(ex);
            }
        
        }

       
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (decision.SelectedValue == "1")
        {

            proceed.Enabled = true;

        }

        else
        {
            proceed.Enabled = false;
            ibox.msg = "You must interface with a unit to rate it.\n Select Yes to Rate the selected department.";
            ibox.css = false;
        }
    }
    protected void proceed_Click(object sender, EventArgs e)
    {
        try {

            if (ddldept.SelectedValue == "0")
            {
                ibox.msg = "Select the department to be rated.";
                ibox.css = false;
                return;
            }
            if (decision.SelectedValue == "-1")
            {
                ibox.msg = "Select an option for do you Interface with the selected department";
                ibox.css = false;
                return;
            }
            if (weight.SelectedValue == "-1")
            {
                ibox.msg = "Select an option for  <strong>'How Often do you interface with them'</strong>";
                ibox.css = false;
                return;
            }

            Session["ratingWeight"] = weight.SelectedValue;
            Session["ratingDept"]=ddldept.SelectedValue;
            Response.Redirect("myprofile2.aspx");        
        }
        catch(Exception ex){
            new ErrorLog(ex);
        
        }
    }

    protected void getRatingThresold()
    {       

        Connect cc = new Connect("spd_getSystemSetting");
        DataSet ds = cc.query("sets");
        
        if(ds.Tables[0].Rows.Count > 0){
            
            for(int i=0;i<ds.Tables[0].Rows.Count;i++){       
                            
               string settingName= ds.Tables[0].Rows[i]["SettingName"].ToString();             

               if (settingName == "MaxRating")
               {
                   maxRating = Convert.ToDouble(ds.Tables[0].Rows[i]["SettingValue"]);
                                  
                  
               }

               if (settingName == "MinRating")
               {
                   minRating = Convert.ToDouble(ds.Tables[0].Rows[i]["SettingValue"]);
                  
                  
               }

        }
        
        
        
        }

    }
}
