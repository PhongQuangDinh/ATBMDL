namespace ATBM_A_14
{
    partial class GrantPrivileges
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
            label1 = new Label();
            label2 = new Label();
            user_name = new TextBox();
            role_name = new TextBox();
            grant = new Button();
            revoke = new Button();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            name = new TextBox();
            column = new TextBox();
            comboBox1 = new ComboBox();
            Select = new CheckBox();
            Insert = new CheckBox();
            Update = new CheckBox();
            Delete = new CheckBox();
            grant_option = new CheckBox();
            revoke_user = new Button();
            grant_user = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(revoke);
            groupBox1.Controls.Add(grant);
            groupBox1.Controls.Add(role_name);
            groupBox1.Controls.Add(user_name);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 220);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "GRANT ROLE TO USER";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 54);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 99);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Role Name";
            label2.Click += label2_Click;
            // 
            // user_name
            // 
            user_name.Location = new Point(109, 51);
            user_name.Name = "user_name";
            user_name.Size = new Size(182, 27);
            user_name.TabIndex = 2;
            // 
            // role_name
            // 
            role_name.Location = new Point(109, 96);
            role_name.Name = "role_name";
            role_name.Size = new Size(182, 27);
            role_name.TabIndex = 3;
            // 
            // grant
            // 
            grant.Location = new Point(27, 160);
            grant.Name = "grant";
            grant.Size = new Size(120, 28);
            grant.TabIndex = 4;
            grant.Text = "GRANT";
            grant.UseVisualStyleBackColor = true;
            // 
            // revoke
            // 
            revoke.Location = new Point(166, 160);
            revoke.Name = "revoke";
            revoke.Size = new Size(120, 28);
            revoke.TabIndex = 5;
            revoke.Text = "REVOKE";
            revoke.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLight;
            groupBox2.Controls.Add(revoke_user);
            groupBox2.Controls.Add(grant_user);
            groupBox2.Controls.Add(grant_option);
            groupBox2.Controls.Add(Delete);
            groupBox2.Controls.Add(Update);
            groupBox2.Controls.Add(Insert);
            groupBox2.Controls.Add(Select);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(column);
            groupBox2.Controls.Add(name);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(353, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(689, 220);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "GRANT/REVOKE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 40);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 0;
            label3.Text = "User/Role Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 83);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 1;
            label4.Text = "Table";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 122);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 2;
            label5.Text = "Column";
            label5.Click += label5_Click;
            // 
            // name
            // 
            name.Location = new Point(189, 43);
            name.Name = "name";
            name.Size = new Size(172, 27);
            name.TabIndex = 4;
            // 
            // column
            // 
            column.Location = new Point(189, 119);
            column.Name = "column";
            column.Size = new Size(172, 27);
            column.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(189, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(172, 28);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Select
            // 
            Select.AutoSize = true;
            Select.Location = new Point(423, 46);
            Select.Name = "Select";
            Select.Size = new Size(71, 24);
            Select.TabIndex = 7;
            Select.Text = "Select";
            Select.UseVisualStyleBackColor = true;
            // 
            // Insert
            // 
            Insert.AutoSize = true;
            Insert.Location = new Point(540, 46);
            Insert.Name = "Insert";
            Insert.Size = new Size(67, 24);
            Insert.TabIndex = 8;
            Insert.Text = "Insert";
            Insert.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            Update.AutoSize = true;
            Update.Location = new Point(423, 84);
            Update.Name = "Update";
            Update.Size = new Size(80, 24);
            Update.TabIndex = 9;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            Delete.AutoSize = true;
            Delete.Location = new Point(540, 84);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 24);
            Delete.TabIndex = 10;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            // 
            // grant_option
            // 
            grant_option.AutoSize = true;
            grant_option.Location = new Point(449, 122);
            grant_option.Name = "grant_option";
            grant_option.Size = new Size(152, 24);
            grant_option.TabIndex = 11;
            grant_option.Text = "With Grant Option";
            grant_option.UseVisualStyleBackColor = true;
            // 
            // revoke_user
            // 
            revoke_user.Location = new Point(288, 160);
            revoke_user.Name = "revoke_user";
            revoke_user.Size = new Size(120, 28);
            revoke_user.TabIndex = 7;
            revoke_user.Text = "REVOKE";
            revoke_user.UseVisualStyleBackColor = true;
            // 
            // grant_user
            // 
            grant_user.Location = new Point(149, 160);
            grant_user.Name = "grant_user";
            grant_user.Size = new Size(120, 28);
            grant_user.TabIndex = 6;
            grant_user.Text = "GRANT";
            grant_user.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 257);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1030, 278);
            dataGridView1.TabIndex = 2;
            // 
            // GrantPrivileges
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 571);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "GrantPrivileges";
            Text = "GrantPrivileges";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox role_name;
        private TextBox user_name;
        private Label label2;
        private Label label1;
        private Button revoke;
        private Button grant;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox name;
        private TextBox column;
        private ComboBox comboBox1;
        private Button revoke_user;
        private Button grant_user;
        private CheckBox grant_option;
        private CheckBox Delete;
        private CheckBox Update;
        private CheckBox Insert;
        private CheckBox Select;
        private DataGridView dataGridView1;
    }
}