namespace ATBM_A_14
{
    partial class RoleTab
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
            role = new GroupBox();
            dataGridView1 = new DataGridView();
            privileges = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            search = new Button();
            dataGridView2 = new DataGridView();
            role.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            privileges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // role
            // 
            role.Controls.Add(dataGridView1);
            role.Location = new Point(12, 12);
            role.Name = "role";
            role.Size = new Size(776, 204);
            role.TabIndex = 0;
            role.TabStop = false;
            role.Text = "ROLE";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(69, 15);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(701, 180);
            dataGridView1.TabIndex = 0;
            // 
            // privileges
            // 
            privileges.Controls.Add(dataGridView2);
            privileges.Controls.Add(search);
            privileges.Controls.Add(textBox1);
            privileges.Controls.Add(label1);
            privileges.Location = new Point(12, 222);
            privileges.Name = "privileges";
            privileges.Size = new Size(776, 214);
            privileges.TabIndex = 1;
            privileges.TabStop = false;
            privileges.Text = "PRIVILEGES";
            privileges.Enter += groupBox2_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 23);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter user role";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(235, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 27);
            textBox1.TabIndex = 1;
            // 
            // search
            // 
            search.Location = new Point(431, 20);
            search.Name = "search";
            search.Size = new Size(91, 27);
            search.TabIndex = 2;
            search.Text = "SEARCH";
            search.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(69, 66);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(701, 142);
            dataGridView2.TabIndex = 3;
            // 
            // RoleTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(privileges);
            Controls.Add(role);
            Name = "RoleTab";
            Text = "RoleTab";
            role.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            privileges.ResumeLayout(false);
            privileges.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox role;
        private DataGridView dataGridView1;
        private GroupBox privileges;
        private Label label1;
        private DataGridView dataGridView2;
        private Button search;
        private TextBox textBox1;
    }
}