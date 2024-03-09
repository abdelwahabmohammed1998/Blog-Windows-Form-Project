using Blog_Project.Models;
using System.Data;

namespace Blog_Project
{
    public partial class AddNew : Form
    {
        string loggedUserName;
        BlogContext blogData = new BlogContext();
        int currentId;
        public AddNew(string userName)
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

        private void AddNew_Load(object sender, EventArgs e)
        {
            FillData();
            var postCat = blogData.Catalogs.Select(cat => cat).ToList();
            cb_cats.DataSource = postCat;
            cb_cats.DisplayMember = "name";
            cb_cats.ValueMember = "id";
            var userData = blogData.Authors.Where(usr => usr.userName == loggedUserName)
                .Select(usr => usr).FirstOrDefault();
            currentId = userData.id;

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home home = new Home(loggedUserName);
            home.Show();
            this.Hide();
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

        private void btn_setting_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting(loggedUserName);
            setting.Show();
            this.Hide();
        }

        private void btn_createPost_Click(object sender, EventArgs e)
        {
            if (txt_postBrief.Text == "" || txt_postBrief.Text == "" || rtb_postDesc.Text == "")
            {
                lbl_postStatus.ForeColor = Color.Red;
                lbl_postStatus.Text = "Please fill all the fields";
            }
            else if (rtb_postDesc.Text.Length < 20)
            {
                lbl_postStatus.ForeColor = Color.Red;
                lbl_postStatus.Text = "Post description must be at least 20 characters";
            }
            else
            {
                New newPost = new New()
                {
                    title = txt_postTitle.Text,
                    bref = txt_postBrief.Text,
                    description = rtb_postDesc.Text,
                    date = DateTime.Now,
                    authorId = blogData.Authors.Where(usr => usr.userName == loggedUserName).Select(usr => usr.id).FirstOrDefault(),
                    catalogId = (int)cb_cats.SelectedValue,
                };
                blogData.News.Add(newPost);
                blogData.SaveChanges();
                lbl_postStatus.ForeColor = Color.Green;
                lbl_postStatus.Text = "Post Created Successfully";
                txt_postTitle.Text = txt_postBrief.Text = rtb_postDesc.Text = string.Empty;
                FillData();
            }

        }
        void FillData()
        {
            var userPosts = blogData.News.Where(nws => nws.Author.userName == loggedUserName).Select(nws => new
            {
                Post_ID = nws.Id,
                Post_Title = nws.title,
                Blog_Breif = nws.bref,
                Blog_Desc = nws.description,
                Blog_Cat = nws.Catalog.name,
                Blog_PuplishedTime = nws.date,

            })
                .ToList();
            dgv_news.DataSource = userPosts;
        }
        int postId;
        private void dgv_news_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            postId = Convert.ToInt32(dgv_news.Rows[e.RowIndex].Cells[0].Value);
            New post = blogData.News.Where(nws => nws.Id == postId).Select(nws => nws).FirstOrDefault();
            txt_postTitle.Text = post.title;
            txt_postBrief.Text = post.bref;
            rtb_postDesc.Text = post.description;
            cb_cats.SelectedValue = post.catalogId;
            btn_createPost.Visible = false;
            btn_updatePost.Visible = true;
            btn_deletePost.Visible = true;
        }

        private void btn_deletePost_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete this post?", "Delete Post", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var post = blogData.News.Where(nws => nws.Id == postId).Select(nws => nws).FirstOrDefault();
                blogData.News.Remove(post);
                blogData.SaveChanges();
                FillData();
                txt_postTitle.Text = txt_postBrief.Text = rtb_postDesc.Text = string.Empty;
                btn_createPost.Visible = true;
                btn_updatePost.Visible = false;
                btn_deletePost.Visible = false;
            }
        }

        private void btn_updatePost_Click(object sender, EventArgs e)
        {

            if (txt_postBrief.Text == "" || txt_postBrief.Text == "" || rtb_postDesc.Text == "")
            {
                lbl_postStatus.ForeColor = Color.Red;
                lbl_postStatus.Text = "Please fill all the fields";
            }
            else if (rtb_postDesc.Text.Length < 20)
            {
                lbl_postStatus.ForeColor = Color.Red;
                lbl_postStatus.Text = "Post description must be at least 20 characters";
            }
            else
            {
                var post = blogData.News.Where(nws => nws.Id == postId).Select(nws => nws).FirstOrDefault();
                post.title = txt_postTitle.Text;
                post.bref = txt_postBrief.Text;
                post.description = rtb_postDesc.Text;
                post.catalogId = (int)cb_cats.SelectedValue;
                blogData.SaveChanges();
                lbl_postStatus.ForeColor = Color.Green;
                lbl_postStatus.Text = "Post Updated Successfully";
                txt_postTitle.Text = txt_postBrief.Text = rtb_postDesc.Text = string.Empty;
                FillData();
                btn_createPost.Visible = true;
                btn_updatePost.Visible = false;
                btn_deletePost.Visible = false;
            }
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
