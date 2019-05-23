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
    public partial class RoomManagementForm : Form
    {
        RoomController roomController;
        public RoomManagementForm()
        {
            InitializeComponent();
            roomController = new RoomController();
        }

        private void btnSaveRoom_Click(object sender, EventArgs e)
        {
            Room room = new Room()
            {
                RoomNo=Convert.ToInt32(txtRoomNo.Text),
                //RoomPrice=txtRoomPrice.Text
            };

            if (roomController.RoomAdd(room))
            {
                MessageBox.Show("Room Added!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
