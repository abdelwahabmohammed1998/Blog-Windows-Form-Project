namespace Blog_Project
{
    partial class Login
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
            lbl_invalidData = new Label();
            lbl_guestLogin = new Label();
            lbl_signup = new Label();
            label3 = new Label();
            btn_signin = new Button();
            txt_password = new TextBox();
            txt_userName = new TextBox();
            label2 = new Label();
            close_btn = new Button();
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
            splitContainer1.Panel2.Controls.Add(lbl_invalidData);
            splitContainer1.Panel2.Controls.Add(lbl_guestLogin);
            splitContainer1.Panel2.Controls.Add(lbl_signup);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(btn_signin);
            splitContainer1.Panel2.Controls.Add(txt_password);
            splitContainer1.Panel2.Controls.Add(txt_userName);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(close_btn);
            splitContainer1.Size = new Size(742, 616);
            splitContainer1.SplitterDistance = 277;
            splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 258);
            label1.Name = "label1";
            label1.Size = new Size(220, 80);
            label1.TabIndex = 0;
            label1.Text = "Nexus\r\nNarratives";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_invalidData
            // 
            lbl_invalidData.AutoSize = true;
            lbl_invalidData.ForeColor = Color.Red;
            lbl_invalidData.Location = new Point(83, 372);
            lbl_invalidData.Name = "lbl_invalidData";
            lbl_invalidData.Size = new Size(250, 25);
            lbl_invalidData.TabIndex = 8;
            lbl_invalidData.Text = "Invalid username or password";
            lbl_invalidData.Visible = false;
            // 
            // lbl_guestLogin
            // 
            lbl_guestLogin.AutoSize = true;
            lbl_guestLogin.Cursor = Cursors.Hand;
            lbl_guestLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_guestLogin.ForeColor = Color.CornflowerBlue;
            lbl_guestLogin.Location = new Point(152, 539);
            lbl_guestLogin.Name = "lbl_guestLogin";
            lbl_guestLogin.Size = new Size(113, 25);
            lbl_guestLogin.TabIndex = 7;
            lbl_guestLogin.Text = "Guest Login";
            lbl_guestLogin.Click += lbl_guestLogin_Click;
            // 
            // lbl_signup
            // 
            lbl_signup.AutoSize = true;
            lbl_signup.Cursor = Cursors.Hand;
            lbl_signup.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_signup.ForeColor = Color.CornflowerBlue;
            lbl_signup.Location = new Point(208, 489);
            lbl_signup.Name = "lbl_signup";
            lbl_signup.Size = new Size(125, 25);
            lbl_signup.TabIndex = 6;
            lbl_signup.Text = "SIGNUP Here";
            lbl_signup.Click += lbl_signup_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 489);
            label3.Name = "label3";
            label3.Size = new Size(184, 25);
            label3.TabIndex = 5;
            label3.Text = "Don't Have Account ?";
            // 
            // btn_signin
            // 
            btn_signin.BackColor = Color.FromArgb(105, 98, 210);
            btn_signin.Cursor = Cursors.Hand;
            btn_signin.FlatAppearance.BorderSize = 0;
            btn_signin.FlatStyle = FlatStyle.Flat;
            btn_signin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_signin.ForeColor = Color.White;
            btn_signin.Location = new Point(30, 412);
            btn_signin.Name = "btn_signin";
            btn_signin.Size = new Size(345, 57);
            btn_signin.TabIndex = 4;
            btn_signin.Text = "SIGN IN";
            btn_signin.UseVisualStyleBackColor = false;
            btn_signin.Click += btn_signin_Click;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.FromArgb(242, 242, 242);
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Font = new Font("Segoe UI", 12F);
            txt_password.ForeColor = Color.FromArgb(162, 162, 162);
            txt_password.Location = new Point(30, 320);
            txt_password.Margin = new Padding(25);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.PlaceholderText = "Password";
            txt_password.Size = new Size(345, 32);
            txt_password.TabIndex = 3;
            txt_password.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_userName
            // 
            txt_userName.BackColor = Color.FromArgb(242, 242, 242);
            txt_userName.BorderStyle = BorderStyle.None;
            txt_userName.Font = new Font("Segoe UI", 12F);
            txt_userName.ForeColor = Color.FromArgb(162, 162, 162);
            txt_userName.Location = new Point(30, 241);
            txt_userName.Margin = new Padding(25);
            txt_userName.Name = "txt_userName";
            txt_userName.PlaceholderText = "User Name";
            txt_userName.Size = new Size(345, 32);
            txt_userName.TabIndex = 2;
            txt_userName.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(30, 85);
            label2.Name = "label2";
            label2.Size = new Size(273, 96);
            label2.TabIndex = 1;
            label2.Text = "Signin To Your \r\nAccount";
            // 
            // close_btn
            // 
            close_btn.BackColor = Color.Transparent;
            close_btn.Cursor = Cursors.Hand;
            close_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close_btn.ForeColor = Color.FromArgb(126, 126, 126);
            close_btn.Location = new Point(391, 12);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(50, 50);
            close_btn.TabIndex = 0;
            close_btn.Text = "X";
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += close_btn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(742, 616);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
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
        private Button close_btn;
        private Label label2;
        private TextBox txt_userName;
        private TextBox txt_password;
        private Button btn_signin;
        private Label label3;
        private Label lbl_signup;
        private Label lbl_guestLogin;
        private Label lbl_invalidData;
    }
}