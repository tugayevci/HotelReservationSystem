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
    public partial class ReservationComplete : Form
    {

        RoomController roomController;
        Panel mainPanel;

        public ReservationComplete()
        {
            InitializeComponent();
            roomController = new RoomController();
            HelperStaticClass.roomGuestDictionary = new Dictionary<int, int>();
        }

       
        private void ReservationComplete_Load(object sender, EventArgs e)
        {           

            List<int> rooms = GetRooms();

            int x = 0;
            int y = 0;

            mainPanel = new Panel()
            {
                Size = new Size(755, 755),
                Location = new Point(x, y),
            };


            for (int i = 0; i < rooms.Count; i++)
            {
                Panel panel = new Panel()
                {
                    Name = "panel" + rooms[i].ToString(),
                    Size = new Size(150, 150),
                    Location = new Point(x, y),
                    BorderStyle = BorderStyle.FixedSingle,
                };

                Label label = new Label()
                {
                    Name = "lbl" + rooms[i].ToString(),
                    Text = "Room: " + rooms[i].ToString(),
                    Location = new Point(25,10),
                    AutoSize=true                    
                };

                Label lblGuestCount = new Label()
                {
                    Text = "Guests: ",
                    Location = new Point(35, 40),
                    AutoSize = true
                };

                Label lblExtraBed = new Label()
                {
                    Name = "lblExtraBed" + rooms[i].ToString(),
                    Text = "",
                    Location = new Point(5, 105),
                    ForeColor = Color.Green,
                    AutoSize = true,
                };


                NumericUpDown numericUpDown = new NumericUpDown()
                {
                    Name = "num" + rooms[i].ToString(),
                    Location = new Point(15, 70),
                    Minimum = 0,
                    Maximum = 3,
                    Enabled = false,
                    Tag = rooms[i].ToString()
                };
                numericUpDown.ValueChanged += NumericUpDown_ValueChanged;

                CheckBox checkBox = new CheckBox()
                {
                    Name = rooms[i].ToString(),
                    Location = new Point(20, 120),
                    Text= "Pick Room",
                    Size= new Size(130,40),
                    Enabled= GetRoomAvailability(rooms[i]),
                };
                checkBox.CheckedChanged += CheckBox_CheckedChanged;

                this.Controls.Add(mainPanel);
                panel.Controls.Add(label);
                panel.Controls.Add(lblGuestCount);
                panel.Controls.Add(lblExtraBed);
                panel.Controls.Add(numericUpDown);
                panel.Controls.Add(checkBox);
                mainPanel.Controls.Add(panel);


                x += 150;

                if (x>=750)
                {
                    x = 0;
                    y += 150;
                }
            }         
       
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {

            foreach (Panel item in mainPanel.Controls)
            {
                if (item.Name == "panel" + ((NumericUpDown)sender).Tag)
                {
                    foreach (Control item2 in item.Controls)
                    {
                        if (item2.Name == "lblExtraBed" + ((NumericUpDown)sender).Tag)
                        {
                            if (((NumericUpDown)sender).Value == 3)
                            {
                                item2.Text = "Extra Bed Added";
                            }
                            else
                            {
                                item2.Text = "";
                            }                               
                        }
                    }
                }
            }

        }

        public bool GetRoomAvailability(int roomNo)
        {
            Room room = new Room();

            room.RoomNo = roomNo;
            room.ID = roomController.GetRoomId(room);
            
            ReservationRooms reservationRooms = new ReservationRooms();

            reservationRooms.Reservation = HelperStaticClass.reservationStatic;
            reservationRooms.Room = room;

            return roomController.GetRoomAvailability(reservationRooms);
        }



        private void CheckBox_CheckedChanged(object sender, System.EventArgs e)
        {

            string checkboxName = ((CheckBox)sender).Name;

            Control[] control = { null };
            Panel tempPanel =null;

            foreach (Panel panel in mainPanel.Controls)
            {
                if (panel.Name == "panel" + checkboxName)
                {
                    control = panel.Controls.Find("num" + checkboxName, true);
                    tempPanel = panel;
                }
            }

            if (((CheckBox)sender).Checked==true)
            {
                ((NumericUpDown)control[0]).Enabled = true;
                ((NumericUpDown)control[0]).Value = 1;
                ((NumericUpDown)control[0]).Minimum = 1;
                tempPanel.BackColor = Color.LightGreen;
            }
            else
            {
                ((NumericUpDown)control[0]).Minimum = 0;
                ((NumericUpDown)control[0]).Value = 0;
                ((NumericUpDown)control[0]).Enabled = false;
                tempPanel.BackColor = SystemColors.Control;

            }
        }
        

        public List<int> GetRooms()
        {
            List<int> rooms;
            rooms = roomController.GetRooms();
            
            return rooms;
        }


        private void btnReservation_Click(object sender, EventArgs e)
        {
            int tempGuest = GetGuestCount();

            if (CheckReservationGuestCount(tempGuest))
            {
                GetPickedRooms();
                ReservationGuestNames reservationGuestNames = new ReservationGuestNames();
                reservationGuestNames.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You should choose "+ HelperStaticClass.reservationStatic.GuestCount + " guests totally");
            }


            
        }

        public int GetGuestCount()
        {
            int tempGuestCount = 0;

            foreach (Panel panel in mainPanel.Controls)
            {
                foreach (Control control in panel.Controls)
                {
                    if (control.GetType() == typeof(NumericUpDown))
                    {
                        tempGuestCount += Convert.ToInt32(((NumericUpDown)control).Value);                        
                    }
                }
            }

            return tempGuestCount;
        }

        public bool CheckReservationGuestCount(int guestCount)
        {
            if (guestCount== HelperStaticClass.reservationStatic.GuestCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void GetPickedRooms()
        {
            Control[] control2 = { null };
            List<int> roomNo = new List<int>();

            foreach (Panel panel in mainPanel.Controls)
            {
                foreach (Control control in panel.Controls)
                {

                    if (control.GetType()==typeof(CheckBox))
                    {
                        if (((CheckBox)control).Checked == true)
                        {
                            int roomId = Convert.ToInt32(control.Name);

                            control2 = panel.Controls.Find("num" + roomId, true);
                            int guestCount = Convert.ToInt32(((NumericUpDown)control2[0]).Value);
                            HelperStaticClass.roomGuestDictionary.Add(roomId, guestCount);
                            control2[0] = null;

                        }
                    }

                    
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ReservationScreen reservationScreen = new ReservationScreen();
            reservationScreen.Show();
            Hide();
            Dispose();
        }
    }
}
