using Blog_Project.Models;

namespace Blog_Project
{
    public partial class Home : Form
    {
        BlogContext blogData = new BlogContext();
        string loggedUserName;
        public Home(string userName)
        {
            InitializeComponent();
            loggedUserName = userName;
        }
        private void close_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Home_Load(object sender, EventArgs e)
        {

            dgv_news.DataSource = blogData.News.Select(post => new
            {
                Post_ID = post.Id,
                Post_Title = post.title,
                Blog_Breif = post.bref,
                Blog_Author = post.Author.name,
                Blog_PuplishedTime = post.date,
                Blog_Cat = post.Catalog.name

            }).ToList();
            var userData = blogData.Authors.Where(usr => usr.userName == loggedUserName)
                .FirstOrDefault();
            if (loggedUserName != null)
            {
                lbl_name.Text = userData.name;
                lbl_username.Text = $"({userData.userName})";
            }
            else
            {
                lbl_name.Text = "Guest";
                panel_setting.Visible = false;
                panel_addNew.Visible = false;
            }
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            if (loggedUserName != null)
            {
                Pravicy pravicy = new Pravicy(loggedUserName, "About", $"This is a blog project for the course of Database Systems. \n\nDeveloped by:Abdelwahab Mohamed\n");
                pravicy.Show();
                this.Hide();
            }
            else
            {
                Pravicy pravicy = new Pravicy(null, "About", $"This is a blog project for the course of Database Systems. \n\nDeveloped by:Abdelwahab Mohamed\n");
                pravicy.Show();
                this.Hide();
            }

        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            if (loggedUserName != null)
            {
                Pravicy pravicy = new Pravicy(loggedUserName, "Help", $"This is a blog project for the course of Database Systems. \n\nDeveloped by:Abdelwahab Mohamed\n");
                pravicy.Show();
                this.Hide();
            }
            else
            {
                Pravicy pravicy = new Pravicy(null, "Help", $"This is a blog project for the course of Database Systems. \n\nDeveloped by:Abdelwahab Mohamed\n");
                pravicy.Show();
                this.Hide();

            }
        }
        int postId;
        private void dgv_news_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            postId = Convert.ToInt32(dgv_news.Rows[e.RowIndex].Cells[0].Value);
            PostDetails postDetails = new PostDetails(loggedUserName ?? null, postId);
            postDetails.Show();
            this.Hide();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting(loggedUserName);
            setting.Show();
            this.Hide();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home home = new Home(loggedUserName);
            home.Show();
            this.Hide();
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            AddNew addNew = new AddNew(loggedUserName);
            addNew.Show(); this.Hide();
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            loggedUserName = null;
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
