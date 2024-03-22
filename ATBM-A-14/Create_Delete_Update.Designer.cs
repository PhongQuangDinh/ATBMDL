using System.Drawing;
using System.Windows.Forms;

namespace ATBM_A_14
{
    partial class Create_Delete_Update
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.create_user = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.username_create = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.update_user = new System.Windows.Forms.Button();
            this.new_password = new System.Windows.Forms.TextBox();
            this.username_update = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.delete_user = new System.Windows.Forms.Button();
            this.delete_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.delete_role = new System.Windows.Forms.Button();
            this.create_role = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.create_user);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.username_create);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lable1);
            this.groupBox1.Location = new System.Drawing.Point(25, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(320, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CREATE";
            // 
            // create_user
            // 
            this.create_user.Location = new System.Drawing.Point(67, 120);
            this.create_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.create_user.Name = "create_user";
            this.create_user.Size = new System.Drawing.Size(175, 35);
            this.create_user.TabIndex = 4;
            this.create_user.Text = "CREATE";
            this.create_user.UseVisualStyleBackColor = true;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(112, 80);
            this.password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(177, 27);
            this.password.TabIndex = 3;
            // 
            // username_create
            // 
            this.username_create.Location = new System.Drawing.Point(112, 39);
            this.username_create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.username_create.Name = "username_create";
            this.username_create.Size = new System.Drawing.Size(177, 27);
            this.username_create.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(20, 42);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(82, 20);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "User Name";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox2.Controls.Add(this.update_user);
            this.groupBox2.Controls.Add(this.new_password);
            this.groupBox2.Controls.Add(this.username_update);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(339, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(320, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UPDATE";
            // 
            // update_user
            // 
            this.update_user.Location = new System.Drawing.Point(81, 120);
            this.update_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update_user.Name = "update_user";
            this.update_user.Size = new System.Drawing.Size(175, 35);
            this.update_user.TabIndex = 5;
            this.update_user.Text = "UPDATE";
            this.update_user.UseVisualStyleBackColor = true;
            // 
            // new_password
            // 
            this.new_password.Location = new System.Drawing.Point(122, 82);
            this.new_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.new_password.Name = "new_password";
            this.new_password.Size = new System.Drawing.Size(169, 27);
            this.new_password.TabIndex = 4;
            // 
            // username_update
            // 
            this.username_update.Location = new System.Drawing.Point(122, 42);
            this.username_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.username_update.Name = "username_update";
            this.username_update.Size = new System.Drawing.Size(169, 27);
            this.username_update.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox3.Controls.Add(this.delete_user);
            this.groupBox3.Controls.Add(this.delete_username);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(665, 26);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(320, 172);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DELETE";
            // 
            // delete_user
            // 
            this.delete_user.Location = new System.Drawing.Point(74, 120);
            this.delete_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete_user.Name = "delete_user";
            this.delete_user.Size = new System.Drawing.Size(175, 35);
            this.delete_user.TabIndex = 2;
            this.delete_user.Text = "DELETE";
            this.delete_user.UseVisualStyleBackColor = true;
            // 
            // delete_username
            // 
            this.delete_username.Location = new System.Drawing.Point(103, 64);
            this.delete_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete_username.Name = "delete_username";
            this.delete_username.Size = new System.Drawing.Size(198, 27);
            this.delete_username.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "User Name";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(1002, 218);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "USER";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox5.Controls.Add(this.delete_role);
            this.groupBox5.Controls.Add(this.create_role);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(298, 261);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(437, 152);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CREATE/DELETE";
            // 
            // delete_role
            // 
            this.delete_role.Location = new System.Drawing.Point(234, 98);
            this.delete_role.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete_role.Name = "delete_role";
            this.delete_role.Size = new System.Drawing.Size(155, 35);
            this.delete_role.TabIndex = 3;
            this.delete_role.Text = "DELETE";
            this.delete_role.UseVisualStyleBackColor = true;
            // 
            // create_role
            // 
            this.create_role.Location = new System.Drawing.Point(43, 98);
            this.create_role.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.create_role.Name = "create_role";
            this.create_role.Size = new System.Drawing.Size(155, 35);
            this.create_role.TabIndex = 2;
            this.create_role.Text = "CREATE";
            this.create_role.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 41);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 27);
            this.textBox1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Role Name";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox6.Location = new System.Drawing.Point(248, 238);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(526, 188);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ROLE";
            // 
            // Create_Delete_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1026, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Create_Delete_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create_Delete_Update";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label lable1;
        private TextBox password;
        private TextBox username_create;
        private Button create_user;
        private GroupBox groupBox2;
        private Label label3;
        private Label label1;
        private Button update_user;
        private TextBox new_password;
        private TextBox username_update;
        private GroupBox groupBox3;
        private Button delete_user;
        private TextBox delete_username;
        private Label label4;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private TextBox textBox1;
        private Label label5;
        private Button delete_role;
        private Button create_role;
        private GroupBox groupBox6;
    }
}