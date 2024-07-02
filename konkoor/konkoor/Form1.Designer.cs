namespace konkoor
{
    partial class Form1
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.conpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwords = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernamestext = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.conpass);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.passwords);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.usernamestext);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(285, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 414);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(594, 297);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 25);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(563, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "sign in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // conpass
            // 
            this.conpass.Location = new System.Drawing.Point(277, 275);
            this.conpass.Name = "conpass";
            this.conpass.Size = new System.Drawing.Size(185, 22);
            this.conpass.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "confirm password";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(277, 345);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(185, 22);
            this.email.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // passwords
            // 
            this.passwords.Location = new System.Drawing.Point(277, 210);
            this.passwords.Name = "passwords";
            this.passwords.Size = new System.Drawing.Size(185, 22);
            this.passwords.TabIndex = 4;
            this.passwords.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "password";
            // 
            // usernamestext
            // 
            this.usernamestext.Location = new System.Drawing.Point(277, 128);
            this.usernamestext.Name = "usernamestext";
            this.usernamestext.Size = new System.Drawing.Size(185, 22);
            this.usernamestext.TabIndex = 2;
            this.usernamestext.TextChanged += new System.EventHandler(this.usernames_TextChanged);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(92, 128);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(99, 25);
            this.username.TabIndex = 1;
            this.username.Text = "username";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "sign in";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 521);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox passwords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernamestext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox conpass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

