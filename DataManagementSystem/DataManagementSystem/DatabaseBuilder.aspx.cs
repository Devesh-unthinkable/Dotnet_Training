using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;


namespace DataManagementSystem
{
    public partial class DatabaseBuilder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			txt_DeptId.Focus();
		}

		SqlConnection con;
		SqlCommand cmd;
		public EstablishingConnection()
		{
			InitialiseComponent();
			con = new SqlConnection(ConfiguraionManager.ConnectionStrings["constr"].ConnectionString);
		}
		void Reset()
		{
			txt_DeptName.Text = txt_DeptId.Text = txt_LocationId = "";
			txt_DeptId.Focus();
		}
		private void btn_Add_Click(object sender, EventArgs e)
		{
			Reset();
			string command = "select max(DeptId) from tbl_Departments";
			cmd = new SqlCommand(command, con);
			con.Open();
			int id = Convert.ToInt32(cmd.ExecuteScalar().ToString());
			con.Close();
			txt_DeptId.Text = id.ToString();
		}

		private void btn_Save_Click(object sender, EventArgs e)
		{
			string id = txt_DeptId.Text;
			string name = txt_DeptName.Text;
			string loc = txt_LocationId.Text;

			string command = string.Format("insert into tbl_Departments values({0}, '{1}' , {2})", id, name, loc);

			cmd = new SqlCommand(command, con);
			con.Open();
			cmd.ExecuteNonQuery();
			con.Close();
			Reset();
		}

		private void btn_Search_Click(object sender, EventArgs e)
		{
			string id = txt_DeptId.Text;
			string command = "select * from tbl_Departments where DeptId = " + id;
			cmd = new SqlCommand(command, con);
			con.Open();
			SqlDataReader dr = cmd.ExecuteReader();
			if (dr.Read())
			{
				txt_DeptName.Text = dr[1].ToString();
				txt_LocationId.Text = dr["LocId"].ToString();
			}
			else
			{
				Response.Write("Cannot find the record...", "Message");
				Reset();
			}
			dr.Close();
			con.Close();
		}

		private void btn_Update_Click(object sender, EventArgs e)
		{
			string id = txt_DeptId.Text;
			string name = txt_DeptName.Text;
			string loc = txt_LocationId.Text;

			string command = string.Format("update tbl_Departments set DeptName = '{0}', LocId ={1} where DeptId = {2}", name, loc, id);

			cmd = new SqlCommand(command, con);
			con.Open();
			cmd.ExecuteNonQuery();
			con.Close();
			Response.Write("Record updated...", "Message");
			Reset();
		}

		private void btn_Delete_Click(object sender, EventArgs e)
		{
			string id = txt_DeptId.Text;

			string command = "Delete from tbl_Departments where DeptId = " + id;

			cmd = new SqlCommand(command, con);
			con.Open();
			cmd.ExecuteNonQuery();
			con.Close();
			Response.Write("Record Deleted...", "Message");
			Reset();
		}
	}
}