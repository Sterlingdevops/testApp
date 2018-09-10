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
/// Summary description for Rating
/// </summary>
public class Rating
{
    private int refId;
    private string username;

    private double knowledge;
    private double helpful;
    private double courteous;

    private double responsiveness;
    private double timeliness;
    private double ease;

    private double clarity ;
    private double content;
    private double access;

    private string criticalAttribute;
    private string criticalFactor;
    private double overallSatisfaction;
    private string comment;
    private string department;
    private int compulsory;
    private double weight;

    private double percentageScore;

    private string userDept;

    private DateTime ratingTime;

    private double percentPeople;
    private double percentProcess;
    private double percentComm;

   

    public string getUserDept(){

        return this.userDept;
    }
    public void setUserDept(string userDept)
    {

        this.userDept=userDept;
    }
    public int getRefId() {

        return refId;

    }
    public void setRefId(int refId) {
        this.refId = refId;
    }

    public string getUserName() {
        return this.username;
    }
    public void setUserName(string username) {
        this.username = username;
    }

    public double getKnowledge() {
        return this.knowledge;
    }
    public void setKnowledge(double knowledge) {
        this.knowledge = knowledge;
    }
    public double getHelpful()
    {
        return this.helpful;
    }
    public void setHelpful(double helpful)
    {
        this.helpful = helpful;
    }
    public double getCourteous()
    {
        return this.courteous;
    }
    public void setCourteous(double courteous)
    {
        this.courteous= courteous;
    }
    public double getResponsive()
    {
        return this.responsiveness;
    }
    public void setResponsive(double responsive)
    {
        this.responsiveness = responsive;
    }
    public double getTimeliness()
    {
        return this.timeliness;
    }
    public void setTimeliness(double timeliness)
    {
        this.timeliness = timeliness;
    }
    public double getEase()
    {
        return this.ease;
    }
    public void setEase(double ease)
    {
        this.ease = ease;
    }
    public double getClarity()
    {
        return this.clarity;
    }
    public void setClarity(double clarity)
    {
        this.clarity = clarity;
    }
    public double getContent()
    {
        return this.content;
    }
    public void setContent(double content)
    {
        this.content= content;
    }
    public double getAccess()
    {
        return this.access;
    }
    public void setAccess(double access)
    {
        this.access = access;
    }


    public string getCriticalAttribute()
    {
        return this.criticalAttribute;
    }
    public void setCriticalAttribute(string critical)
    {
        this.criticalAttribute= critical;
    }


    public string getCriticalFactor()
    {
        return this.criticalFactor;
    }
    public void setCriticalFactor(string criticalFactor)
    {
        this.criticalFactor = criticalFactor;
    }


    public double getOverallSatisfaction()
    {
        return this.overallSatisfaction;
    }
    public void setOverallSatisfaction(double overall)
    {
        this.overallSatisfaction= overall;
    }


    public string getComment()
    {
        return this.comment;
    }
    public void setComment(string comment)
    {
        this.comment=comment;
    }

    public DateTime getRatingTime() {

        return this.ratingTime;
    }

    public void setRatingTime(DateTime dateTime) {

        this.ratingTime = dateTime;
    
    }

	public Rating()
	{
		
	}

    public void setDepartment(string dept) {
        this.department = dept;
    }
    public string getDepartment() {
        return this.department;
    }

    public int getCompulsory() {

        return this.compulsory;
    }
    public void setCompulsory(int compulsory) {

        this.compulsory = compulsory;
    }

    public void setWeight(double weight) {
        this.weight = weight;
    }

    public double getWeight() {
        return this.weight;
    }

 
    public double getPercentageScore() {

       return  this.percentageScore;
    
    }

    public void setPercentageScore(double percentt) {

        this.percentageScore = percentt;
    
    }

    public double getPercentPeople() {
        return this.percentPeople;
    }
    public void setPercentPeople(double p)
    {
        this.percentPeople=p;
    }

    public double getPercentProcess()
    {
        return this.percentProcess;
    }
    public void setPercentProcess(double p)
    {
        this.percentProcess = p;
    }

    public double getPercentComm()
    {
        return this.percentComm;
    }
    public void setPercentComm(double p)
    {
        this.percentComm = p;
    }
}

