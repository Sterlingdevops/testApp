using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

public class Connect
{
    public SqlConnection conn;
    public SqlCommand cmd;
    public int returnValue;
    public Connect(string query)
    {
        try
        {
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString;
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = CommandType.StoredProcedure;
        }
        catch (Exception ex)
        {
            ErrorLog e = new ErrorLog(ex);
        }
    }
    public DataSet query(string tblName)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlDataAdapter res = new SqlDataAdapter();
            res.SelectCommand = cmd;
            res.TableMappings.Add("Table", tblName);
            res.Fill(ds);
            close();
        }
        catch (Exception ex)
        {
            ErrorLog e = new ErrorLog(ex);
        }
        return ds;
    }
    public void addparam(string key, object val)
    {
        try
        {
            SqlParameter prm = this.cmd.Parameters.AddWithValue(key, val);
        }
        catch (Exception ex)
        {
            ErrorLog e = new ErrorLog(ex);
        }
    }
    public int query()
    {
        SqlParameter prm = new SqlParameter();
        prm.SqlDbType = SqlDbType.Int;
        prm.Direction = ParameterDirection.ReturnValue;
        this.cmd.Parameters.Add(prm);

        int j = 0;
        try
        {
            j = cmd.ExecuteNonQuery();
            returnValue = Convert.ToInt32(prm.Value);
            close();
        }
        catch (Exception ex)
        {
            ErrorLog e = new ErrorLog(ex);
        }
        return j;
    }
    public void close()
    {
        try
        {
            conn.Close();
        }
        catch (Exception ex)
        {
            ErrorLog e = new ErrorLog(ex);
        }
    }
}
