using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace ATBM_A_14
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Click_Click(object sender, EventArgs e)
        {
            string _username = username.Text;
            string _password = password.Text;
            if (_username == "" || _password == "")
            {
                MessageBox.Show("Empty username or password is not allowed !!!");
                return;
            }
            string conn_str = $"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={Program.HOST})(PORT={Program.PORT})))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={Program.SERVICE})));User Id={_username};Password={_password};";
            OracleConnection conn = new OracleConnection(conn_str);
            try
            {
                conn.Open();
                // Program.connectionString = conn_str;
                Program.conn = conn;
                Program.username = _username;
                Program.password = _password;

                // if else here for each user each form
                UserTab userTab = new UserTab();
                this.Hide();
                userTab.Closed += (s, args) => this.Close(); // Close Form1 when Form2 is closed
                userTab.Show(); // Show Form2

                // Program.conn.Close();
            }
            catch (OracleException ex)
            {
                if (ex.Message.Contains("ORA-28009")) MessageBox.Show("We don't use highest SYSDBA here, pls use another lower SYSDBA account");
                else MessageBox.Show($"Failed to connect: {ex.Message}");
            }

            //OracleCommand cmd = new OracleCommand("select * from NHANSU",conn);
            //OracleDataReader reader = cmd.ExecuteReader();
            //string siuu = "";
            //while (reader.Read())
            //{
            //    string rowValues = "";
            //    for (int i = 0; i < reader.FieldCount; i++)
            //    {
            //        rowValues += $"{reader.GetName(i)}: {reader.GetValue(i)}\n";
            //    }
            //    siuu += rowValues + "\n";
            //}
            //MessageBox.Show(siuu);
            // conn.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

