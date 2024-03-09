namespace Blog_Project
{
    partial class Pravicy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pravicy));
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
            gb_pravicy = new GroupBox();
            lbl_mssg = new Label();
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
            gb_pravicy.SuspendLayout();
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
            // gb_pravicy
            // 
            gb_pravicy.BackgroundImageLayout = ImageLayout.None;
            gb_pravicy.Controls.Add(lbl_mssg);
            gb_pravicy.FlatStyle = FlatStyle.Flat;
            gb_pravicy.Location = new Point(380, 107);
            gb_pravicy.Name = "gb_pravicy";
            gb_pravicy.Size = new Size(948, 553);
            gb_pravicy.TabIndex = 22;
            gb_pravicy.TabStop = false;
            // 
            // lbl_mssg
            // 
            lbl_mssg.AutoSize = true;
            lbl_mssg.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_mssg.Location = new Point(26, 182);
            lbl_mssg.Name = "lbl_mssg";
            lbl_mssg.Size = new Size(904, 111);
            lbl_mssg.TabIndex = 0;
            lbl_mssg.Text = "This is a blog project for the course of Database Systems.\r\n\r\n Developed by:Abdelwahab Mohamed";
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
            lbl_name.Location = new Point(443, 23);
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
            btn_logOut.Location = new Point(1192, 15);
            btn_logOut.Name = "btn_logOut";
            btn_logOut.Size = new Size(56, 48);
            btn_logOut.TabIndex = 33;
            btn_logOut.UseVisualStyleBackColor = false;
            btn_logOut.Click += btn_logOut_Click;
            // 
            // Pravicy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1334, 672);
            Controls.Add(btn_logOut);
            Controls.Add(lbl_username);
            Controls.Add(lbl_hi);
            Controls.Add(gb_pravicy);
            Controls.Add(lbl_name);
            Controls.Add(flp);
            Controls.Add(close_btn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pravicy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pravicy";
            Load += Pravicy_Load;
            panel_setting.ResumeLayout(false);
            panel_addNew.ResumeLayout(false);
            panel_help.ResumeLayout(false);
            panel_about.ResumeLayout(false);
            panel_home.ResumeLayout(false);
            gb_pravicy.ResumeLayout(false);
            gb_pravicy.PerformLayout();
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
        private GroupBox gb_pravicy;
        private Label lbl_logo;
        private Panel panel_logo;
        private Label lbl_name;
        private FlowLayoutPanel flp;
        private Button close_btn;
        private Label lbl_mssg;
        private Button btn_logOut;
    }
}