namespace GUI
{
    partial class AdminAppUser
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
            this.lblEmailCheck = new System.Windows.Forms.Label();
            this.txtUserEmail = new System.Windows.Forms.MaskedTextBox();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtUserPassword = new System.Windows.Forms.MaskedTextBox();
            this.txtUserName = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblEmailCheck
            // 
            this.lblEmailCheck.AutoSize = true;
            this.lblEmailCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmailCheck.ForeColor = System.Drawing.Color.Red;
            this.lblEmailCheck.Location = new System.Drawing.Point(110, 159);
            this.lblEmailCheck.Name = "lblEmailCheck";
            this.lblEmailCheck.Size = new System.Drawing.Size(0, 13);
            this.lblEmailCheck.TabIndex = 21;
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Location = new System.Drawing.Point(110, 91);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(260, 22);
            this.txtUserEmail.TabIndex = 18;
            this.txtUserEmail.TextChanged += new System.EventHandler(this.TxtUserEmail_TextChanged);
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Location = new System.Drawing.Point(45, 94);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(51, 16);
            this.lblUserEmail.TabIndex = 19;
            this.lblUserEmail.Text = "Email:";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(266, 193);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(104, 43);
            this.btnSignUp.TabIndex = 20;
            this.btnSignUp.Text = "SIGN UP";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(110, 50);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '*';
            this.txtUserPassword.Size = new System.Drawing.Size(260, 22);
            this.txtUserPassword.TabIndex = 17;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(111, 12);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(260, 22);
            this.txtUserName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Password:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(1, 13);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(90, 16);
            this.lblUserName.TabIndex = 14;
            this.lblUserName.Text = "User Name:";
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Location = new System.Drawing.Point(14, 169);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(82, 16);
            this.lblUserRole.TabIndex = 22;
            this.lblUserRole.Text = "User Role:";
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.cmbUserRole.Location = new System.Drawing.Point(111, 163);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(259, 24);
            this.cmbUserRole.TabIndex = 23;
            // 
            // AdminAppUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 248);
            this.Controls.Add(this.cmbUserRole);
            this.Controls.Add(this.lblUserRole);
            this.Controls.Add(this.lblEmailCheck);
            this.Controls.Add(this.txtUserEmail);
            this.Controls.Add(this.lblUserEmail);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUserName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminAppUser";
            this.Text = "AdminAppUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmailCheck;
        private System.Windows.Forms.MaskedTextBox txtUserEmail;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.MaskedTextBox txtUserPassword;
        private System.Windows.Forms.MaskedTextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.ComboBox cmbUserRole;
    }
}