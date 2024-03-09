using Blog_Project.Models;
using System.Data;

namespace Blog_Project
{
    public partial class Pravicy : Form
    {
        public Pravicy(string userName, string title, string mssg)
        {
            InitializeComponent();
            loggedUserName = userName;
            formTitle = title;
            formText = mssg;
        }
        string loggedUserName;
        BlogContext userData;
        string formTitle;
        string formText;
        private void Pravicy_Load(object sender, EventArgs e)
        {
            if (loggedUserName == null)
            {
                lbl_name.Text = "Guest";
                panel_setting.Visible = false;
                panel_addNew.Visible = false;
            }
            else
            {
                userData = new BlogContext();
                var user = userData.Authors.Where(usr => usr.userName == loggedUserName).FirstOrDefault();
                lbl_username.Text = user.userName;
                lbl_name.Text = user.name;
            }
            gb_pravicy.Text = formTitle;
            lbl_mssg.Text = formText;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
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

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home home = new Home(loggedUserName);
            home.Show();
            this.Hide();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting(loggedUserName);
            setting.Show();
            this.Hide();
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            AddNew addNew = new AddNew(loggedUserName);
            addNew.Show();
            this.Hide();
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
