namespace ATBM_A_14
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NhapTen = new TextBox();
            label1 = new Label();
            ClickMe = new Button();
            SuspendLayout();
            // 
            // NhapTen
            // 
            NhapTen.Location = new Point(291, 136);
            NhapTen.Name = "NhapTen";
            NhapTen.Size = new Size(125, 27);
            NhapTen.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 139);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 1;
            label1.Text = "Họ tên:";
            label1.Click += label1_Click;
            // 
            // ClickMe
            // 
            ClickMe.Location = new Point(291, 182);
            ClickMe.Name = "ClickMe";
            ClickMe.Size = new Size(129, 29);
            ClickMe.TabIndex = 2;
            ClickMe.Text = "Click vào đây";
            ClickMe.UseVisualStyleBackColor = true;
            ClickMe.Click += ClickMe_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClickMe);
            Controls.Add(label1);
            Controls.Add(NhapTen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NhapTen;
        private Label label1;
        private Button ClickMe;
    }
}
