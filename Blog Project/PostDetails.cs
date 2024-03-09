using Blog_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blog_Project
{
    public partial class PostDetails : Form
    {
        public PostDetails(string userName, int postId)
        {
            InitializeComponent();
            loggedUserName = userName;
            postDetailsId = postId;
        }
        string loggedUserName;
        int postDetailsId;
        BlogContext userData = new BlogContext();
        private void PostDetails_Load(object sender, EventArgs e)
        {
            if (loggedUserName == null)
            {
                lbl_name.Text = "Guest";
                panel_setting.Visible = false;
                panel_addNew.Visible = false;
            }
            else
            {
                lbl_name.Text = loggedUserName.ToString();
            }

            var post = userData.News.Where(post => post.Id == postDetailsId).FirstOrDefault();
            if (loggedUserName != null)
                lbl_name.Text = loggedUserName.ToString();

            gb_postDetails.Text += post.title;
            lbl_postTitle.Text = post.title;
            lbl_postBreif.Text = post.bref;
            lbl_postDesc.Text = post.description;
            lbl_postdate.Text = post.date.ToString();
            lbl_postAuth.Text = userData.Authors.Where(usr => usr.id == post.authorId).Select(usr => usr.name).FirstOrDefault();
            lbl_postCat.Text = userData.Catalogs.Where(cat => cat.id == post.catalogId).Select(cat => cat.name).FirstOrDefault();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
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
            addNew.Show();
            this.Hide();

        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting(loggedUserName);
            setting.Show();
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

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            loggedUserName = null;
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
