namespace Blog_Project
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            txt_joinDate = new TextBox();
            txt_setting_age = new TextBox();
            txt_setting_repassword = new TextBox();
            txt_setting_password = new TextBox();
            txt_setting_name = new TextBox();
            txt_setting_userName = new TextBox();
            btn_setting_saveChanges = new Button();
            lbl_setting_repassword = new Label();
            lbl_setting_password = new Label();
            lbl_setting_joinDate = new Label();
            lbl_setting_birthdate = new Label();
            lbl_setting_userName = new Label();
            gb_setting = new GroupBox();
            lbl_changeStatus = new Label();
            lbl_setting_name = new Label();
            flp = new FlowLayoutPanel();
            panel_logo = new Panel();
            lbl_logo = new Label();
            panel_home = new Panel();
            btn_home = new Button();
            panel_about = new Panel();
            btn_about = new Button();
            panel_help = new Panel();
            btn_help = new Button();
            panel_addNew = new Panel();
            btn_addNew = new Button();
            panel_setting = new Panel();
            btn_setting = new Button();
            close_btn = new Button();
            lbl_username = new Label();
            lbl_name = new Label();
            lbl_hi = new Label();
            btn_logOut = new Button();
            gb_setting.SuspendLayout();
            flp.SuspendLayout();
            panel_logo.SuspendLayout();
            panel_home.SuspendLayout();
            panel_about.SuspendLayout();
            panel_help.SuspendLayout();
            panel_addNew.SuspendLayout();
            panel_setting.SuspendLayout();
            SuspendLayout();
            // 
            // txt_joinDate
            // 
            txt_joinDate.BackColor = Color.FromArgb(242, 242, 242);
            txt_joinDate.BorderStyle = BorderStyle.None;
            txt_joinDate.Enabled = false;
            txt_joinDate.Font = new Font("Segoe UI", 12F);
            txt_joinDate.ForeColor = Color.FromArgb(162, 162, 162);
            txt_joinDate.Location = new Point(280, 260);
            txt_joinDate.Margin = new Padding(25);
            txt_joinDate.Name = "txt_joinDate";
            txt_joinDate.Size = new Size(345, 32);
            txt_joinDate.TabIndex = 12;
            txt_joinDate.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_setting_age
            // 
            txt_setting_age.BackColor = Color.FromArgb(242, 242, 242);
            txt_setting_age.BorderStyle = BorderStyle.None;
            txt_setting_age.Enabled = false;
            txt_setting_age.Font = new Font("Segoe UI", 12F);
            txt_setting_age.ForeColor = Color.FromArgb(162, 162, 162);
            txt_setting_age.Location = new Point(280, 192);
            txt_setting_age.Margin = new Padding(25);
            txt_setting_age.Name = "txt_setting_age";
            txt_setting_age.Size = new Size(345, 32);
            txt_setting_age.TabIndex = 11;
            txt_setting_age.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_setting_repassword
            // 
            txt_setting_repassword.BackColor = Color.FromArgb(242, 242, 242);
            txt_setting_repassword.BorderStyle = BorderStyle.None;
            txt_setting_repassword.Font = new Font("Segoe UI", 12F);
            txt_setting_repassword.ForeColor = Color.FromArgb(162, 162, 162);
            txt_setting_repassword.Location = new Point(280, 392);
            txt_setting_repassword.Margin = new Padding(25);
            txt_setting_repassword.Name = "txt_setting_repassword";
            txt_setting_repassword.PasswordChar = '*';
            txt_setting_repassword.PlaceholderText = "Retype Password";
            txt_setting_repassword.Size = new Size(345, 32);
            txt_setting_repassword.TabIndex = 10;
            txt_setting_repassword.TextAlign = HorizontalAlignment.Center;
            txt_setting_repassword.ModifiedChanged += txt_setting_repassword_ModifiedChanged;
            // 
            // txt_setting_password
            // 
            txt_setting_password.BackColor = Color.FromArgb(242, 242, 242);
            txt_setting_password.BorderStyle = BorderStyle.None;
            txt_setting_password.Font = new Font("Segoe UI", 12F);
            txt_setting_password.ForeColor = Color.FromArgb(162, 162, 162);
            txt_setting_password.Location = new Point(280, 329);
            txt_setting_password.Margin = new Padding(25);
            txt_setting_password.Name = "txt_setting_password";
            txt_setting_password.PasswordChar = '*';
            txt_setting_password.PlaceholderText = "Password";
            txt_setting_password.Size = new Size(345, 32);
            txt_setting_password.TabIndex = 9;
            txt_setting_password.TextAlign = HorizontalAlignment.Center;
            txt_setting_password.ModifiedChanged += txt_setting_password_ModifiedChanged;
            // 
            // txt_setting_name
            // 
            txt_setting_name.BackColor = Color.FromArgb(242, 242, 242);
            txt_setting_name.BorderStyle = BorderStyle.None;
            txt_setting_name.Font = new Font("Segoe UI", 12F);
            txt_setting_name.ForeColor = Color.FromArgb(162, 162, 162);
            txt_setting_name.Location = new Point(280, 119);
            txt_setting_name.Margin = new Padding(25);
            txt_setting_name.Name = "txt_setting_name";
            txt_setting_name.PlaceholderText = "Name";
            txt_setting_name.Size = new Size(345, 32);
            txt_setting_name.TabIndex = 8;
            txt_setting_name.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_setting_userName
            // 
            txt_setting_userName.BackColor = Color.FromArgb(242, 242, 242);
            txt_setting_userName.BorderStyle = BorderStyle.None;
            txt_setting_userName.Enabled = false;
            txt_setting_userName.Font = new Font("Segoe UI", 12F);
            txt_setting_userName.ForeColor = Color.FromArgb(162, 162, 162);
            txt_setting_userName.Location = new Point(280, 60);
            txt_setting_userName.Margin = new Padding(25);
            txt_setting_userName.Name = "txt_setting_userName";
            txt_setting_userName.PlaceholderText = "User Name";
            txt_setting_userName.Size = new Size(345, 32);
            txt_setting_userName.TabIndex = 7;
            txt_setting_userName.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_setting_saveChanges
            // 
            btn_setting_saveChanges.BackColor = Color.FromArgb(105, 98, 210);
            btn_setting_saveChanges.Cursor = Cursors.Hand;
            btn_setting_saveChanges.FlatAppearance.BorderSize = 0;
            btn_setting_saveChanges.FlatStyle = FlatStyle.Flat;
            btn_setting_saveChanges.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_setting_saveChanges.ForeColor = Color.White;
            btn_setting_saveChanges.Location = new Point(280, 473);
            btn_setting_saveChanges.Name = "btn_setting_saveChanges";
            btn_setting_saveChanges.Size = new Size(345, 57);
            btn_setting_saveChanges.TabIndex = 6;
            btn_setting_saveChanges.Text = "Save Changes";
            btn_setting_saveChanges.UseVisualStyleBackColor = false;
            btn_setting_saveChanges.Click += btn_setting_saveChanges_Click;
            // 
            // lbl_setting_repassword
            // 
            lbl_setting_repassword.AutoSize = true;
            lbl_setting_repassword.Font = new Font("Segoe UI", 10F);
            lbl_setting_repassword.Location = new Point(41, 398);
            lbl_setting_repassword.Name = "lbl_setting_repassword";
            lbl_setting_repassword.Size = new Size(162, 28);
            lbl_setting_repassword.TabIndex = 5;
            lbl_setting_repassword.Text = "Retype Password:";
            // 
            // lbl_setting_password
            // 
            lbl_setting_password.AutoSize = true;
            lbl_setting_password.Font = new Font("Segoe UI", 10F);
            lbl_setting_password.Location = new Point(41, 335);
            lbl_setting_password.Name = "lbl_setting_password";
            lbl_setting_password.Size = new Size(97, 28);
            lbl_setting_password.TabIndex = 4;
            lbl_setting_password.Text = "Password:";
            // 
            // lbl_setting_joinDate
            // 
            lbl_setting_joinDate.AutoSize = true;
            lbl_setting_joinDate.Font = new Font("Segoe UI", 10F);
            lbl_setting_joinDate.Location = new Point(44, 266);
            lbl_setting_joinDate.Name = "lbl_setting_joinDate";
            lbl_setting_joinDate.Size = new Size(97, 28);
            lbl_setting_joinDate.TabIndex = 3;
            lbl_setting_joinDate.Text = "Join Date:";
            // 
            // lbl_setting_birthdate
            // 
            lbl_setting_birthdate.AutoSize = true;
            lbl_setting_birthdate.Font = new Font("Segoe UI", 10F);
            lbl_setting_birthdate.Location = new Point(43, 196);
            lbl_setting_birthdate.Name = "lbl_setting_birthdate";
            lbl_setting_birthdate.Size = new Size(51, 28);
            lbl_setting_birthdate.TabIndex = 2;
            lbl_setting_birthdate.Text = "Age:";
            // 
            // lbl_setting_userName
            // 
            lbl_setting_userName.AutoSize = true;
            lbl_setting_userName.Font = new Font("Segoe UI", 10F);
            lbl_setting_userName.Location = new Point(30, 65);
            lbl_setting_userName.Name = "lbl_setting_userName";
            lbl_setting_userName.Size = new Size(112, 28);
            lbl_setting_userName.TabIndex = 0;
            lbl_setting_userName.Text = "User Name:";
            // 
            // gb_setting
            // 
            gb_setting.BackgroundImageLayout = ImageLayout.None;
            gb_setting.Controls.Add(lbl_changeStatus);
            gb_setting.Controls.Add(txt_joinDate);
            gb_setting.Controls.Add(txt_setting_age);
            gb_setting.Controls.Add(txt_setting_repassword);
            gb_setting.Controls.Add(txt_setting_password);
            gb_setting.Controls.Add(txt_setting_name);
            gb_setting.Controls.Add(txt_setting_userName);
            gb_setting.Controls.Add(btn_setting_saveChanges);
            gb_setting.Controls.Add(lbl_setting_repassword);
            gb_setting.Controls.Add(lbl_setting_password);
            gb_setting.Controls.Add(lbl_setting_joinDate);
            gb_setting.Controls.Add(lbl_setting_birthdate);
            gb_setting.Controls.Add(lbl_setting_name);
            gb_setting.Controls.Add(lbl_setting_userName);
            gb_setting.FlatStyle = FlatStyle.Flat;
            gb_setting.Location = new Point(374, 107);
            gb_setting.Name = "gb_setting";
            gb_setting.Size = new Size(948, 553);
            gb_setting.TabIndex = 16;
            gb_setting.TabStop = false;
            gb_setting.Text = "Setting";
            // 
            // lbl_changeStatus
            // 
            lbl_changeStatus.AutoSize = true;
            lbl_changeStatus.Location = new Point(280, 441);
            lbl_changeStatus.Name = "lbl_changeStatus";
            lbl_changeStatus.Size = new Size(0, 25);
            lbl_changeStatus.TabIndex = 13;
            // 
            // lbl_setting_name
            // 
            lbl_setting_name.AutoSize = true;
            lbl_setting_name.Font = new Font("Segoe UI", 10F);
            lbl_setting_name.Location = new Point(41, 125);
            lbl_setting_name.Name = "lbl_setting_name";
            lbl_setting_name.Size = new Size(68, 28);
            lbl_setting_name.TabIndex = 1;
            lbl_setting_name.Text = "Name:";
            // 
            // flp
            // 
            flp.BackColor = Color.FromArgb(105, 98, 210);
            flp.Controls.Add(panel_logo);
            flp.Controls.Add(panel_home);
            flp.Controls.Add(panel_about);
            flp.Controls.Add(panel_help);
            flp.Controls.Add(panel_addNew);
            flp.Controls.Add(panel_setting);
            flp.Dock = DockStyle.Left;
            flp.Location = new Point(0, 0);
            flp.Name = "flp";
            flp.Size = new Size(356, 672);
            flp.TabIndex = 11;
            // 
            // panel_logo
            // 
            panel_logo.Controls.Add(lbl_logo);
            panel_logo.Location = new Point(3, 3);
            panel_logo.Name = "panel_logo";
            panel_logo.Size = new Size(353, 167);
            panel_logo.TabIndex = 0;
            // 
            // lbl_logo
            // 
            lbl_logo.AutoSize = true;
            lbl_logo.Font = new Font("Showcard Gothic", 16F, FontStyle.Bold);
            lbl_logo.ForeColor = Color.White;
            lbl_logo.Location = new Point(57, 43);
            lbl_logo.Name = "lbl_logo";
            lbl_logo.Size = new Size(220, 80);
            lbl_logo.TabIndex = 3;
            lbl_logo.Text = "Nexus\r\nNarratives\r\n";
            lbl_logo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_home
            // 
            panel_home.Controls.Add(btn_home);
            panel_home.Location = new Point(3, 176);
            panel_home.Name = "panel_home";
            panel_home.Size = new Size(353, 85);
            panel_home.TabIndex = 1;
            // 
            // btn_home
            // 
            btn_home.FlatStyle = FlatStyle.Flat;
            btn_home.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_home.ForeColor = Color.White;
            btn_home.Image = (Image)resources.GetObject("btn_home.Image");
            btn_home.ImageAlign = ContentAlignment.MiddleLeft;
            btn_home.Location = new Point(-5, -16);
            btn_home.Name = "btn_home";
            btn_home.Padding = new Padding(25, 0, 0, 0);
            btn_home.Size = new Size(365, 111);
            btn_home.TabIndex = 3;
            btn_home.Text = "   Home";
            btn_home.TextAlign = ContentAlignment.MiddleLeft;
            btn_home.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_home.UseVisualStyleBackColor = true;
            btn_home.Click += btn_home_Click;
            // 
            // panel_about
            // 
            panel_about.Controls.Add(btn_about);
            panel_about.Location = new Point(3, 267);
            panel_about.Name = "panel_about";
            panel_about.Size = new Size(353, 85);
            panel_about.TabIndex = 3;
            // 
            // btn_about
            // 
            btn_about.FlatStyle = FlatStyle.Flat;
            btn_about.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_about.ForeColor = Color.White;
            btn_about.Image = (Image)resources.GetObject("btn_about.Image");
            btn_about.ImageAlign = ContentAlignment.MiddleLeft;
            btn_about.Location = new Point(-5, -13);
            btn_about.Name = "btn_about";
            btn_about.Padding = new Padding(25, 0, 0, 0);
            btn_about.Size = new Size(365, 111);
            btn_about.TabIndex = 6;
            btn_about.Text = "   About";
            btn_about.TextAlign = ContentAlignment.MiddleLeft;
            btn_about.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_about.UseVisualStyleBackColor = true;
            btn_about.Click += btn_about_Click;
            // 
            // panel_help
            // 
            panel_help.Controls.Add(btn_help);
            panel_help.Location = new Point(3, 358);
            panel_help.Name = "panel_help";
            panel_help.Size = new Size(353, 85);
            panel_help.TabIndex = 4;
            // 
            // btn_help
            // 
            btn_help.FlatStyle = FlatStyle.Flat;
            btn_help.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_help.ForeColor = Color.White;
            btn_help.Image = (Image)resources.GetObject("btn_help.Image");
            btn_help.ImageAlign = ContentAlignment.MiddleLeft;
            btn_help.Location = new Point(-8, -15);
            btn_help.Name = "btn_help";
            btn_help.Padding = new Padding(25, 0, 0, 0);
            btn_help.Size = new Size(373, 111);
            btn_help.TabIndex = 5;
            btn_help.Text = "   Help";
            btn_help.TextAlign = ContentAlignment.MiddleLeft;
            btn_help.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_help.UseVisualStyleBackColor = true;
            btn_help.Click += btn_help_Click;
            // 
            // panel_addNew
            // 
            panel_addNew.Controls.Add(btn_addNew);
            panel_addNew.Location = new Point(3, 449);
            panel_addNew.Name = "panel_addNew";
            panel_addNew.Size = new Size(353, 85);
            panel_addNew.TabIndex = 5;
            // 
            // btn_addNew
            // 
            btn_addNew.BackgroundImageLayout = ImageLayout.None;
            btn_addNew.FlatStyle = FlatStyle.Flat;
            btn_addNew.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_addNew.ForeColor = Color.White;
            btn_addNew.Image = (Image)resources.GetObject("btn_addNew.Image");
            btn_addNew.ImageAlign = ContentAlignment.MiddleLeft;
            btn_addNew.Location = new Point(-8, -13);
            btn_addNew.Name = "btn_addNew";
            btn_addNew.Padding = new Padding(25, 0, 0, 0);
            btn_addNew.Size = new Size(369, 111);
            btn_addNew.TabIndex = 4;
            btn_addNew.Text = "   Add New";
            btn_addNew.TextAlign = ContentAlignment.MiddleLeft;
            btn_addNew.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_addNew.UseVisualStyleBackColor = true;
            btn_addNew.Click += btn_addNew_Click;
            // 
            // panel_setting
            // 
            panel_setting.Controls.Add(btn_setting);
            panel_setting.Location = new Point(3, 540);
            panel_setting.Name = "panel_setting";
            panel_setting.Size = new Size(353, 85);
            panel_setting.TabIndex = 2;
            // 
            // btn_setting
            // 
            btn_setting.FlatStyle = FlatStyle.Flat;
            btn_setting.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_setting.ForeColor = Color.White;
            btn_setting.Image = (Image)resources.GetObject("btn_setting.Image");
            btn_setting.ImageAlign = ContentAlignment.MiddleLeft;
            btn_setting.Location = new Point(-5, -14);
            btn_setting.Name = "btn_setting";
            btn_setting.Padding = new Padding(25, 0, 0, 0);
            btn_setting.Size = new Size(373, 111);
            btn_setting.TabIndex = 6;
            btn_setting.Text = "   Setting";
            btn_setting.TextAlign = ContentAlignment.MiddleLeft;
            btn_setting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_setting.UseVisualStyleBackColor = true;
            // 
            // close_btn
            // 
            close_btn.BackColor = Color.Transparent;
            close_btn.Cursor = Cursors.Hand;
            close_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close_btn.ForeColor = Color.FromArgb(126, 126, 126);
            close_btn.Location = new Point(1272, 12);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(50, 50);
            close_btn.TabIndex = 10;
            close_btn.Text = "X";
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += close_btn_Click;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            lbl_username.ForeColor = Color.FromArgb(105, 98, 210);
            lbl_username.Location = new Point(832, 23);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(0, 37);
            lbl_username.TabIndex = 19;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_name.ForeColor = Color.FromArgb(105, 98, 210);
            lbl_name.Location = new Point(437, 23);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(0, 42);
            lbl_name.TabIndex = 18;
            // 
            // lbl_hi
            // 
            lbl_hi.AutoSize = true;
            lbl_hi.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_hi.ForeColor = Color.FromArgb(105, 98, 210);
            lbl_hi.Location = new Point(376, 22);
            lbl_hi.Name = "lbl_hi";
            lbl_hi.Size = new Size(72, 42);
            lbl_hi.TabIndex = 17;
            lbl_hi.Text = "Hi, ";
            // 
            // btn_logOut
            // 
            btn_logOut.BackColor = Color.FromArgb(105, 98, 210);
            btn_logOut.Cursor = Cursors.Hand;
            btn_logOut.FlatAppearance.BorderSize = 0;
            btn_logOut.FlatStyle = FlatStyle.Flat;
            btn_logOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_logOut.ForeColor = Color.White;
            btn_logOut.Image = (Image)resources.GetObject("btn_logOut.Image");
            btn_logOut.Location = new Point(1176, 14);
            btn_logOut.Name = "btn_logOut";
            btn_logOut.Size = new Size(56, 48);
            btn_logOut.TabIndex = 31;
            btn_logOut.UseVisualStyleBackColor = false;
            btn_logOut.Click += btn_logOut_Click;
            // 
            // Setting
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(1334, 672);
            Controls.Add(btn_logOut);
            Controls.Add(lbl_username);
            Controls.Add(lbl_name);
            Controls.Add(lbl_hi);
            Controls.Add(gb_setting);
            Controls.Add(flp);
            Controls.Add(close_btn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Setting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Setting";
            Load += Setting_Load;
            gb_setting.ResumeLayout(false);
            gb_setting.PerformLayout();
            flp.ResumeLayout(false);
            panel_logo.ResumeLayout(false);
            panel_logo.PerformLayout();
            panel_home.ResumeLayout(false);
            panel_about.ResumeLayout(false);
            panel_help.ResumeLayout(false);
            panel_addNew.ResumeLayout(false);
            panel_setting.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_joinDate;
        private TextBox txt_setting_age;
        private TextBox txt_setting_repassword;
        private TextBox txt_setting_password;
        private TextBox txt_setting_name;
        private TextBox txt_setting_userName;
        private Button btn_setting_saveChanges;
        private Label lbl_setting_repassword;
        private Label lbl_setting_password;
        private Label lbl_setting_joinDate;
        private Label lbl_setting_birthdate;
        private Label lbl_setting_userName;
        private GroupBox gb_setting;
        private Label lbl_setting_name;
        private Label lbl_username;
        private Label lbl_name;
        private FlowLayoutPanel flp;
        private Panel panel_logo;
        private Label lbl_logo;
        private Panel panel_home;
        private Button btn_home;
        private Panel panel_about;
        private Button btn_about;
        private Panel panel_help;
        private Button btn_help;
        private Panel panel_addNew;
        private Button btn_addNew;
        private Panel panel_setting;
        private Button btn_setting;
        private Button close_btn;
        private Label lbl_hi;
        private Label lbl_changeStatus;
        private Button btn_logOut;
    }
}