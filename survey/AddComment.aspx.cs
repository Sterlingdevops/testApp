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

public partial class AddComment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ibox.msg = "";
 //if(!Page.IsPostBack){

     if (deptDD.Items.Count > 0)
     {

         btnSubmit.Enabled = true;
         ibox.css = false;
         ibox.msg = "Please select a department";

     }

     else
     {
         ibox.css = false;
         ibox.msg = "No department";
     }
// }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try {
            if (deptDD.SelectedValue != "")
            {
                string username = Session["currUser"].ToString();
                string deptName = deptDD.SelectedValue;
                string commt = comment.Text;

              //  new ErrorLog("username : "+username +" dept: "+deptName+" comment :"+commt+" selected val "+deptDD.SelectedValue);

                Connect cc = new Connect("spd_updateRatingComment");
                cc.addparam("username", username);
                cc.addparam("comment", commt);
                cc.addparam("deptRated", deptName);
                cc.query();
                ibox.css = true;
                ibox.msg = "Comments added Successfully";

                deptDD.DataBind();
                comment.Text = "";
                
            }
            else {
                ibox.css = false;
                ibox.msg = "Please select a department";
            }
                
        
        }
        catch(Exception ex){

            new ErrorLog(ex);
        }
    }
    protected void comment_TextChanged(object sender, EventArgs e)
    {

    }
}
