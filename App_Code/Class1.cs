using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
    SqlConnection con;
    public Class1();

	public Class1()
	{

        con = new SqlConnection("Data Source=USER-PC; Initial Catalog=tour;Integrated Security=SSPI");
        con.Open();

	}
    
    public void insert(String s)
    {
        SqlCommand cmd;
        cmd = new SqlCommand(s, con);
        cmd.ExecuteNonQuery();
       
    }
    public SqlDataReader select(String s11)
    {
        SqlCommand cmd;
        SqlDataReader dr; 
        cmd = new SqlCommand(s11, con);
        dr = cmd.ExecuteReader();
        return dr;
    }
    public void update(String s12)
    {
        SqlCommand cmd;
        cmd = new SqlCommand(s12, con);
        cmd.ExecuteNonQuery();
    }
    public void delete(String s00)
    {
        SqlCommand cmd;
        cmd = new SqlCommand(s00, con);
        cmd.ExecuteNonQuery();
    }
}
}
