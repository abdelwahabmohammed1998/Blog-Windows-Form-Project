namespace Blog_Project
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            close_btn = new Button();
            flp = new FlowLayoutPanel();
            panel_logo = new Panel();
            lbl_logo = new Label();
            panel_home = new Panel();
            btn_home = new Button();
            panel_about = new Panel();
            button2 = new Button();
            btn_about = new Button();
            panel_help = new Panel();
            btn_help = new Button();
            panel_addNew = new Panel();
            btn_addNew = new Button();
            panel_setting = new Panel();
            btn_setting = new Button();
            dgv_news = new DataGridView();
            lbl_allNews = new Label();
            gb_home = new GroupBox();
            lbl_username = new Label();
            lbl_name = new Label();
            lbl_hi = new Label();
            btn_logOut = new Button();
            flp.SuspendLayout();
            panel_logo.SuspendLayout();
            panel_home.SuspendLayout();
            panel_about.SuspendLayout();
            panel_help.SuspendLayout();
            panel_addNew.SuspendLayout();
            panel_setting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_news).BeginInit();
            gb_home.SuspendLayout();
            SuspendLayout();
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
            close_btn.TabIndex = 1;
            close_btn.Text = "X";
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += close_btn_Click;
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
            flp.TabIndex = 2;
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
            panel_about.Controls.Add(button2);
            panel_about.Controls.Add(btn_about);
            panel_about.Location = new Point(3, 267);
            panel_about.Name = "panel_about";
            panel_about.Size = new Size(353, 85);
            panel_about.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 540);
            button2.Name = "button2";
            button2.Padding = new Padding(25, 0, 0, 0);
            button2.Size = new Size(353, 111);
            button2.TabIndex = 4;
            button2.Text = "   Setting";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
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
            btn_setting.Click += btn_setting_Click;
            // 
            // dgv_news
            // 
            dgv_news.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_news.BackgroundColor = Color.White;
            dgv_news.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(85, 100, 200);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(105, 98, 210);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_news.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_news.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(105, 98, 210);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(100, 100, 180);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_news.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_news.Dock = DockStyle.Bottom;
            dgv_news.GridColor = Color.White;
            dgv_news.Location = new Point(3, 125);
            dgv_news.Name = "dgv_news";
            dgv_news.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_news.RowHeadersWidth = 32;
            dgv_news.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_news.RowTemplate.Height = 65;
            dgv_news.ShowCellErrors = false;
            dgv_news.Size = new Size(936, 452);
            dgv_news.TabIndex = 3;
            dgv_news.RowHeaderMouseDoubleClick += dgv_news_RowHeaderMouseDoubleClick;
            // 
            // lbl_allNews
            // 
            lbl_allNews.AutoSize = true;
            lbl_allNews.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_allNews.ForeColor = Color.Black;
            lbl_allNews.Location = new Point(396, 60);
            lbl_allNews.Name = "lbl_allNews";
            lbl_allNews.Size = new Size(159, 42);
            lbl_allNews.TabIndex = 7;
            lbl_allNews.Text = "All News";
            // 
            // gb_home
            // 
            gb_home.BackgroundImageLayout = ImageLayout.None;
            gb_home.Controls.Add(lbl_allNews);
            gb_home.Controls.Add(dgv_news);
            gb_home.FlatStyle = FlatStyle.Flat;
            gb_home.Location = new Point(380, 80);
            gb_home.Name = "gb_home";
            gb_home.Size = new Size(942, 580);
            gb_home.TabIndex = 8;
            gb_home.TabStop = false;
            gb_home.Text = "Home";
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            lbl_username.ForeColor = Color.FromArgb(105, 98, 210);
            lbl_username.Location = new Point(836, 17);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(0, 37);
            lbl_username.TabIndex = 6;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_name.ForeColor = Color.FromArgb(105, 98, 210);
            lbl_name.Location = new Point(441, 23);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(0, 42);
            lbl_name.TabIndex = 5;
            // 
            // lbl_hi
            // 
            lbl_hi.AutoSize = true;
            lbl_hi.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_hi.ForeColor = Color.FromArgb(105, 98, 210);
            lbl_hi.Location = new Point(380, 22);
            lbl_hi.Name = "lbl_hi";
            lbl_hi.Size = new Size(72, 42);
            lbl_hi.TabIndex = 4;
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
            btn_logOut.Location = new Point(1191, 13);
            btn_logOut.Name = "btn_logOut";
            btn_logOut.Size = new Size(56, 48);
            btn_logOut.TabIndex = 32;
            btn_logOut.UseVisualStyleBackColor = false;
            btn_logOut.Click += btn_logOut_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1334, 672);
            Controls.Add(btn_logOut);
            Controls.Add(lbl_username);
            Controls.Add(lbl_name);
            Controls.Add(lbl_hi);
            Controls.Add(flp);
            Controls.Add(close_btn);
            Controls.Add(gb_home);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nexus";
            Load += Home_Load;
            flp.ResumeLayout(false);
            panel_logo.ResumeLayout(false);
            panel_logo.PerformLayout();
            panel_home.ResumeLayout(false);
            panel_about.ResumeLayout(false);
            panel_help.ResumeLayout(false);
            panel_addNew.ResumeLayout(false);
            panel_setting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_news).EndInit();
            gb_home.ResumeLayout(false);
            gb_home.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button close_btn;
        private FlowLayoutPanel flp;
        private Panel panel_logo;
        private Label lbl_logo;
        private Button btn_home;
        private Button btn_help;
        private Button btn_addNew;
        private Panel panel_about;
        private Panel panel_help;
        private Panel panel_addNew;
        private Button btn_setting;
        private Panel panel_setting;
        private Panel panel_home;
        private Button button2;
        private DataGridView dgv_news;
        private Label lbl_allNews;
        private Button btn_about;
        private GroupBox gb_home;
        private Label lbl_username;
        private Label lbl_name;
        private Label lbl_hi;
        private Button btn_logOut;
    }
}