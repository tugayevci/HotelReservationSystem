using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class AdminAppUser : Form
    {

        SignUpController signUpController;

        public AdminAppUser()
        {
            InitializeComponent();
            signUpController = new SignUpController();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            int userRole = 0;

            if (cmbUserRole.SelectedIndex==0)
            {
                userRole = 0;
            }
            else
            {
                userRole = 1;
            }

            AppUser appUser = new AppUser()
            {
                UserName = txtUserName.Text,
                UserPassword = txtUserPassword.Text,
                UserEmail = txtUserEmail.Text,
                UserRole = userRole
                

            };

            bool checkSignUp = signUpController.UserSignUpControll(appUser);

            if (checkSignUp)
            {
                MessageBox.Show("Success!");
                SignInForm signInForm = new SignInForm();
                signInForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }


        private void TxtUserEmail_TextChanged(object sender, EventArgs e)
        {
            AppUser appUser = new AppUser()
            {
                UserName = txtUserName.Text,
                UserPassword = txtUserPassword.Text,
                UserEmail = txtUserEmail.Text
            };

            bool checkSignUp = signUpController.UserSignUpEmailControll(appUser);

            if (checkSignUp)
            {
                lblEmailCheck.Text = "Valid Email Format";
                lblEmailCheck.ForeColor = Color.Green;

            }
            else
            {
                lblEmailCheck.Text = "Invalid Email Format!";
                lblEmailCheck.ForeColor = Color.Red;

                //MessageBox.Show("Error!");
            }
        }
    }
}
