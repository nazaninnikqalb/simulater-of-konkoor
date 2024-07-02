namespace konkoor
{
    partial class login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwords = new System.Windows.Forms.TextBox();
            this.usernames = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.passwords);
            this.panel1.Controls.Add(this.usernames);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(160, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 420);
            this.panel1.TabIndex = 0;
            // 
            // passwords
            // 
            this.passwords.Location = new System.Drawing.Point(268, 243);
            this.passwords.Name = "passwords";
            this.passwords.Size = new System.Drawing.Size(206, 22);
            this.passwords.TabIndex = 4;
            // 
            // usernames
            // 
            this.usernames.Location = new System.Drawing.Point(268, 165);
            this.usernames.Name = "usernames";
            this.usernames.Size = new System.Drawing.Size(206, 22);
            this.usernames.TabIndex = 3;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(107, 240);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(96, 25);
            this.password.TabIndex = 2;
            this.password.Text = "password";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(107, 161);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(99, 25);
            this.username.TabIndex = 1;
            this.username.Text = "username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "login";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.IndianRed;
            this.linkLabel1.Location = new System.Drawing.Point(298, 312);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(71, 29);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 557);
            this.Controls.Add(this.panel1);
            this.Name = "login";
            this.Text = "login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox passwords;
        private System.Windows.Forms.TextBox usernames;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}