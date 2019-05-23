namespace GUI
{
    partial class ReservationFinalScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRooms = new System.Windows.Forms.Label();
            this.lstRooms = new System.Windows.Forms.ListBox();
            this.lblGuests = new System.Windows.Forms.Label();
            this.lstGuests = new System.Windows.Forms.ListBox();
            this.lblReservationDates = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblLoggedUser = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Location = new System.Drawing.Point(282, 9);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(65, 20);
            this.lblRooms.TabIndex = 0;
            this.lblRooms.Text = "Rooms";
            // 
            // lstRooms
            // 
            this.lstRooms.FormattingEnabled = true;
            this.lstRooms.ItemHeight = 20;
            this.lstRooms.Location = new System.Drawing.Point(233, 32);
            this.lstRooms.Name = "lstRooms";
            this.lstRooms.Size = new System.Drawing.Size(167, 164);
            this.lstRooms.TabIndex = 1;
            // 
            // lblGuests
            // 
            this.lblGuests.AutoSize = true;
            this.lblGuests.Location = new System.Drawing.Point(69, 9);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(67, 20);
            this.lblGuests.TabIndex = 2;
            this.lblGuests.Text = "Guests";
            // 
            // lstGuests
            // 
            this.lstGuests.FormattingEnabled = true;
            this.lstGuests.ItemHeight = 20;
            this.lstGuests.Location = new System.Drawing.Point(16, 32);
            this.lstGuests.Name = "lstGuests";
            this.lstGuests.Size = new System.Drawing.Size(199, 364);
            this.lstGuests.TabIndex = 3;
            // 
            // lblReservationDates
            // 
            this.lblReservationDates.AutoSize = true;
            this.lblReservationDates.Location = new System.Drawing.Point(229, 317);
            this.lblReservationDates.Name = "lblReservationDates";
            this.lblReservationDates.Size = new System.Drawing.Size(163, 20);
            this.lblReservationDates.TabIndex = 4;
            this.lblReservationDates.Text = "Reservation Dates:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(229, 221);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(99, 20);
            this.lblTotalPrice.TabIndex = 5;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.AutoSize = true;
            this.lblLoggedUser.Location = new System.Drawing.Point(229, 269);
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(117, 20);
            this.lblLoggedUser.TabIndex = 6;
            this.lblLoggedUser.Text = "Logged User:";
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(535, 363);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(219, 40);
            this.btnComplete.TabIndex = 7;
            this.btnComplete.Text = "Complete Reservation";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // ReservationFinalScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 415);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.lblLoggedUser);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblReservationDates);
            this.Controls.Add(this.lstGuests);
            this.Controls.Add(this.lblGuests);
            this.Controls.Add(this.lstRooms);
            this.Controls.Add(this.lblRooms);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ReservationFinalScreen";
            this.Text = "ReservationFinalScreen";
            this.Load += new System.EventHandler(this.ReservationFinalScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.ListBox lstRooms;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.ListBox lstGuests;
        private System.Windows.Forms.Label lblReservationDates;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblLoggedUser;
        private System.Windows.Forms.Button btnComplete;
    }
}