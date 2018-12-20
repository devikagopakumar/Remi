using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class MasterPage : System.Web.UI.MasterPage
{
    Class1 db;
    SqlConnection con;

    protected void Page_Load(object sender, EventArgs e)
    {
       
        con = new SqlConnection("Data Source=USER-PC; Initial Catalog=tour;Integrated Security=SSPI");
        con.Open();

    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        TextBox1.Text = Calendar1.SelectedDate.ToString();
    }
   
    protected void Button4_Click(object sender, EventArgs e)
    {
        TextBox3.Text = DropDownList1.Text + ":" + DropDownList2.Text + " " + DropDownList3.Text;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string s = "insert into reminder values('"+TextBox1.Text+"','"+TextBox3.Text+"','"+TextBox2.Text+"')";
        Response.Write("<script> alert('Reminder Is Setted Properly')");
        db.insert(s);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string s12 = "update reminder set reminder_date='"+TextBox1.Text.ToString()+"'";
        db.update(s12);
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string s00 = "delete from reminder where reminder_date='" + TextBox1.Text.ToString() + "' ";
        db.delete(s00);
    }
}
