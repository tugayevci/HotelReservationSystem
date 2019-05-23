namespace GUI
{
    partial class AdminPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtInfo = new System.Windows.Forms.DataGridView();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnDeleteReservation = new System.Windows.Forms.Button();
            this.btnAddAppUser = new System.Windows.Forms.Button();
            this.btnGetReservations = new System.Windows.Forms.Button();
            this.btnGetAppUsers = new System.Windows.Forms.Button();
            this.btnDeleteAppUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtInfo
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtInfo.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtInfo.Location = new System.Drawing.Point(8, 8);
            this.dtInfo.Margin = new System.Windows.Forms.Padding(2);
            this.dtInfo.Name = "dtInfo";
            this.dtInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtInfo.Size = new System.Drawing.Size(894, 256);
            this.dtInfo.TabIndex = 0;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddRoom.Location = new System.Drawing.Point(8, 329);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(84, 41);
            this.btnAddRoom.TabIndex = 1;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnDeleteReservation
            // 
            this.btnDeleteReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteReservation.Location = new System.Drawing.Point(257, 329);
            this.btnDeleteReservation.Name = "btnDeleteReservation";
            this.btnDeleteReservation.Size = new System.Drawing.Size(97, 41);
            this.btnDeleteReservation.TabIndex = 2;
            this.btnDeleteReservation.Text = "Delete Reservation";
            this.btnDeleteReservation.UseVisualStyleBackColor = true;
            this.btnDeleteReservation.Click += new System.EventHandler(this.btnDeleteReservation_Click);
            // 
            // btnAddAppUser
            // 
            this.btnAddAppUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddAppUser.Location = new System.Drawing.Point(540, 329);
            this.btnAddAppUser.Name = "btnAddAppUser";
            this.btnAddAppUser.Size = new System.Drawing.Size(97, 41);
            this.btnAddAppUser.TabIndex = 4;
            this.btnAddAppUser.Text = "Add AppUser";
            this.btnAddAppUser.UseVisualStyleBackColor = true;
            this.btnAddAppUser.Click += new System.EventHandler(this.btnAddAppUser_Click);
            // 
            // btnGetReservations
            // 
            this.btnGetReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetReservations.Location = new System.Drawing.Point(154, 329);
            this.btnGetReservations.Name = "btnGetReservations";
            this.btnGetReservations.Size = new System.Drawing.Size(97, 41);
            this.btnGetReservations.TabIndex = 5;
            this.btnGetReservations.Text = "Get Reservation";
            this.btnGetReservations.UseVisualStyleBackColor = true;
            this.btnGetReservations.Click += new System.EventHandler(this.btnGetReservations_Click);
            // 
            // btnGetAppUsers
            // 
            this.btnGetAppUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetAppUsers.Location = new System.Drawing.Point(437, 329);
            this.btnGetAppUsers.Name = "btnGetAppUsers";
            this.btnGetAppUsers.Size = new System.Drawing.Size(97, 41);
            this.btnGetAppUsers.TabIndex = 6;
            this.btnGetAppUsers.Text = "Get AppUser";
            this.btnGetAppUsers.UseVisualStyleBackColor = true;
            this.btnGetAppUsers.Click += new System.EventHandler(this.btnGetAppUsers_Click);
            // 
            // btnDeleteAppUser
            // 
            this.btnDeleteAppUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteAppUser.Location = new System.Drawing.Point(643, 329);
            this.btnDeleteAppUser.Name = "btnDeleteAppUser";
            this.btnDeleteAppUser.Size = new System.Drawing.Size(97, 41);
            this.btnDeleteAppUser.TabIndex = 7;
            this.btnDeleteAppUser.Text = "Delete AppUser";
            this.btnDeleteAppUser.UseVisualStyleBackColor = true;
            this.btnDeleteAppUser.Click += new System.EventHandler(this.btnDeleteAppUser_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 382);
            this.Controls.Add(this.btnDeleteAppUser);
            this.Controls.Add(this.btnGetAppUsers);
            this.Controls.Add(this.btnGetReservations);
            this.Controls.Add(this.btnAddAppUser);
            this.Controls.Add(this.btnDeleteReservation);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.dtInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtInfo;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnDeleteReservation;
        private System.Windows.Forms.Button btnAddAppUser;
        private System.Windows.Forms.Button btnGetReservations;
        private System.Windows.Forms.Button btnGetAppUsers;
        private System.Windows.Forms.Button btnDeleteAppUser;
    }
}