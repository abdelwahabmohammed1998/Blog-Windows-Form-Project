namespace Blog_Project
{
    partial class PostDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostDetails));
            lbl_username = new Label();
            lbl_hi = new Label();
            btn_setting = new Button();
            panel_setting = new Panel();
            btn_addNew = new Button();
            panel_addNew = new Panel();
            btn_help = new Button();
            panel_help = new Panel();
            btn_about = new Button();
            panel_about = new Panel();
            btn_home = new Button();
            panel_home = new Panel();
            gb_postDetails = new GroupBox();
            lbl_postdate = new Label();
            lbl_postAuth = new Label();
            lbl_postCat = new Label();
            lbl_postDesc = new Label();
            lbl_postBreif = new Label();
            lbl_postTitle = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lbl_logo = new Label();
            panel_logo = new Panel();
            lbl_name = new Label();
            flp = new FlowLayoutPanel();
            close_btn = new Button();
            btn_logOut = new Button();
            panel_setting.SuspendLayout();
            panel_addNew.SuspendLayout();
            panel_help.SuspendLayout();
            panel_about.SuspendLayout();
            panel_home.SuspendLayout();
            gb_postDetails.SuspendLayout();
            panel_logo.SuspendLayout();
            flp.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            lbl_username.ForeColor = Color.FromArgb(105, 98, 210);
            lbl_username.Location = new Point(838, 23);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(0, 37);
            lbl_username.TabIndex = 25;
            // 
            // lbl_hi
            // 
            lbl_hi.AutoSize = true;
            lbl_hi.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_hi.ForeColor = Color.FromArgb(105, 98, 210);
            lbl_hi.Location = new Point(382, 22);
            lbl_hi.Name = "lbl_hi";
            lbl_hi.Size = new Size(72, 42);
            lbl_hi.TabIndex = 23;
            lbl_hi.Text = "Hi, ";
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
            btn_setting.Click += btn_setting_Click;
            // 
            // panel_setting
            // 
            panel_setting.Controls.Add(btn_setting);
            panel_setting.Location = new Point(3, 540);
            panel_setting.Name = "panel_setting";
            panel_setting.Size = new Size(353, 85);
            panel_setting.TabIndex = 2;
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
            // panel_addNew
            // 
            panel_addNew.Controls.Add(btn_addNew);
            panel_addNew.Location = new Point(3, 449);
            panel_addNew.Name = "panel_addNew";
            panel_addNew.Size = new Size(353, 85);
            panel_addNew.TabIndex = 5;
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
            // panel_help
            // 
            panel_help.Controls.Add(btn_help);
            panel_help.Location = new Point(3, 358);
            panel_help.Name = "panel_help";
            panel_help.Size = new Size(353, 85);
            panel_help.TabIndex = 4;
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
            // panel_about
            // 
            panel_about.Controls.Add(btn_about);
            panel_about.Location = new Point(3, 267);
            panel_about.Name = "panel_about";
            panel_about.Size = new Size(353, 85);
            panel_about.TabIndex = 3;
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
            // panel_home
            // 
            panel_home.Controls.Add(btn_home);
            panel_home.Location = new Point(3, 176);
            panel_home.Name = "panel_home";
            panel_home.Size = new Size(353, 85);
            panel_home.TabIndex = 1;
            // 
            // gb_postDetails
            // 
            gb_postDetails.BackgroundImageLayout = ImageLayout.None;
            gb_postDetails.Controls.Add(lbl_postdate);
            gb_postDetails.Controls.Add(lbl_postAuth);
            gb_postDetails.Controls.Add(lbl_postCat);
            gb_postDetails.Controls.Add(lbl_postDesc);
            gb_postDetails.Controls.Add(lbl_postBreif);
            gb_postDetails.Controls.Add(lbl_postTitle);
            gb_postDetails.Controls.Add(label6);
            gb_postDetails.Controls.Add(label5);
            gb_postDetails.Controls.Add(label4);
            gb_postDetails.Controls.Add(label3);
            gb_postDetails.Controls.Add(label2);
            gb_postDetails.Controls.Add(label1);
            gb_postDetails.FlatStyle = FlatStyle.Flat;
            gb_postDetails.Location = new Point(380, 107);
            gb_postDetails.Name = "gb_postDetails";
            gb_postDetails.Size = new Size(948, 553);
            gb_postDetails.TabIndex = 22;
            gb_postDetails.TabStop = false;
            gb_postDetails.Text = "Post - ";
            // 
            // lbl_postdate
            // 
            lbl_postdate.AutoSize = true;
            lbl_postdate.Location = new Point(408, 342);
            lbl_postdate.Name = "lbl_postdate";
            lbl_postdate.Size = new Size(0, 25);
            lbl_postdate.TabIndex = 14;
            // 
            // lbl_postAuth
            // 
            lbl_postAuth.AutoSize = true;
            lbl_postAuth.Cursor = Cursors.Hand;
            lbl_postAuth.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_postAuth.ForeColor = Color.CornflowerBlue;
            lbl_postAuth.Location = new Point(408, 481);
            lbl_postAuth.Name = "lbl_postAuth";
            lbl_postAuth.Size = new Size(0, 25);
            lbl_postAuth.TabIndex = 13;
            // 
            // lbl_postCat
            // 
            lbl_postCat.AutoSize = true;
            lbl_postCat.Cursor = Cursors.Hand;
            lbl_postCat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_postCat.ForeColor = Color.CornflowerBlue;
            lbl_postCat.Location = new Point(408, 419);
            lbl_postCat.Name = "lbl_postCat";
            lbl_postCat.Size = new Size(0, 25);
            lbl_postCat.TabIndex = 12;
            // 
            // lbl_postDesc
            // 
            lbl_postDesc.AutoSize = true;
            lbl_postDesc.Location = new Point(83, 263);
            lbl_postDesc.Name = "lbl_postDesc";
            lbl_postDesc.Size = new Size(0, 25);
            lbl_postDesc.TabIndex = 8;
            // 
            // lbl_postBreif
            // 
            lbl_postBreif.AutoSize = true;
            lbl_postBreif.Location = new Point(408, 147);
            lbl_postBreif.Name = "lbl_postBreif";
            lbl_postBreif.Size = new Size(0, 25);
            lbl_postBreif.TabIndex = 7;
            // 
            // lbl_postTitle
            // 
            lbl_postTitle.AutoSize = true;
            lbl_postTitle.Location = new Point(408, 69);
            lbl_postTitle.Name = "lbl_postTitle";
            lbl_postTitle.Size = new Size(0, 25);
            lbl_postTitle.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(105, 98, 210);
            label6.Location = new Point(83, 419);
            label6.Name = "label6";
            label6.Size = new Size(149, 28);
            label6.TabIndex = 5;
            label6.Text = "Post Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(105, 98, 210);
            label5.Location = new Point(83, 481);
            label5.Name = "label5";
            label5.Size = new Size(130, 28);
            label5.TabIndex = 4;
            label5.Text = "Post Author:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(105, 98, 210);
            label4.Location = new Point(83, 342);
            label4.Name = "label4";
            label4.Size = new Size(206, 28);
            label4.TabIndex = 3;
            label4.Text = "Post Published Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(105, 98, 210);
            label3.Location = new Point(74, 220);
            label3.Name = "label3";
            label3.Size = new Size(172, 28);
            label3.TabIndex = 2;
            label3.Text = "Post Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(105, 98, 210);
            label2.Location = new Point(74, 147);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 1;
            label2.Text = "Post Brief:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(105, 98, 210);
            label1.Location = new Point(74, 69);
            label1.Name = "label1";
            label1.Size = new Size(106, 28);
            label1.TabIndex = 0;
            label1.Text = "Post Title:";
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
            // panel_logo
            // 
            panel_logo.Controls.Add(lbl_logo);
            panel_logo.Location = new Point(3, 3);
            panel_logo.Name = "panel_logo";
            panel_logo.Size = new Size(353, 167);
            panel_logo.TabIndex = 0;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_name.ForeColor = Color.FromArgb(105, 98, 210);
            lbl_name.Location = new Point(463, 23);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(0, 42);
            lbl_name.TabIndex = 24;
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
            flp.TabIndex = 21;
            // 
            // close_btn
            // 
            close_btn.BackColor = Color.Transparent;
            close_btn.Cursor = Cursors.Hand;
            close_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close_btn.ForeColor = Color.FromArgb(126, 126, 126);
            close_btn.Location = new Point(1278, 12);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(50, 50);
            close_btn.TabIndex = 20;
            close_btn.Text = "X";
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += close_btn_Click;
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
            btn_logOut.Location = new Point(1194, 14);
            btn_logOut.Name = "btn_logOut";
            btn_logOut.Size = new Size(56, 48);
            btn_logOut.TabIndex = 31;
            btn_logOut.UseVisualStyleBackColor = false;
            btn_logOut.Click += btn_logOut_Click;
            // 
            // PostDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1334, 672);
            Controls.Add(btn_logOut);
            Controls.Add(lbl_username);
            Controls.Add(lbl_hi);
            Controls.Add(gb_postDetails);
            Controls.Add(lbl_name);
            Controls.Add(flp);
            Controls.Add(close_btn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PostDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PostDetails";
            Load += PostDetails_Load;
            panel_setting.ResumeLayout(false);
            panel_addNew.ResumeLayout(false);
            panel_help.ResumeLayout(false);
            panel_about.ResumeLayout(false);
            panel_home.ResumeLayout(false);
            gb_postDetails.ResumeLayout(false);
            gb_postDetails.PerformLayout();
            panel_logo.ResumeLayout(false);
            panel_logo.PerformLayout();
            flp.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_username;
        private Label lbl_hi;
        private Button btn_setting;
        private Panel panel_setting;
        private Button btn_addNew;
        private Panel panel_addNew;
        private Button btn_help;
        private Panel panel_help;
        private Button btn_about;
        private Panel panel_about;
        private Button btn_home;
        private Panel panel_home;
        private GroupBox gb_postDetails;
        private Label lbl_logo;
        private Panel panel_logo;
        private Label lbl_name;
        private FlowLayoutPanel flp;
        private Button close_btn;
        private Label lbl_postTitle;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lbl_postDesc;
        private Label lbl_postBreif;
        private Label lbl_postdate;
        private Label lbl_postAuth;
        private Label lbl_postCat;
        private Button btn_logOut;
    }
}