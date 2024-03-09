namespace Blog_Project
{
    partial class AddNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNew));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            gb_setting = new GroupBox();
            cb_cats = new ComboBox();
            label3 = new Label();
            rtb_postDesc = new RichTextBox();
            label2 = new Label();
            txt_postBrief = new TextBox();
            label1 = new Label();
            txt_postTitle = new TextBox();
            lbl_setting_userName = new Label();
            lbl_logo = new Label();
            panel_logo = new Panel();
            lbl_name = new Label();
            flp = new FlowLayoutPanel();
            close_btn = new Button();
            groupBox1 = new GroupBox();
            dgv_news = new DataGridView();
            btn_createPost = new Button();
            btn_deletePost = new Button();
            btn_updatePost = new Button();
            lbl_postStatus = new Label();
            btn_logOut = new Button();
            panel_setting.SuspendLayout();
            panel_addNew.SuspendLayout();
            panel_help.SuspendLayout();
            panel_about.SuspendLayout();
            panel_home.SuspendLayout();
            gb_setting.SuspendLayout();
            panel_logo.SuspendLayout();
            flp.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_news).BeginInit();
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
            // gb_setting
            // 
            gb_setting.BackgroundImageLayout = ImageLayout.None;
            gb_setting.Controls.Add(cb_cats);
            gb_setting.Controls.Add(label3);
            gb_setting.Controls.Add(rtb_postDesc);
            gb_setting.Controls.Add(label2);
            gb_setting.Controls.Add(txt_postBrief);
            gb_setting.Controls.Add(label1);
            gb_setting.Controls.Add(txt_postTitle);
            gb_setting.Controls.Add(lbl_setting_userName);
            gb_setting.FlatStyle = FlatStyle.Flat;
            gb_setting.Location = new Point(380, 107);
            gb_setting.Name = "gb_setting";
            gb_setting.Size = new Size(948, 389);
            gb_setting.TabIndex = 22;
            gb_setting.TabStop = false;
            gb_setting.Text = "Add New Post";
            // 
            // cb_cats
            // 
            cb_cats.BackColor = Color.FromArgb(242, 242, 242);
            cb_cats.FlatStyle = FlatStyle.Flat;
            cb_cats.ForeColor = Color.FromArgb(162, 162, 162);
            cb_cats.FormattingEnabled = true;
            cb_cats.Location = new Point(371, 197);
            cb_cats.Name = "cb_cats";
            cb_cats.Size = new Size(441, 33);
            cb_cats.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(18, 202);
            label3.Name = "label3";
            label3.Size = new Size(138, 28);
            label3.TabIndex = 14;
            label3.Text = "Post Category:";
            // 
            // rtb_postDesc
            // 
            rtb_postDesc.BackColor = Color.FromArgb(242, 242, 242);
            rtb_postDesc.BorderStyle = BorderStyle.None;
            rtb_postDesc.Font = new Font("Segoe UI", 12F);
            rtb_postDesc.ForeColor = Color.FromArgb(162, 162, 162);
            rtb_postDesc.Location = new Point(371, 251);
            rtb_postDesc.Name = "rtb_postDesc";
            rtb_postDesc.Size = new Size(441, 116);
            rtb_postDesc.TabIndex = 13;
            rtb_postDesc.Text = "Post Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(27, 296);
            label2.Name = "label2";
            label2.Size = new Size(158, 28);
            label2.TabIndex = 12;
            label2.Text = "Post Description:";
            // 
            // txt_postBrief
            // 
            txt_postBrief.BackColor = Color.FromArgb(242, 242, 242);
            txt_postBrief.BorderStyle = BorderStyle.None;
            txt_postBrief.Font = new Font("Segoe UI", 12F);
            txt_postBrief.ForeColor = Color.FromArgb(162, 162, 162);
            txt_postBrief.Location = new Point(371, 132);
            txt_postBrief.Margin = new Padding(25);
            txt_postBrief.Name = "txt_postBrief";
            txt_postBrief.PlaceholderText = "Post Brief";
            txt_postBrief.Size = new Size(441, 32);
            txt_postBrief.TabIndex = 11;
            txt_postBrief.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(18, 132);
            label1.Name = "label1";
            label1.Size = new Size(97, 28);
            label1.TabIndex = 10;
            label1.Text = "Post Brief:";
            // 
            // txt_postTitle
            // 
            txt_postTitle.BackColor = Color.FromArgb(242, 242, 242);
            txt_postTitle.BorderStyle = BorderStyle.None;
            txt_postTitle.Font = new Font("Segoe UI", 12F);
            txt_postTitle.ForeColor = Color.FromArgb(162, 162, 162);
            txt_postTitle.Location = new Point(371, 59);
            txt_postTitle.Margin = new Padding(25);
            txt_postTitle.Name = "txt_postTitle";
            txt_postTitle.PlaceholderText = "Post Title";
            txt_postTitle.Size = new Size(441, 32);
            txt_postTitle.TabIndex = 9;
            txt_postTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_setting_userName
            // 
            lbl_setting_userName.AutoSize = true;
            lbl_setting_userName.Font = new Font("Segoe UI", 10F);
            lbl_setting_userName.Location = new Point(18, 59);
            lbl_setting_userName.Name = "lbl_setting_userName";
            lbl_setting_userName.Size = new Size(95, 28);
            lbl_setting_userName.TabIndex = 8;
            lbl_setting_userName.Text = "Post Title:";
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
            flp.Size = new Size(356, 830);
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
            // groupBox1
            // 
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(dgv_news);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(382, 577);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(946, 241);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Your Own Posts";
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
            dgv_news.Location = new Point(3, 44);
            dgv_news.Name = "dgv_news";
            dgv_news.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_news.RowHeadersWidth = 32;
            dgv_news.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_news.RowTemplate.Height = 65;
            dgv_news.ShowCellErrors = false;
            dgv_news.Size = new Size(940, 194);
            dgv_news.TabIndex = 4;
            dgv_news.RowHeaderMouseDoubleClick += dgv_news_RowHeaderMouseDoubleClick;
            // 
            // btn_createPost
            // 
            btn_createPost.BackColor = Color.FromArgb(105, 98, 210);
            btn_createPost.Cursor = Cursors.Hand;
            btn_createPost.FlatAppearance.BorderSize = 0;
            btn_createPost.FlatStyle = FlatStyle.Flat;
            btn_createPost.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_createPost.ForeColor = Color.White;
            btn_createPost.Location = new Point(1064, 515);
            btn_createPost.Name = "btn_createPost";
            btn_createPost.Size = new Size(254, 57);
            btn_createPost.TabIndex = 26;
            btn_createPost.Text = "Create Post";
            btn_createPost.UseVisualStyleBackColor = false;
            btn_createPost.Click += btn_createPost_Click;
            // 
            // btn_deletePost
            // 
            btn_deletePost.BackColor = Color.Red;
            btn_deletePost.Cursor = Cursors.Hand;
            btn_deletePost.FlatAppearance.BorderSize = 0;
            btn_deletePost.FlatStyle = FlatStyle.Flat;
            btn_deletePost.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_deletePost.ForeColor = Color.White;
            btn_deletePost.Location = new Point(804, 515);
            btn_deletePost.Name = "btn_deletePost";
            btn_deletePost.Size = new Size(254, 57);
            btn_deletePost.TabIndex = 27;
            btn_deletePost.Text = "Delete Post";
            btn_deletePost.UseVisualStyleBackColor = false;
            btn_deletePost.Visible = false;
            btn_deletePost.Click += btn_deletePost_Click;
            // 
            // btn_updatePost
            // 
            btn_updatePost.BackColor = Color.FromArgb(105, 98, 210);
            btn_updatePost.Cursor = Cursors.Hand;
            btn_updatePost.FlatAppearance.BorderSize = 0;
            btn_updatePost.FlatStyle = FlatStyle.Flat;
            btn_updatePost.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_updatePost.ForeColor = Color.White;
            btn_updatePost.Location = new Point(1070, 515);
            btn_updatePost.Name = "btn_updatePost";
            btn_updatePost.Size = new Size(254, 57);
            btn_updatePost.TabIndex = 28;
            btn_updatePost.Text = "Update Post";
            btn_updatePost.UseVisualStyleBackColor = false;
            btn_updatePost.Visible = false;
            btn_updatePost.Click += btn_updatePost_Click;
            // 
            // lbl_postStatus
            // 
            lbl_postStatus.AutoSize = true;
            lbl_postStatus.Location = new Point(382, 533);
            lbl_postStatus.Name = "lbl_postStatus";
            lbl_postStatus.Size = new Size(0, 25);
            lbl_postStatus.TabIndex = 29;
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
            btn_logOut.Location = new Point(1195, 16);
            btn_logOut.Name = "btn_logOut";
            btn_logOut.Size = new Size(56, 48);
            btn_logOut.TabIndex = 30;
            btn_logOut.UseVisualStyleBackColor = false;
            btn_logOut.Click += btn_logOut_Click;
            // 
            // AddNew
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1334, 830);
            Controls.Add(btn_logOut);
            Controls.Add(lbl_postStatus);
            Controls.Add(btn_updatePost);
            Controls.Add(btn_deletePost);
            Controls.Add(btn_createPost);
            Controls.Add(groupBox1);
            Controls.Add(lbl_username);
            Controls.Add(lbl_hi);
            Controls.Add(gb_setting);
            Controls.Add(lbl_name);
            Controls.Add(flp);
            Controls.Add(close_btn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddNew";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNew";
            Load += AddNew_Load;
            panel_setting.ResumeLayout(false);
            panel_addNew.ResumeLayout(false);
            panel_help.ResumeLayout(false);
            panel_about.ResumeLayout(false);
            panel_home.ResumeLayout(false);
            gb_setting.ResumeLayout(false);
            gb_setting.PerformLayout();
            panel_logo.ResumeLayout(false);
            panel_logo.PerformLayout();
            flp.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_news).EndInit();
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
        private GroupBox gb_setting;
        private Label lbl_logo;
        private Panel panel_logo;
        private Label lbl_name;
        private FlowLayoutPanel flp;
        private Button close_btn;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txt_postBrief;
        private Label label1;
        private TextBox txt_postTitle;
        private Label lbl_setting_userName;
        private RichTextBox rtb_postDesc;
        private Button btn_createPost;
        private Button btn_deletePost;
        private Button btn_updatePost;
        private DataGridView dgv_news;
        private Label label3;
        private ComboBox cb_cats;
        private Label lbl_postStatus;
        private Button btn_logOut;
    }
}