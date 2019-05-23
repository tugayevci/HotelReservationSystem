namespace GUI
{
    partial class ReservationScreen
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
            this.lblHotelInfo = new System.Windows.Forms.Label();
            this.lblReservationType = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbPremium = new System.Windows.Forms.RadioButton();
            this.rbGold = new System.Windows.Forms.RadioButton();
            this.rbStandart = new System.Windows.Forms.RadioButton();
            this.lblReservationTypeInfo = new System.Windows.Forms.Label();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numGuestCount = new System.Windows.Forms.NumericUpDown();
            this.btnSearchReservation = new System.Windows.Forms.Button();
            this.cbExtraBed = new System.Windows.Forms.CheckBox();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGuestCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHotelInfo
            // 
            this.lblHotelInfo.AutoSize = true;
            this.lblHotelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHotelInfo.ForeColor = System.Drawing.Color.Maroon;
            this.lblHotelInfo.Location = new System.Drawing.Point(210, 9);
            this.lblHotelInfo.Name = "lblHotelInfo";
            this.lblHotelInfo.Size = new System.Drawing.Size(158, 31);
            this.lblHotelInfo.TabIndex = 0;
            this.lblHotelInfo.Text = "Hotel G.I.T";
            // 
            // lblReservationType
            // 
            this.lblReservationType.AutoSize = true;
            this.lblReservationType.Location = new System.Drawing.Point(33, 58);
            this.lblReservationType.Name = "lblReservationType";
            this.lblReservationType.Size = new System.Drawing.Size(153, 20);
            this.lblReservationType.TabIndex = 1;
            this.lblReservationType.Text = "Reservation Type:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbPremium);
            this.panel1.Controls.Add(this.rbGold);
            this.panel1.Controls.Add(this.rbStandart);
            this.panel1.Location = new System.Drawing.Point(166, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 35);
            this.panel1.TabIndex = 2;
            // 
            // rbPremium
            // 
            this.rbPremium.AutoSize = true;
            this.rbPremium.Location = new System.Drawing.Point(267, 4);
            this.rbPremium.Name = "rbPremium";
            this.rbPremium.Size = new System.Drawing.Size(96, 24);
            this.rbPremium.TabIndex = 2;
            this.rbPremium.TabStop = true;
            this.rbPremium.Text = "Premium";
            this.rbPremium.UseVisualStyleBackColor = true;
            this.rbPremium.CheckedChanged += new System.EventHandler(this.RbStandart_CheckedChanged);
            // 
            // rbGold
            // 
            this.rbGold.AutoSize = true;
            this.rbGold.Location = new System.Drawing.Point(173, 3);
            this.rbGold.Name = "rbGold";
            this.rbGold.Size = new System.Drawing.Size(65, 24);
            this.rbGold.TabIndex = 1;
            this.rbGold.TabStop = true;
            this.rbGold.Text = "Gold";
            this.rbGold.UseVisualStyleBackColor = true;
            this.rbGold.CheckedChanged += new System.EventHandler(this.RbStandart_CheckedChanged);
            // 
            // rbStandart
            // 
            this.rbStandart.AutoSize = true;
            this.rbStandart.Location = new System.Drawing.Point(47, 4);
            this.rbStandart.Name = "rbStandart";
            this.rbStandart.Size = new System.Drawing.Size(97, 24);
            this.rbStandart.TabIndex = 0;
            this.rbStandart.TabStop = true;
            this.rbStandart.Text = "Standart";
            this.rbStandart.UseVisualStyleBackColor = true;
            this.rbStandart.CheckedChanged += new System.EventHandler(this.RbStandart_CheckedChanged);
            // 
            // lblReservationTypeInfo
            // 
            this.lblReservationTypeInfo.AutoSize = true;
            this.lblReservationTypeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblReservationTypeInfo.Location = new System.Drawing.Point(209, 88);
            this.lblReservationTypeInfo.Name = "lblReservationTypeInfo";
            this.lblReservationTypeInfo.Size = new System.Drawing.Size(0, 16);
            this.lblReservationTypeInfo.TabIndex = 4;
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Location = new System.Drawing.Point(101, 126);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(85, 20);
            this.lblCheckInDate.TabIndex = 5;
            this.lblCheckInDate.Text = "Check In:";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(212, 124);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(255, 26);
            this.dtpCheckIn.TabIndex = 6;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(212, 166);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(255, 26);
            this.dtpCheckOut.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Check Out:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(301, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Guests:";
            // 
            // numGuestCount
            // 
            this.numGuestCount.Location = new System.Drawing.Point(212, 210);
            this.numGuestCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGuestCount.Name = "numGuestCount";
            this.numGuestCount.Size = new System.Drawing.Size(120, 26);
            this.numGuestCount.TabIndex = 11;
            this.numGuestCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGuestCount.ValueChanged += new System.EventHandler(this.NumGuestCount_ValueChanged);
            // 
            // btnSearchReservation
            // 
            this.btnSearchReservation.Location = new System.Drawing.Point(212, 267);
            this.btnSearchReservation.Name = "btnSearchReservation";
            this.btnSearchReservation.Size = new System.Drawing.Size(187, 42);
            this.btnSearchReservation.TabIndex = 12;
            this.btnSearchReservation.Text = "Search Reservation";
            this.btnSearchReservation.UseVisualStyleBackColor = true;
            this.btnSearchReservation.Click += new System.EventHandler(this.BtnSearchReservation_Click);
            // 
            // cbExtraBed
            // 
            this.cbExtraBed.AutoSize = true;
            this.cbExtraBed.Location = new System.Drawing.Point(357, 211);
            this.cbExtraBed.Name = "cbExtraBed";
            this.cbExtraBed.Size = new System.Drawing.Size(173, 24);
            this.cbExtraBed.TabIndex = 14;
            this.cbExtraBed.Text = "Search Best Offer";
            this.cbExtraBed.UseVisualStyleBackColor = true;
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSignIn.ForeColor = System.Drawing.Color.Maroon;
            this.lblSignIn.Location = new System.Drawing.Point(9, 313);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(129, 16);
            this.lblSignIn.TabIndex = 15;
            this.lblSignIn.Text = "Click here for sign in.";
            this.lblSignIn.Click += new System.EventHandler(this.lblSignIn_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(13, 9);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(100, 31);
            this.btnAdmin.TabIndex = 16;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // ReservationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 342);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.lblSignIn);
            this.Controls.Add(this.cbExtraBed);
            this.Controls.Add(this.btnSearchReservation);
            this.Controls.Add(this.numGuestCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblReservationType);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.lblCheckInDate);
            this.Controls.Add(this.lblReservationTypeInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHotelInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ReservationScreen";
            this.Text = "ReservationScreen";
            this.Load += new System.EventHandler(this.ReservationScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGuestCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHotelInfo;
        private System.Windows.Forms.Label lblReservationType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbPremium;
        private System.Windows.Forms.RadioButton rbGold;
        private System.Windows.Forms.RadioButton rbStandart;
        private System.Windows.Forms.Label lblReservationTypeInfo;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numGuestCount;
        private System.Windows.Forms.Button btnSearchReservation;
        private System.Windows.Forms.CheckBox cbExtraBed;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Button btnAdmin;
    }
}