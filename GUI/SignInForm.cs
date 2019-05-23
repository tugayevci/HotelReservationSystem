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
    public partial class SignInForm : Form
    {

        //public static AppUser appUserStatic;


        SignInController loginController;
        public SignInForm()
        {
            InitializeComponent();
            loginController = new SignInController();
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            AppUser appUser = new AppUser()
            {
                UserName=txtUserName.Text,
                UserPassword=txtUserPassword.Text                
            };

            bool loginControll = loginController.UserSignInControll(appUser);

            if (loginControll)
            {
                HelperStaticClass.appUserStatic = loginController.AppUserGet(appUser);

                if (HelperStaticClass.guestsDictionery.Count>=1)
                {
                    ReservationFinalScreen reservationFinalScreen = new ReservationFinalScreen();
                    reservationFinalScreen.Show();
                }
                else
                {
                    ReservationScreen reservationScreen = new ReservationScreen();
                    reservationScreen.Show();
                }
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid password or username!");
            }
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        private void LblForgotPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }

        private void SignInForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
