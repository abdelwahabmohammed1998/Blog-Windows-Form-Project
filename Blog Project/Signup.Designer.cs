namespace Blog_Project
{
    partial class Signup
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
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            lbl_invalid = new Label();
            lbl_signin = new Label();
            label4 = new Label();
            btn_signup = new Button();
            label3 = new Label();
            dtp_birthDate = new DateTimePicker();
            txt_repassword = new TextBox();
            txt_password = new TextBox();
            txt_userName = new TextBox();
            txt_name = new TextBox();
            close_btn = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(105, 98, 210);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lbl_invalid);
            splitContainer1.Panel2.Controls.Add(lbl_signin);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(btn_signup);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(dtp_birthDate);
            splitContainer1.Panel2.Controls.Add(txt_repassword);
            splitContainer1.Panel2.Controls.Add(txt_password);
            splitContainer1.Panel2.Controls.Add(txt_userName);
            splitContainer1.Panel2.Controls.Add(txt_name);
            splitContainer1.Panel2.Controls.Add(close_btn);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(700, 743);
            splitContainer1.SplitterDistance = 257;
            splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 320);
            label1.Name = "label1";
            label1.Size = new Size(220, 80);
            label1.TabIndex = 0;
            label1.Text = "Nexus\r\nNarratives\r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_invalid
            // 
            lbl_invalid.AutoSize = true;
            lbl_invalid.ForeColor = Color.Red;
            lbl_invalid.Location = new Point(34, 551);
            lbl_invalid.Name = "lbl_invalid";
            lbl_invalid.Size = new Size(0, 25);
            lbl_invalid.TabIndex = 12;
            // 
            // lbl_signin
            // 
            lbl_signin.AutoSize = true;
            lbl_signin.Cursor = Cursors.Hand;
            lbl_signin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_signin.ForeColor = Color.CornflowerBlue;
            lbl_signin.Location = new Point(235, 676);
            lbl_signin.Name = "lbl_signin";
            lbl_signin.Size = new Size(121, 25);
            lbl_signin.TabIndex = 11;
            lbl_signin.Text = "SIGNIN Here";
            lbl_signin.Click += lbl_signin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 676);
            label4.Name = "label4";
            label4.Size = new Size(200, 25);
            label4.TabIndex = 10;
            label4.Text = "Already Have Account ?";
            // 
            // btn_signup
            // 
            btn_signup.BackColor = Color.FromArgb(105, 98, 210);
            btn_signup.Cursor = Cursors.Hand;
            btn_signup.FlatAppearance.BorderSize = 0;
            btn_signup.FlatStyle = FlatStyle.Flat;
            btn_signup.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_signup.ForeColor = Color.White;
            btn_signup.Location = new Point(34, 590);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(345, 59);
            btn_signup.TabIndex = 5;
            btn_signup.Text = "SIGN UP";
            btn_signup.UseVisualStyleBackColor = false;
            btn_signup.Click += btn_signup_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 307);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 9;
            label3.Text = "Birthdate";
            // 
            // dtp_birthDate
            // 
            dtp_birthDate.CalendarForeColor = Color.FromArgb(162, 162, 162);
            dtp_birthDate.CalendarMonthBackground = Color.FromArgb(242, 242, 242);
            dtp_birthDate.CalendarTrailingForeColor = Color.FromArgb(162, 162, 162);
            dtp_birthDate.Format = DateTimePickerFormat.Custom;
            dtp_birthDate.Location = new Point(34, 329);
            dtp_birthDate.Name = "dtp_birthDate";
            dtp_birthDate.Size = new Size(345, 31);
            dtp_birthDate.TabIndex = 8;
            // 
            // txt_repassword
            // 
            txt_repassword.BackColor = Color.FromArgb(242, 242, 242);
            txt_repassword.BorderStyle = BorderStyle.None;
            txt_repassword.Font = new Font("Segoe UI", 12F);
            txt_repassword.ForeColor = Color.FromArgb(162, 162, 162);
            txt_repassword.Location = new Point(34, 474);
            txt_repassword.Margin = new Padding(25);
            txt_repassword.Name = "txt_repassword";
            txt_repassword.PasswordChar = '*';
            txt_repassword.PlaceholderText = "Re-Type Password";
            txt_repassword.Size = new Size(345, 32);
            txt_repassword.TabIndex = 7;
            txt_repassword.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.FromArgb(242, 242, 242);
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Font = new Font("Segoe UI", 12F);
            txt_password.ForeColor = Color.FromArgb(162, 162, 162);
            txt_password.Location = new Point(34, 401);
            txt_password.Margin = new Padding(25);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.PlaceholderText = "Password";
            txt_password.Size = new Size(345, 32);
            txt_password.TabIndex = 6;
            txt_password.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_userName
            // 
            txt_userName.BackColor = Color.FromArgb(242, 242, 242);
            txt_userName.BorderStyle = BorderStyle.None;
            txt_userName.Font = new Font("Segoe UI", 12F);
            txt_userName.ForeColor = Color.FromArgb(162, 162, 162);
            txt_userName.Location = new Point(34, 247);
            txt_userName.Margin = new Padding(25);
            txt_userName.Name = "txt_userName";
            txt_userName.PlaceholderText = "User Name";
            txt_userName.Size = new Size(345, 32);
            txt_userName.TabIndex = 5;
            txt_userName.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_name
            // 
            txt_name.BackColor = Color.FromArgb(242, 242, 242);
            txt_name.BorderStyle = BorderStyle.None;
            txt_name.Font = new Font("Segoe UI", 12F);
            txt_name.ForeColor = Color.FromArgb(162, 162, 162);
            txt_name.Location = new Point(34, 183);
            txt_name.Margin = new Padding(25);
            txt_name.Name = "txt_name";
            txt_name.PlaceholderText = "Name";
            txt_name.Size = new Size(345, 32);
            txt_name.TabIndex = 4;
            txt_name.TextAlign = HorizontalAlignment.Center;
            // 
            // close_btn
            // 
            close_btn.BackColor = Color.Transparent;
            close_btn.Cursor = Cursors.Hand;
            close_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close_btn.ForeColor = Color.FromArgb(126, 126, 126);
            close_btn.Location = new Point(377, 12);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(50, 50);
            close_btn.TabIndex = 3;
            close_btn.Text = "X";
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += close_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(3, 44);
            label2.Name = "label2";
            label2.Size = new Size(336, 96);
            label2.TabIndex = 2;
            label2.Text = "Signup NOW !\r\nTo Became Author.";
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 743);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Signup";
            Text = "Signup";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private Label label2;
        private Button close_btn;
        private TextBox txt_userName;
        private TextBox txt_name;
        private DateTimePicker dtp_birthDate;
        private TextBox txt_repassword;
        private TextBox txt_password;
        private Label label3;
        private Button btn_signup;
        private Label lbl_signin;
        private Label label4;
        private Label lbl_invalid;
    }
}