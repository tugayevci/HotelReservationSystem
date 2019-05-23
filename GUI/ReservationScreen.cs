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
    public partial class ReservationScreen : Form
    {

        ReservationController reservationController;
        public ReservationScreen()
        {
            InitializeComponent();
            reservationController = new ReservationController();
            HelperStaticClass.guestsDictionery = new Dictionary<Guest, int>();
        }

        private void ReservationScreen_Load(object sender, EventArgs e)
        {
            dtpCheckIn.MinDate = DateTime.Now;
            dtpCheckOut.MinDate = DateTime.Now;
            cbExtraBed.Enabled = false;
            btnAdmin.Visible = false;           


            if (HelperStaticClass.appUserStatic is null)
            {

            }
            else
            {

                if (HelperStaticClass.appUserStatic.UserRole == 1)
                {
                    btnAdmin.Visible = true;

                }
                else
                {
                    btnAdmin.Visible = false;
                }


                lblSignIn.Text = "Logged User: " + HelperStaticClass.appUserStatic.UserName;
            }
        }

        private void RbStandart_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStandart.Checked==true)
            {
                lblReservationTypeInfo.Text = "Room only and breakfast included. 100 TL Per Day";
            }
            else if (rbGold.Checked==true)
            {
                lblReservationTypeInfo.Text = "The room and all meals are included. 125 TL Per Day";
            }
            else
            {
                lblReservationTypeInfo.Text = "All meals and drinks are included. 150 TL Per Day";
            }
        }

        private void BtnSearchReservation_Click(object sender, EventArgs e)
        {

            DateTime dateTimeCheckIn = Convert.ToDateTime(dtpCheckIn.Value.ToShortDateString());
            DateTime dateTimeCheckOut = Convert.ToDateTime(dtpCheckOut.Value.ToShortDateString());
            byte reservationType = 0;

            if (rbStandart.Checked == true)
            {
                reservationType = 0;
            }
            else if (rbGold.Checked == true)
            {
                reservationType = 1;

            }
            else
            {
                reservationType = 2;
            }

            int guestCount = Convert.ToInt32(numGuestCount.Value);
            bool extraBed = cbExtraBed.Checked ? true : false;


            Reservation reservation = new Reservation()
            {
                CheckInDate = dateTimeCheckIn,
                CheckOutDate = dateTimeCheckOut,
                GuestCount = guestCount,
                ReservationType = reservationType,
                ExtraBed = extraBed

            };

            bool datesCheck = reservationController.ReservationDateController(reservation);

            //double roomCount = reservationController.RoomCountCalculate(reservation);

            //decimal price = reservationController.ReservationPriceCalculator(reservation);
            //MessageBox.Show(price.ToString());

            if (datesCheck)
            {
                HelperStaticClass.reservationStatic = reservation;
                //if (cbExtraBed.Checked==true)
                //{
                //    ReservationGuestNames reservationGuestNames = new ReservationGuestNames();

                //}
                
                ReservationComplete reservationComplete = new ReservationComplete();
                this.Hide();
                reservationComplete.Show();
            }
            else
            {
                MessageBox.Show("The check in date cannot be after than check out date");
            }
        }

        private void NumGuestCount_ValueChanged(object sender, EventArgs e)
        {
            if (numGuestCount.Value>= 3)
            {
                cbExtraBed.Enabled = false;
            }
            else
            {
                cbExtraBed.Enabled = false;
            }
        }

        private void lblSignIn_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            signInForm.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }
    }
}
