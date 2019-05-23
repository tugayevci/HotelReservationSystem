using BLL;
using DAL;
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
    public partial class ReservationFinalScreen : Form
    {

        ReservationController reservationController;
        ReservationRoomsController reservationRoomsController;
        RoomController roomController;
        Mail mail;

        public ReservationFinalScreen()
        {
            reservationController = new ReservationController();
            reservationRoomsController = new ReservationRoomsController();
            roomController = new RoomController();
            mail = new Mail();
            InitializeComponent();
        }

        private void ReservationFinalScreen_Load(object sender, EventArgs e)
        {
            lblLoggedUser.Text = "Logged User: " + HelperStaticClass.appUserStatic.UserName;
            lblReservationDates.Text = "Reservation Dates:"+"\nCheck In: " + HelperStaticClass.reservationStatic.CheckInDate.ToShortDateString() + "" + "\nCheck Out: "
                + HelperStaticClass.reservationStatic.CheckOutDate.ToShortDateString();

            lblTotalPrice.Text = "Total Price: " + HelperStaticClass.reservationStatic.TotalPrice.ToString() + "TL";

            for (int i = 0; i < HelperStaticClass.roomGuestDictionary.Count; i++)
            {
                lstRooms.Items.Add(HelperStaticClass.roomGuestDictionary.Keys.ElementAt(i).ToString());
            }

            foreach (Guest guest in HelperStaticClass.guestsDictionery.Keys)
            {
                lstGuests.Items.Add(guest.FirstName + " " + guest.LastName);
            }
            
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                //if (RoomControll())
                //{
                    AddReservation();
                //}
                //else
                //{
                //    MessageBox.Show("These rooms already taken! Please choose different rooms and try again");
                //}


            }
            else if (dialogResult == DialogResult.No)
            {
                
            }            
        }

        public void AddReservation()
        {
            HelperStaticClass.reservationStatic.AppUserID = HelperStaticClass.appUserStatic.ID;

            bool result = reservationController.AddReservationController(HelperStaticClass.reservationStatic);

            if (result)
            {
                if (AddReservationRooms())
                {
                    MessageBox.Show("Booking completed successfully.");
                    ReservationScreen reservationScreen = new ReservationScreen();
                    reservationScreen.Show();
                    mail.SendReservationInfoMail(HelperStaticClass.reservationStatic);
                    Hide();

                }
                else
                {
                    MessageBox.Show("Reservation room error!");
                }     
                
            }
            else
            {
                MessageBox.Show("Error while adding reservation!!!");
                ReservationScreen reservationScreen = new ReservationScreen();
                reservationScreen.Show();
                Hide();
            }
        }

        //public bool RoomControll()
        //{
        //    ReservationRooms reservationRooms = new ReservationRooms();
        //    reservationRooms.Reservation = HelperStaticClass.reservationStatic;


        //    for (int i = 0; i < HelperStaticClass.guestsDictionery.Count; i++)
        //    {
        //        Room room = new Room();
        //        room.RoomNo = HelperStaticClass.guestsDictionery.Values.ElementAt(i);
        //        reservationRooms.RoomID = roomController.GetRoomId(room);

        //        bool result = roomController.GetRoomAvailability(reservationRooms);

        //        if (!result)
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}

        public bool AddReservationRooms()
        {
            ReservationRooms reservationRooms = new ReservationRooms();
            reservationRooms.ReservationID = reservationController.ReservationIdGet(HelperStaticClass.reservationStatic);


            for (int i = 0; i < HelperStaticClass.guestsDictionery.Count; i++)
            {
                Room room = new Room();
                room.RoomNo = HelperStaticClass.guestsDictionery.Values.ElementAt(i);
                reservationRooms.RoomID = roomController.GetRoomId(room);
                reservationRoomsController.AddReservationControll(reservationRooms);
            }

            return true;

        }
    }
}
