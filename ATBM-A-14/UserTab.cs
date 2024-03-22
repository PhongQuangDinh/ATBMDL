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
            try
            {
                string sql = $"select * from DBA_USERS"; // for system table we dont need schema
                command = new OracleCommand(sql, Program.conn);

                DataTable data = new DataTable();
                adapter = new OracleDataAdapter(command);
                adapter.Fill(data);
                dataGridView1.DataSource = data;
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string sql1 = $"SELECT * FROM DBA_ROLE_PRIVS WHERE GRANTEE = UPPER('{user}')";
            command = new OracleCommand(sql1, Program.conn);

            DataTable data2 = new DataTable();
            adapter = new OracleDataAdapter(command);
            adapter.Fill(data2);
            dataGridView2.DataSource = data2;
        }
    }
}
