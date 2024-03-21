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
            groupBox1 = new GroupBox();
            create_user = new Button();
            password = new TextBox();
            username_create = new TextBox();
            label2 = new Label();
            lable1 = new Label();
            groupBox2 = new GroupBox();
            update_user = new Button();
            new_password = new TextBox();
            username_update = new TextBox();
            label3 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            delete_user = new Button();
            delete_username = new TextBox();
            label4 = new Label();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            delete_role = new Button();
            create_role = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            groupBox6 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ScrollBar;
            groupBox1.Controls.Add(create_user);
            groupBox1.Controls.Add(password);
            groupBox1.Controls.Add(username_create);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lable1);
            groupBox1.Location = new Point(25, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 173);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "CREATE";
            // 
            // create_user
            // 
            create_user.Location = new Point(67, 120);
            create_user.Name = "create_user";
            create_user.Size = new Size(175, 35);
            create_user.TabIndex = 4;
            create_user.Text = "CREATE";
            create_user.UseVisualStyleBackColor = true;
            // 
            // password
            // 
            password.Location = new Point(112, 80);
            password.Name = "password";
            password.Size = new Size(177, 27);
            password.TabIndex = 3;
            // 
            // username_create
            // 
            username_create.Location = new Point(112, 39);
            username_create.Name = "username_create";
            username_create.Size = new Size(177, 27);
            username_create.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 86);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // lable1
            // 
            lable1.AutoSize = true;
            lable1.Location = new Point(20, 42);
            lable1.Name = "lable1";
            lable1.Size = new Size(82, 20);
            lable1.TabIndex = 0;
            lable1.Text = "User Name";
            lable1.Click += lable1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ScrollBar;
            groupBox2.Controls.Add(update_user);
            groupBox2.Controls.Add(new_password);
            groupBox2.Controls.Add(username_update);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(339, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(320, 173);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "UPDATE";
            // 
            // update_user
            // 
            update_user.Location = new Point(81, 120);
            update_user.Name = "update_user";
            update_user.Size = new Size(175, 35);
            update_user.TabIndex = 5;
            update_user.Text = "UPDATE";
            update_user.UseVisualStyleBackColor = true;
            // 
            // new_password
            // 
            new_password.Location = new Point(122, 83);
            new_password.Name = "new_password";
            new_password.Size = new Size(169, 27);
            new_password.TabIndex = 4;
            // 
            // username_update
            // 
            username_update.Location = new Point(122, 42);
            username_update.Name = "username_update";
            username_update.Size = new Size(169, 27);
            username_update.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 86);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 2;
            label3.Text = "New Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 42);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            label1.Click += label1_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ScrollBar;
            groupBox3.Controls.Add(delete_user);
            groupBox3.Controls.Add(delete_username);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(665, 26);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(320, 173);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "DELETE";
            // 
            // delete_user
            // 
            delete_user.Location = new Point(74, 120);
            delete_user.Name = "delete_user";
            delete_user.Size = new Size(175, 35);
            delete_user.TabIndex = 2;
            delete_user.Text = "DELETE";
            delete_user.UseVisualStyleBackColor = true;
            // 
            // delete_username
            // 
            delete_username.Location = new Point(103, 64);
            delete_username.Name = "delete_username";
            delete_username.Size = new Size(198, 27);
            delete_username.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 67);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 0;
            label4.Text = "User Name";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.MenuHighlight;
            groupBox4.Controls.Add(groupBox3);
            groupBox4.Controls.Add(groupBox2);
            groupBox4.Location = new Point(12, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1002, 217);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "USER";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.ScrollBar;
            groupBox5.Controls.Add(delete_role);
            groupBox5.Controls.Add(create_role);
            groupBox5.Controls.Add(textBox1);
            groupBox5.Controls.Add(label5);
            groupBox5.Location = new Point(298, 261);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(437, 153);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "CREATE/DELETE";
            // 
            // delete_role
            // 
            delete_role.Location = new Point(234, 98);
            delete_role.Name = "delete_role";
            delete_role.Size = new Size(155, 35);
            delete_role.TabIndex = 3;
            delete_role.Text = "DELETE";
            delete_role.UseVisualStyleBackColor = true;
            delete_role.Click += button1_Click;
            // 
            // create_role
            // 
            create_role.Location = new Point(43, 98);
            create_role.Name = "create_role";
            create_role.Size = new Size(155, 35);
            create_role.TabIndex = 2;
            create_role.Text = "CREATE";
            create_role.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 27);
            textBox1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 44);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 0;
            label5.Text = "Role Name";
            label5.Click += label5_Click;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = SystemColors.MenuHighlight;
            groupBox6.Location = new Point(248, 238);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(526, 187);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "ROLE";
            groupBox6.Enter += groupBox6_Enter;
            // 
            // Create_Delete_Update
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1026, 450);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox6);
            ForeColor = SystemColors.ControlText;
            Name = "Create_Delete_Update";
            Text = "Create_Delete_Update";
            Load += Create_Delete_Update_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
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