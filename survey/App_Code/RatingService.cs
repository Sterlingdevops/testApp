using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for RatingService
/// </summary>
public class RatingService
{
	public RatingService()
	{
	
	}


    public DataSet getProfileDepartments(string username,string deptName) {

        Rating rr = new Rating();
        rr.setUserName(username);
        rr.setUserDept(deptName);
        Connect conn = addParamemeters(rr);
        conn.addparam("opCode","5");

        return conn.query("depts");
    
    }
    public void addRating(Rating rating) {

        Connect conn = addParamemeters(rating);
        conn.addparam("opCode","1");
       
        conn.query();
    
    }

    public void updateRating(Rating rating)
    {

        Connect conn = new Connect("spRating_updateRating");

        conn.addparam("username", rating.getUserName());
        conn.addparam("knowledge", rating.getKnowledge());
        conn.addparam("helpful", rating.getHelpful());
        conn.addparam("courteous", rating.getCourteous());
        conn.addparam("response", rating.getResponsive());
        conn.addparam("timeliness", rating.getTimeliness());
        conn.addparam("ease", rating.getEase());
        conn.addparam("clarity", rating.getClarity());
        conn.addparam("content", rating.getContent());
        conn.addparam("access", rating.getAccess());
        conn.addparam("criticalAttribute", rating.getCriticalAttribute());
        conn.addparam("criticalFactor", rating.getCriticalFactor());
        conn.addparam("overallSatisfaction", rating.getOverallSatisfaction());
        conn.addparam("comment", rating.getComment());

        conn.query();

    }


    public DataSet findNumberOfCompulsory(string username) {
        Rating r = new Rating();
        r.setUserName(username);

        Connect conn = addParamemeters(r);
        conn.addparam("opCode","3");
        return conn.query("howMany");
    
    }  

    public Rating[] findAllRatings() {

        Rating rating = new Rating() ;
        Rating [] ratings;

        Connect cc = addParamemeters(rating);
        DataSet ds= cc.query("ratings");

        ratings = getRatingsFromDataSet(ds);

        return ratings;
    
    }


    protected Rating[] getRatingsFromDataSet(DataSet ds)
    {

        Rating[] ratings;
        Rating rating = new Rating();
        int arraySize = ds.Tables["ratings"].Rows.Count;
        ratings = new Rating[arraySize]; // set array size to dataset rowsize 
        
        for (int i = 0; i < ds.Tables["ratings"].Rows.Count; i++)
        {

          
            try
            {
                rating.setRatingTime(Convert.ToDateTime(ds.Tables[0].Rows[i]["ratingTimestamp"].ToString()));
            }
            catch (Exception ex)
            {
                new ErrorLog(ex);
            }
            
        rating.setUserName((ds.Tables[0].Rows[i]["username"].ToString()));
        rating.setKnowledge(Convert.ToDouble(ds.Tables[0].Rows[i]["Kw"].ToString()));
        rating.setHelpful(Convert.ToDouble(ds.Tables[0].Rows[i]["Hp"].ToString()));
        rating.setCourteous(Convert.ToDouble(ds.Tables[0].Rows[i]["Ct"].ToString()));

        rating.setResponsive(Convert.ToDouble(ds.Tables[0].Rows[i]["Rp"].ToString()));
        rating.setTimeliness(Convert.ToDouble(ds.Tables[0].Rows[i]["Tm"].ToString()));
        rating.setEase(Convert.ToDouble(ds.Tables[0].Rows[i]["Ea"].ToString()));

        rating.setClarity(Convert.ToDouble(ds.Tables[0].Rows[i]["Cl"].ToString()));
        rating.setContent(Convert.ToDouble(ds.Tables[0].Rows[i]["Co"].ToString()));
        rating.setAccess(Convert.ToDouble(ds.Tables[0].Rows[i]["Ac"].ToString()));

        rating.setCriticalAttribute(ds.Tables[0].Rows[i]["criticalattribute"].ToString());
        rating.setCriticalFactor((ds.Tables[0].Rows[i]["criticalsuccess"].ToString()));
        rating.setOverallSatisfaction(Convert.ToDouble(ds.Tables[0].Rows[i]["overallSatisfaction"].ToString()));
        rating.setComment((ds.Tables[0].Rows[i]["comment"].ToString()));

  
        ratings[i] = rating;

        }
        return ratings;

    }

    protected Connect addParamemeters(Rating rating)
    {

        Connect conn= new Connect("spd_RatingService");

        if (rating.getUserName() == null || rating.getUserName() == "")
            rating.setUserName("");
            conn.addparam("username", rating.getUserName());

            if (rating.getUserDept() == null || rating.getUserDept() == "")
                rating.setUserDept("");
            conn.addparam("userdept", rating.getUserDept());

        if (rating.getKnowledge() == 0)
            rating.setKnowledge(0.0);           
            conn.addparam("knowledge", rating.getKnowledge());

            if (rating.getPercentageScore() == 0)
                rating.setPercentageScore(0.0);
            conn.addparam("percentageScore", rating.getPercentageScore());

            if (rating.getWeight() == 0)
               rating.setWeight(0.0);
            conn.addparam("weight", rating.getWeight());

        if (rating.getHelpful() == 0)
           rating.setHelpful(0.00); 
           conn.addparam("helpful", rating.getHelpful());

        if (rating.getCourteous() == 0)
         rating.setCourteous(0); 
        conn.addparam("courteous", rating.getCourteous());

        if (rating.getResponsive() == 0)
            rating.setResponsive(0.00); 
        conn.addparam("response", rating.getResponsive());

        if (rating.getTimeliness() ==0)
            rating.setTimeliness(0.00); 
        conn.addparam("timeliness", rating.getTimeliness());

        if (rating.getEase() == 0)
            rating.setEase(0.00); 
        conn.addparam("ease", rating.getEase());

        if (rating.getClarity() == 0)
        rating.setClarity(0.00); 
        conn.addparam("clarity", rating.getClarity());

        if (rating.getContent() == 0)
            rating.setContent(0.00); 
        conn.addparam("content", rating.getContent());

        if (rating.getAccess() ==0)
            rating.setAccess(0.00); 
        conn.addparam("access", rating.getAccess());

        if (rating.getCriticalAttribute() == "" || rating.getCriticalAttribute() == null)
            rating.setCriticalAttribute("");
        conn.addparam("criticalAttribute", rating.getCriticalAttribute());

        if (rating.getCriticalFactor() == "" || rating.getCriticalFactor()== null)
            rating.setCriticalFactor(""); 
        conn.addparam("criticalSuccess", rating.getCriticalFactor());

        if (rating.getOverallSatisfaction() == 0)
            rating.setOverallSatisfaction(0.00); 
        conn.addparam("overallSatisfaction", rating.getOverallSatisfaction());

        if (rating.getComment() == "" || rating.getComment()== null)
            rating.setComment("");
        conn.addparam("comment", rating.getComment());

        if (rating.getDepartment() == "" || rating.getDepartment() == null)
            rating.setDepartment("");
        conn.addparam("deptRated", rating.getDepartment());

        if (rating.getCompulsory() == 0)
            rating.setCompulsory(0);
        conn.addparam("compulsory", rating.getCompulsory());

        if (rating.getPercentPeople() == 0)
            rating.setPercentPeople(0);
        conn.addparam("percentagePeople", rating.getPercentPeople());

        if (rating.getPercentProcess() == 0)
            rating.setPercentProcess(0);
        conn.addparam("percentageProcess", rating.getPercentProcess());

        if (rating.getPercentComm() == 0)
            rating.setPercentComm(0);
        conn.addparam("percentageComm", rating.getPercentComm());

        return conn;


    }

    public bool alreadyRated(Rating rating) {
        bool status = false;
        Connect cc = addParamemeters(rating);
        cc.addparam("opCode","6");
        DataSet ds = cc.query("ratings");

        if(ds.Tables[0].Rows.Count > 0){

            status = true;
        
        }

        return status;
    
    }

    public string countUserRating(string username)
    {

        string ct = "0";
        Rating rt = new Rating();
        rt.setUserName(username);
        Connect cc = addParamemeters(rt);
        cc.addparam("opCode", "7");
        DataSet ds = cc.query("ratings");

        if (ds.Tables[0].Rows.Count > 0)
        {

          ct = ds.Tables[0].Rows[0]["howMany"].ToString();
            

        }
       
        return ct;

    }

}
