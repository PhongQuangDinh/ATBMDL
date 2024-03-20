namespace HE_THONG_QUAN_LY_DAI_HOC
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
            NhapText = new TextBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // NhapText
            // 
            NhapText.Location = new Point(242, 194);
            NhapText.Name = "NhapText";
            NhapText.Size = new Size(238, 27);
            NhapText.TabIndex = 0;
            NhapText.TextChanged += NhapText_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(308, 249);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Click t eii";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(161, 199);
            label1.Name = "label1";
            label1.Size = new Size(75, 22);
            label1.TabIndex = 2;
            label1.Text = "Họ và tên";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(NhapText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NhapText;
        private Button button1;
        private Label label1;
    }
}