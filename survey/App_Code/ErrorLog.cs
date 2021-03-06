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
using System.IO;


public class ErrorLog
{
    public ErrorLog(Exception ex)
    {
        string pth = ConfigurationManager.AppSettings["errorlog"].ToString();
        string err = ex.ToString();
        //string err = ex.Message;

        DateTime dt = DateTime.Now;
        string fld = dt.ToString("yyyy") + "_" + dt.ToString("MM") + "_";
        pth += fld + dt.ToString("dd") + ".txt";
        if (!File.Exists(pth))
        {
            using (StreamWriter sw = File.CreateText(pth))
            {
                sw.WriteLine(dt.ToString() + " : " + err);
                sw.WriteLine(" ");
                sw.Close();
                sw.Dispose();
            }
        }
        else
        {
            using (StreamWriter sw = File.AppendText(pth))
            {
                sw.WriteLine(dt.ToString() + " : " + err);
                sw.WriteLine(" ");
                sw.Close();
                sw.Dispose();
            }
            
        }
        
    }
    public ErrorLog(string ex)
    {
        string pth = ConfigurationManager.AppSettings["errorlog"].ToString();
        string err = ex;
        DateTime dt = DateTime.Now;
        string fld = dt.ToString("yyyy") + "_" + dt.ToString("MM") + "_";
        pth += fld + dt.ToString("dd") + ".txt";
        if (!File.Exists(pth))
        {
            using (StreamWriter sw = File.CreateText(pth))
            {
                sw.WriteLine(dt.ToString() + " : " + err);
                sw.WriteLine(" ");
                sw.Close();
                sw.Dispose();
            }
        }
        else
        {
            using (StreamWriter sw = File.AppendText(pth))
            {
                sw.WriteLine(dt.ToString() + " : " + err);
                sw.WriteLine(" ");
                sw.Close();
                sw.Dispose();
            }

        }

    }
}
