using Blog_Project.Models;
using System.Data;

namespace Blog_Project
{
    public partial class Setting : Form
    {
        public Setting(string userName)
        {
            InitializeComponent();
            loggedUserName = userName;
        }
        BlogContext userData;
        string loggedUserName;
        private void Setting_Load(object sender, EventArgs e)
        {
            userData = new BlogContext();
            var user = userData.Authors.Where(usr => usr.userName == loggedUserName).FirstOrDefault();
            txt_setting_userName.Text = user.userName;
            txt_setting_name.Text = user.name;
            txt_setting_age.Text = user.age.ToString();
            txt_setting_password.Text = user.password;
            txt_setting_repassword.Text = user.password;
            txt_setting_age.Text = user.age.ToString();
            txt_joinDate.Text = user.joinDate.ToString();
            lbl_name.Text = user.name;
            lbl_username.Text = user.userName.ToString();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btn_setting_saveChanges_Click(object sender, EventArgs e)
        {

            if (txt_setting_password.Text == txt_setting_repassword.Text)
            {
                var user = userData.Authors.Where(usr => usr.userName == loggedUserName).FirstOrDefault();
                user.userName = txt_setting_userName.Text;
                user.name = txt_setting_name.Text;
                user.age = Convert.ToInt32(txt_setting_age.Text);
                user.password = txt_setting_password.Text;
                userData.SaveChanges();
                lbl_changeStatus.ForeColor = Color.Green;
                lbl_changeStatus.Text = "Changes Saved";
                btn_setting_saveChanges.Enabled = false;
            }
            else
            {
                lbl_changeStatus.ForeColor = Color.Red;
                lbl_changeStatus.Text = "Password does not match";
            }

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home home = new Home(loggedUserName);
            this.Hide();
            home.Show();
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

        private void txt_setting_password_ModifiedChanged(object sender, EventArgs e)
        {
            txt_setting_password.PasswordChar = default;

        }

        private void txt_setting_repassword_ModifiedChanged(object sender, EventArgs e)
        {
            txt_setting_repassword.PasswordChar = default;
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
