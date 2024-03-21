using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBM_A_14
{
    public partial class UserTab : Form
    {
        OracleDataAdapter adapter;
        OracleCommand command;
        public UserTab()
        {
            InitializeComponent();
        }
        private void UserTab_Load(object sender, EventArgs e)
        {
            // Program.conn.Open();
            string sql = "select * from DBA_USERS";
            command = new OracleCommand(sql, Program.conn);

            DataTable data = new DataTable();
            adapter = new OracleDataAdapter(command);
            adapter.Fill(data);
            dataGridView1.DataSource = data;

            string sql1 = "SELECT * FROM DBA_ROLES";
            command = new OracleCommand(sql1, Program.conn);

            DataTable data2 = new DataTable();
            adapter = new OracleDataAdapter(command);
            adapter.Fill(data2);
            dataGridView2.DataSource = data2;
            // Program.conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
