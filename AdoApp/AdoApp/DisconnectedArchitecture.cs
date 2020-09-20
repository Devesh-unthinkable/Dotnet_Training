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
    public partial class DisconnectedArchitecture : Form
    {
        DataTable dt;
        DataColumn dc;
        DataRow dr;
        DataTable GetEmployeeTable()
        {
            dt = new DataTable("Employee");

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
        public DisconnectedArchitecture()
        {
            InitializeComponent();
        }

        private void DisconnectedArchitecture_Load(object sender, EventArgs e)
        {
            DataTable EmpTable = GetEmployeeTable();
            dataGridView1.DataSource = EmpTable;
        }
    }
}
