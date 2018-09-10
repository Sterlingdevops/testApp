using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public class Score
{
    private double scoreval;
    private string scorename;

    public void setScoreVal(double scoreVal) {

        this.scoreval = scoreVal;

    
    }

    public double getScoreVal() {
        return this.scoreval;
    }

    public string getScoreName() {

        return this.scorename;

    }
    public void setScoreName(string scoreName) {
        this.scorename = scoreName;
    
    }
}
