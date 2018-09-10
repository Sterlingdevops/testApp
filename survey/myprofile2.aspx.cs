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

public partial class myprofile2 : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {

           if(!Page.IsPostBack){


               string ratedDept = Session["ratingDept"].ToString().ToUpper();
               ibox.css = true;
               ibox.msg = "You are currently rating <b>" + ratedDept + "</b>" + " | <a href='javascript:history.go(-1)'>Go Back</a>";

               DropDownList1.Items.Add(new ListItem("- Select One -", "-1"));
               DropDownList2.Items.Add(new ListItem("- Select One -", "-1"));
               DropDownList3.Items.Add(new ListItem("- Select One -", "-1"));
               DropDownList4.Items.Add(new ListItem("- Select One -", "-1"));
               DropDownList5.Items.Add(new ListItem("- Select One -", "-1"));
               DropDownList6.Items.Add(new ListItem("- Select One -", "-1"));
               DropDownList7.Items.Add(new ListItem("- Select One -", "-1"));
               DropDownList8.Items.Add(new ListItem("- Select One -", "-1"));
               DropDownList9.Items.Add(new ListItem("- Select One -", "-1"));
               DropDownList12.Items.Add(new ListItem("- Select One -", "-1"));

               Scoreservice s = new Scoreservice();
               DataSet ds = s.getRatingScore();
               for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
               {
                   string scoreval = ds.Tables[0].Rows[i]["Score"].ToString();
                   string scorename = ds.Tables[0].Rows[i]["point"].ToString();
                   
                   DropDownList1.Items.Add(new ListItem(scorename, scoreval));
                   DropDownList2.Items.Add(new ListItem(scorename, scoreval));
                   DropDownList3.Items.Add(new ListItem(scorename, scoreval));
                   DropDownList4.Items.Add(new ListItem(scorename, scoreval));
                   DropDownList5.Items.Add(new ListItem(scorename, scoreval));
                   DropDownList6.Items.Add(new ListItem(scorename, scoreval));
                   DropDownList7.Items.Add(new ListItem(scorename, scoreval));
                   DropDownList8.Items.Add(new ListItem(scorename, scoreval));
                   DropDownList9.Items.Add(new ListItem(scorename, scoreval));
                   DropDownList12.Items.Add(new ListItem(scorename, scoreval));
               }
           
           }
    }
    protected void rateBtn_Click(object sender, EventArgs e)
    {
        try {
            if (DropDownList1.SelectedValue == "-1")
            {
                ibox.msg = "Select a value for <strong> Knowledgeable </strong> under people's column";
                ibox.css = true;
                return;
            }
            if (DropDownList2.SelectedValue == "-1")
            {
                ibox.msg = "Select a value for <strong>Helpful</strong> under people's column";
                ibox.css = true;
                return;
            }
            if (DropDownList3.SelectedValue == "-1")
            {
                ibox.msg = "Select a value for <strong>Courteous</strong>  under people's column";
                ibox.css = true;
                return;
            }
            if (DropDownList4.SelectedValue == "-1")
            {
                ibox.msg = "Select a value for <strong>Responsiveness</strong> under process column";
                ibox.css = true;
                return;
            }
            if (DropDownList5.SelectedValue == "-1")
            {
                ibox.msg = "Select a value for  <strong>Timeliness</strong> under process column";
                ibox.css = true;
                return;
            }
            if (DropDownList6.SelectedValue == "-1")
            {
                ibox.msg = "Select a value for <strong>Ease</strong> under process column";
                ibox.css = true;
                return;
            }
            if (DropDownList7.SelectedValue == "-1")
            {
                ibox.msg = "Select a value for <strong>Clarify</strong> under System communication column";
                ibox.css = true;
                return;
            }
            if (DropDownList8.SelectedValue == "-1")
            {
                ibox.msg = "Select a value for <strong>Content</strong> under System communication column";
                ibox.css = true;
                return;
            }
            if (DropDownList9.SelectedValue == "-1")
            {
                ibox.msg = "Select a value for <strong>Access</strong> under System communication column";
                ibox.css = true;
                return;
            }
            if (DropDownList10.SelectedValue == "-1")
            {
                ibox.msg = "Select a value for Critical attribute under Critical areas of change column";
                ibox.css = true;
                return;
            }
            if (DropDownList11.SelectedValue == "-1")
            {
                ibox.msg = "Kindly make sure you select a value for a Factor under Critical areas of change column";
                ibox.css = true;
                return;
            }
            RatingService rServe = new RatingService();
            Rating rt = new Rating();

            string ratedDept = Session["ratingDept"].ToString();
            

            if (ratedDept == "Technology Group" || ratedDept == "Human Resources and Perf Mgt" || ratedDept == "General Internal Services")
            {
                rt.setCompulsory(1);
            }
            else
            {
                rt.setCompulsory(0);
            }
            rt.setDepartment(ratedDept);

            rt.setKnowledge(Convert.ToDouble(DropDownList1.SelectedValue));
            rt.setHelpful(Convert.ToDouble(DropDownList2.SelectedValue));
            rt.setCourteous(Convert.ToDouble(DropDownList3.SelectedValue));

            rt.setResponsive(Convert.ToDouble(DropDownList4.SelectedValue));
            rt.setTimeliness(Convert.ToDouble(DropDownList5.SelectedValue));
            rt.setEase(Convert.ToDouble(DropDownList6.SelectedValue));

            rt.setClarity(Convert.ToDouble(DropDownList7.SelectedValue));
            rt.setContent(Convert.ToDouble(DropDownList8.SelectedValue));
            rt.setAccess(Convert.ToDouble(DropDownList9.SelectedValue));

            rt.setCriticalAttribute((DropDownList10.SelectedValue));
            rt.setCriticalFactor((DropDownList11.SelectedValue));
            rt.setOverallSatisfaction(Convert.ToDouble(DropDownList12.SelectedValue));
            rt.setComment(TextBox1.Text);

            double weight = Convert.ToDouble(Session["ratingWeight"].ToString()) ;
            rt.setWeight(weight);

            string username = Session["username"].ToString();
            rt.setUserName(username);

            rt=doComputation(rt);

            if (rServe.alreadyRated(rt)) {
                ibox.css = false;
                ibox.msg = "You have already rated  <strong> " + rt.getDepartment() + "</strong>" + " | <a href='myprofile.aspx'>Rate Another Department</a>";
                return;            
            }

            rServe.addRating(rt);
            ibox.css = true;
            ibox.msg = "Rating successuflly submitted for <strong>" + ratedDept + "</strong> <a href='myprofile.aspx'>Rate Another Department</a>";
        
            
        }
        catch(Exception ex){

            new ErrorLog(ex);
        
        }
    }

    protected Rating doComputation(Rating rt)
    
    {
        Scoreservice sServe = new Scoreservice();
       
        double weight = rt.getWeight();

        SystemSetting st = getSetting();

        double peoplePower=st.getPeople();
        double processPower=st.getProcess();
        double commPower=st.getComm();

        double maxS = getMaxScore(); //maximum val

        double maxScore = maxS * 3; // max value for a rating is 4  i.e excellent and 
        double peopleTotal = rt.getKnowledge() + rt.getHelpful()+rt.getCourteous();
        double processTotal=rt.getResponsive()+rt.getTimeliness()+rt.getEase();
        double commTotal = rt.getClarity() + rt.getAccess() + rt.getContent();

        double peopleRatio=peopleTotal/maxScore;
        double processRatio= processTotal/maxScore;
        double commRatio =commTotal/maxScore;

        double percentagePeople = peopleRatio * weight * peoplePower;
        rt.setPercentPeople(percentagePeople);

        double percentageProcess = processRatio*weight * processPower;
        rt.setPercentProcess(percentageProcess);

        double percentageComm =commRatio * weight * commPower;
        rt.setPercentComm(percentageComm);

        double ratingPercentageScore = percentagePeople + percentageProcess + percentageComm;

        rt.setPercentageScore(ratingPercentageScore);

        //string print = "Know :" + rt.getKnowledge() + " hELPFUL:" + rt.getHelpful() + " Courteous: " + rt.getCourteous();
        //print =print+"Total in  People:  " + peopleTotal + "\n";
        //print = print + "Total in Proces:  " + processTotal + "\n";
        //print = print + "Total in COMM:  " + commTotal + "\n";

        //print = print + " People Ratio:  " + peopleRatio + "\n";
        //print = print + " Process Ratio:  " + processRatio + "\n";
        //print = print + " Comm Ratio:  " + commRatio + "\n";

        //print = print + " People Percentage:  " + percentagePeople + "\n";
        //print = print + " Process Percentage:  " + percentageProcess + "\n";
        //print = print + " Comm Percentage:  " + percentageComm + "\n";
        //new ErrorLog(print);

        return rt;

    }


    public double getMaxScore() { 
    
        Connect cc=new Connect("spd_getMaxScore");
        DataSet ds = cc.query("score");
        double val=0.0;
      
        if (ds.Tables[0].Rows.Count > 0)
        {

         val = Convert.ToDouble(ds.Tables[0].Rows[0]["Score"].ToString());
            

        }
        new ErrorLog("Max Value for exxcellent :"+val);
       
        return val;
    
    }

    public SystemSetting getSetting() {

        Connect cc = new Connect("spd_getSystemSetting");
        DataSet ds =cc.query("sets");

        SystemSetting ss = new SystemSetting();

        if(ds.Tables[0].Rows.Count> 0){

            for (int i = 0; i < ds.Tables[0].Rows.Count;i++ )
            {
                string settingName = ds.Tables[0].Rows[i]["SettingName"].ToString();
              
                if (settingName == "Always") {
                 
                  double alw=Convert.ToDouble(ds.Tables[0].Rows[i]["SettingValue"].ToString());
                  ss.setAlways(alw);
                  continue;
                
                }
                if (settingName == "Rarely")
                {

                    double rarel = Convert.ToDouble(ds.Tables[0].Rows[i]["SettingValue"].ToString());
                    ss.setRarely(rarel);
                    continue;

                }
                if (settingName == "Regularly")
                {
                    double reg = Convert.ToDouble(ds.Tables[0].Rows[i]["SettingValue"].ToString());
                    ss.setRegu(reg);
                    continue;
                }

                if (settingName == "People Section")
                {
                    double ppl = Convert.ToDouble(ds.Tables[0].Rows[i]["SettingValue"].ToString());
                    ss.setPeople(ppl);
                    continue;
                }

                if (settingName == "Process Section")
                {
                    double ppl = Convert.ToDouble(ds.Tables[0].Rows[i]["SettingValue"].ToString());
                    ss.setProcess(ppl);
                    continue;
                }
                if (settingName == "Comm Section")
                {
                    double comm = Convert.ToDouble(ds.Tables[0].Rows[i]["SettingValue"].ToString());
                    ss.setComm(comm);
                    continue;
                }
                

            }//end for

       
        }

        new ErrorLog("Always: "+ss.getAlways()+"\n"+"Rarely: "+ss.getRarely()+"\n"+"Regulary :"+ss.getRegu()+"People: "+ss.getPeople()+"\n"+"Process: "+ss.getProcess()+"\n"+"Comm:"+ss.getComm());

        return ss;
    
    }

}
