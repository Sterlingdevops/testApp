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
/// Summary description for SystemSetting
/// </summary>
public class SystemSetting
{

    private double alwaysVal;
    private double regularlyVal;
    private double rarelyVal;

    private double proces;
    private double people;
    private double comm;


    public double getAlways(){
      return this.alwaysVal;
    
    }
    public void setAlways(double a){
        this.alwaysVal = a; ;
    
    }

    public double getRegu()
    {
        return this.regularlyVal;

    }
    public void setRegu(double a)
    {
        this.regularlyVal = a; ;

    }

    public double getRarely()
    {
        return this.rarelyVal;

    }
    public void setRarely(double a)
    {
        this.rarelyVal = a; ;

    }


    public double getProcess()
    {
        return this.proces;

    }
    public void setProcess(double a)
    {
        this.proces= a; ;

    }
    public double getPeople()
    {
        return this.people;

    }
    public void setPeople(double a)
    {
        this.people = a; ;

    }
    public double getComm()
    {
        return this.comm;

    }
    public void setComm(double a)
    {
        this.comm = a; ;

    }

	public SystemSetting()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
