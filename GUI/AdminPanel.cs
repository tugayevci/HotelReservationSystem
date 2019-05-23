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
    public partial class AdminPanel : Form
    {
        ReservationController reservationControll;
        AppUserController userController;
        public AdminPanel()
        {
            InitializeComponent();
            reservationControll = new ReservationController();
            userController = new AppUserController();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            GetReservations();
            btnDeleteAppUser.Enabled = false;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            RoomManagementForm roomManagementForm = new RoomManagementForm();
            roomManagementForm.ShowDialog();
        }

        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
           
            Reservation reservation = new Reservation();
            reservation.ID = (int)dtInfo.SelectedRows[0].Cells["ID"].Value;
            bool result = reservationControll.DeleteReservation(reservation);
            if (result)
            {
                MessageBox.Show("Deleting succesful!");
            }
            else
            {
                MessageBox.Show("Error while deleting reservation");
            }
            GetReservations();

        }

        public void GetReservations()
        {
            dtInfo.DataSource = null;
        
            dtInfo.DataSource = reservationControll.GetReservations();
            btnDeleteAppUser.Enabled = false;
            btnDeleteReservation.Enabled = true;

        }

        private void btnAddAppUser_Click(object sender, EventArgs e)
        {
            AdminAppUser adminAppUser = new AdminAppUser();
            adminAppUser.ShowDialog();
        }

        private void btnGetReservations_Click(object sender, EventArgs e)
        {
            GetReservations();
        }

        public void GetAppUsers()
        {
            dtInfo.DataSource = null;

            dtInfo.DataSource = userController.GetAppUsers();
            dtInfo.Columns[1].Visible = false;
            btnDeleteAppUser.Enabled = true;
            btnDeleteReservation.Enabled = false;

        }

        private void btnGetAppUsers_Click(object sender, EventArgs e)
        {
            GetAppUsers();
        }

        private void btnDeleteAppUser_Click(object sender, EventArgs e)
        {
            AppUser appUser = new AppUser();
            appUser.ID = (int)dtInfo.SelectedRows[0].Cells["ID"].Value;
            bool result = userController.DeleteAppUser(appUser);
            if (result)
            {
                MessageBox.Show("Deleting succesful!");
            }
            else
            {
                MessageBox.Show("Error while deleting appuser");
            }
            GetAppUsers();
        }
    }
}
