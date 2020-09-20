using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoApp
{
    public partial class UnderstandingDataset : Form
    {
        DataTable dt;
        DataColumn dc;
        DataRow dr;
        DataTable GetEmployeeTable()
        {
            dt = new DataTable("EmpTable");

            #region Employee DataTable

            dc = new DataColumn("EmpId", typeof(int));
            dt.Columns.Add(dc);
            dt.PrimaryKey = new DataColumn[] { dc };

            dc = new DataColumn("EmpName", typeof(string));
            dt.Columns.Add(dc);

            dc = new DataColumn("DeptID", typeof(int));
            dt.Columns.Add(dc);

            dr = dt.NewRow();
            dr[0] = 101;
            dr[1] = "Devesh";
            dr[2] = 10;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 102;
            dr[1] = "Ashish";
            dr[2] = 20;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 103;
            dr[1] = "Ankur";
            dr[2] = 40;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 104;
            dr[1] = "Jaskirat";
            dr[2] = 20;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 105;
            dr[1] = "Pallavv";
            dr[2] = 40;
            dt.Rows.Add(dr);

            #endregion

            return dt;
        }

        DataTable GetDeptTable()
        {
            dt = new DataTable("DeptTable");

            #region Department DataTable

            dc = new DataColumn("DeptId", typeof(int));
            dt.Columns.Add(dc);
            dt.PrimaryKey = new DataColumn[] { dc };

            dc = new DataColumn("Department", typeof(string));
            dt.Columns.Add(dc);

            dr = dt.NewRow();
            dr[0] = 10;
            dr[1] = "Administration";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 20;
            dr[1] = "Human Resources";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 40;
            dr[1] = "Information Technology";
            dt.Rows.Add(dr);

            #endregion

            return dt;
        }
        public UnderstandingDataset()
        {
            InitializeComponent();
        }

        DataSet GetRelation()
        {
            DataSet ds = new DataSet("MyDs");

            DataTable emp = GetEmployeeTable();
            DataTable dept = GetDeptTable();

            ds.Tables.Add(emp);
            ds.Tables.Add(dept);

            DataColumn fkey = ds.Tables["emp"].Columns["EmpId"];
            DataColumn pkey = ds.Tables["dept"].Columns["DeptId"];

            DataRelation drel = new DataRelation("EmpDeptRelation", pkey, fkey);
            ds.Relations.Add(drel);

            return ds;
        }

        private void UnderstandingDataset_Load(object sender, EventArgs e)
        {
            DataSet ds = GetRelation();
            dataGridView1.DataSource = ds.Tables[1];
            dataGridView2.DataSource = ds.Tables["DeptTable"];
        }

    }
}
