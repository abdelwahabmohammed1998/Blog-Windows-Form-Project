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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lbl_signin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
        private void btn_signup_Click(object sender, EventArgs e)
        {
            BlogContext db = new BlogContext();
            if (txt_name.Text == "" || txt_userName.Text == "" || txt_password.Text == "" || txt_repassword.Text == "")
            {
                lbl_invalid.Text = "Please fill all the fields";
            }
            else if(txt_password.Text != txt_repassword.Text)
            {
                lbl_invalid.Text = "Password does not match";
            }
            else if (txt_password.Text.Length < 8)
            {
                lbl_invalid.Text = "Password must be at least 8 characters long";
            }
            else if (txt_userName.Text.Length < 5)
            {
                lbl_invalid.Text = "Username must be at least 5 characters long";
            }
            else if (txt_name.Text.Length < 3)
            {
                lbl_invalid.Text = "Name must be at least 3 characters long";
            }
            else if (dtp_birthDate.Value.Year > DateTime.Now.Year - 18)
            {
                lbl_invalid.Text = "You must be at least 18 years old";
            }
            else if(db.Authors.Any(a => a.userName == txt_userName.Text))
            {
                lbl_invalid.Text = "Username already exists";
            }
            else
            {
                
                lbl_invalid.Text = "";
                db.Authors.Add(new Author
                {
                    name = txt_name.Text,
                    userName = txt_userName.Text,
                    password = txt_password.Text,
                    age = DateTime.Now.Year - dtp_birthDate.Value.Year,
                    joinDate = DateTime.Now
                });
                db.SaveChanges();
                MessageBox.Show("Account created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_name.Text = txt_userName.Text = txt_password.Text = txt_repassword.Text = "";
                Login login = new Login();
                this.Hide();
                login.Show();

            }
        }
    }
}
