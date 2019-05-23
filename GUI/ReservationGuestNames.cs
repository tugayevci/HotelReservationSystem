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
    public partial class ReservationGuestNames : Form
    {


        GuestController guestController;
        public ReservationGuestNames()
        {
            InitializeComponent();
            guestController = new GuestController();
            HelperStaticClass.guests = new List<Guest>();
            HelperStaticClass.guestsDictionery = new Dictionary<Guest, int>();
        }

        private void ReservationGuestNames_Load(object sender, EventArgs e)
        {
            GuestInfoScreenRenderer();
        }

        int roomCount;
        public void GuestInfoScreenRenderer()
        {
            roomCount = HelperStaticClass.roomGuestDictionary.Count;

            int x = 5;
            int y = 5;


            for (int i = 0; i < roomCount; i++)
            {
                Panel mainPanel = new Panel()
                {
                    Location = new Point(x, y),
                    Size = new Size(300, 415),
                    BorderStyle = BorderStyle.FixedSingle,
                    Name = "mainPanel"+(i+1).ToString(),
                };

                x += 300;
                this.Controls.Add(mainPanel);

                Label roomNo = new Label()
                {
                    Text = "Room No: " + HelperStaticClass.roomGuestDictionary.Keys.ElementAt(i).ToString(),
                    AutoSize = true,
                    Location = new Point(100, 30),
                    Tag = HelperStaticClass.roomGuestDictionary.Keys.ElementAt(i).ToString(),
                    Font = new Font("Microsoft Sans Serif",14)
                };
                mainPanel.Controls.Add(roomNo);

                int xInfoPanel = 5;
                int yInfoPanel = 60;

                int infoCount = HelperStaticClass.roomGuestDictionary.Values.ElementAt(i);

                for (int k = 0; k < infoCount; k++)
                {
                    Panel infoPanel = new Panel()
                    {
                        Location = new Point(xInfoPanel, yInfoPanel),
                        Size = new Size(290, 115),
                        BorderStyle = BorderStyle.FixedSingle,
                    };

                    mainPanel.Controls.Add(infoPanel);

                    Label labelFirstName = new Label()
                    {
                        Location = new Point(5, 10),
                        AutoSize = true,
                        Text = "First Name",
                        
                    };

                    Label labelLastName = new Label()
                    {
                        Location = new Point(5, 45),
                        AutoSize = true,
                        Text = "Last Name",

                    };
                    Label labelTcNo = new Label()
                    {
                        Location = new Point(5, 80),
                        AutoSize = true,
                        Text = "TC NO:",
                    };


                    TextBox textBoxFirstName = new TextBox()
                    {
                        Location = new Point(100, 10),
                        Size = new Size(170, 415),
                        Name= "txtFirstName"
                    };

                    TextBox textBoxLastName = new TextBox()
                    {
                        Location = new Point(100, 45),
                        Size = new Size(170, 415),
                        Name = "txtLastName"

                    };

                    TextBox textBoxTcNo = new TextBox()
                    {
                        Location = new Point(100, 80),
                        Size = new Size(170, 415),
                        Name = "txtTcNo",
                        MaxLength = 11

                    };

                    textBoxTcNo.KeyPress += txtTcNo_KeyPress;

                    infoPanel.Controls.Add(labelFirstName);
                    infoPanel.Controls.Add(labelLastName);
                    infoPanel.Controls.Add(labelTcNo);
                    infoPanel.Controls.Add(textBoxFirstName);
                    infoPanel.Controls.Add(textBoxLastName);
                    infoPanel.Controls.Add(textBoxTcNo);


                    yInfoPanel += 120;
                }
            }            
        }

        private void txtTcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
                       
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            HelperStaticClass.guests = GetGuestsFromForm();
            bool tempBool = true;
            foreach (Guest guest in HelperStaticClass.guests)
            {
                bool result  = guestController.GuestControll(guest);

                if (!result)
                {
                    MessageBox.Show("Error while adding guests!");
                    tempBool = false;
                    HelperStaticClass.guests.Clear();
                    HelperStaticClass.guestsDictionery.Clear();
                    break;
                }
            }

            if (tempBool)
            {
                decimal price = ReservationPriceCalculator(HelperStaticClass.reservationStatic);
                HelperStaticClass.reservationStatic.TotalPrice = price;
                FinalReservationScreenOpen();
            }
        }

        public void FinalReservationScreenOpen()
        {
            if (HelperStaticClass.appUserStatic is null)
            {
                SignInForm signInForm = new SignInForm();
                signInForm.Show();
            }
            else
            {
                ReservationFinalScreen reservationFinalScreen = new ReservationFinalScreen();
                reservationFinalScreen.Show();
            }

            this.Hide();
        }

        public decimal ReservationPriceCalculator(Reservation reservation)
        {
            Room room = new Room();

            int dayCount = reservation.CheckOutDate.Day - reservation.CheckInDate.Day;

            List<DateTime> reservationDates = new List<DateTime>();
            DateTime tempDate = reservation.CheckInDate;

            for (int i = 0; i < dayCount; i++)
            {
                reservationDates.Add(tempDate);
                tempDate = tempDate.AddDays(1);
            }            

            decimal price = room.RoomPrice;

            decimal totalPrice = 0;

            int guestCount = reservation.GuestCount;

            foreach (DateTime item in reservationDates)
            {
                guestCount = reservation.GuestCount;
                DayOfWeek dayOfWeek = item.DayOfWeek;

                if ((dayOfWeek == DayOfWeek.Saturday) || (dayOfWeek == DayOfWeek.Sunday))
                {
                    for (int i = 0; i < HelperStaticClass.roomGuestDictionary.Count; i++)
                    {
                        if (HelperStaticClass.roomGuestDictionary.Values.ElementAt(i)==1)
                        {
                            totalPrice += price * room.OneGuestInRoomPriceRatio * room.WeekendPriceRatio;
                        }

                        if (HelperStaticClass.roomGuestDictionary.Values.ElementAt(i) == 2)
                        {
                            totalPrice += price * room.WeekendPriceRatio;
                        }

                        if (HelperStaticClass.roomGuestDictionary.Values.ElementAt(i) == 3)
                        {
                            totalPrice += price * room.WeekendPriceRatio * room.ExtraBedPriceRatio;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < HelperStaticClass.roomGuestDictionary.Count; i++)
                    {
                        if (HelperStaticClass.roomGuestDictionary.Values.ElementAt(i) == 1)
                        {
                            totalPrice += price * room.OneGuestInRoomPriceRatio;
                        }

                        if (HelperStaticClass.roomGuestDictionary.Values.ElementAt(i) == 2)
                        {
                            totalPrice += price ;
                        }

                        if (HelperStaticClass.roomGuestDictionary.Values.ElementAt(i) == 3)
                        {
                            totalPrice += price * room.ExtraBedPriceRatio;
                        }
                    }
                }                       
                
            }

            return totalPrice * reservation.ReservationTypePriceRatio;
        }

        public List<Guest> GetGuestsFromForm()
        {
            int tempRoomNo = 0;

            foreach (Control mainPanel in this.Controls)
            {
                if (mainPanel.GetType()==typeof(Panel))
                {
                    foreach (Control infoPanel in mainPanel.Controls)
                    {

                        if (infoPanel.GetType() == typeof(Label) && infoPanel.Tag!=null)
                        {
                            tempRoomNo = Convert.ToInt32(infoPanel.Tag.ToString());
                        }

                        if (infoPanel.GetType() == typeof(Panel))
                        {
                            Guest guest = new Guest();

                            foreach (Control textBox in infoPanel.Controls)
                            {

                                if (textBox.GetType() == typeof(TextBox))
                                {
                                    if (textBox.Name == "txtFirstName")
                                    {
                                        guest.FirstName = textBox.Text;
                                    }

                                    if (textBox.Name == "txtLastName")
                                    {
                                        guest.LastName = textBox.Text;
                                    }

                                    if (textBox.Name == "txtTcNo")
                                    {
                                        guest.TcNO = textBox.Text;
                                    }

                                    if (guest.FirstName is null || guest.LastName is null || guest.TcNO is null)
                                    {

                                    }
                                    else
                                    {
                                        HelperStaticClass.guests.Add(guest);
                                        HelperStaticClass.guestsDictionery.Add(guest, tempRoomNo);
                                        //guests.Add(guest);                                      

                                    }
                                }
                            }
                        }                        
                    }
                }
            }            
            return HelperStaticClass.guests;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            ReservationComplete reservationComplete = new ReservationComplete();
            reservationComplete.Show();
        }
    }
}
