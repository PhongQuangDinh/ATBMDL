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
    public partial class Create_Delete_Update : Form
    {
        public Create_Delete_Update()
        {
            InitializeComponent();
        }

        private void Create_Delete_Update_Load(object sender, EventArgs e)
        {

        }

        private void delete_user_Click(object sender, EventArgs e)
        {
            string sql = $"DROP USER {delete_username.Text}";
            OracleCommand cmd = new OracleCommand(sql, Program.conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Successfully deleted user");
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Failed to delete user: {ex.Message}");
            }
        }

        private void create_user_Click(object sender, EventArgs e)
        {
            string sql = $"CREATE USER {username_create.Text} IDENTIFIED BY {password.Text}";
            OracleCommand cmd = new OracleCommand(sql, Program.conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Successfully created user");
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Failed to create user: {ex.Message}");
            }
        }
    }
}

