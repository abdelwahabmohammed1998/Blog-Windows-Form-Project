using Blog_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blog_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string loggedUserName;
        private void close_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lbl_guestLogin_Click(object sender, EventArgs e)
        {
            Home home = new Home(null);
            this.Hide();
            home.Show();
        }

        private void lbl_signup_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            this.Hide();
            signup.Show();
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            BlogContext context = new BlogContext();
            var user = context.Authors.Where(u => u.userName == txt_userName.Text && u.password == txt_password.Text).FirstOrDefault();
            if (user != null)
            {
                loggedUserName = user.userName;
                Home home = new Home(loggedUserName);
                this.Hide();
                home.Show();
            }
            else
            {
                lbl_invalidData.Visible = true;
            }
        }


    }
}
