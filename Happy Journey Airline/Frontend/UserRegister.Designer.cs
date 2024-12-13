namespace Happy_Journey_Airline
{
    partial class UserRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegister));
            this.backbtn = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.phontxt = new System.Windows.Forms.TextBox();
            this.phonetxt = new System.Windows.Forms.Label();
            this.Femalerb = new System.Windows.Forms.RadioButton();
            this.Malerb = new System.Windows.Forms.RadioButton();
            this.Genderlbl = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.Fnametxt = new System.Windows.Forms.TextBox();
            this.uNamelbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lnamelbl = new System.Windows.Forms.Label();
            this.Lnametxt = new System.Windows.Forms.TextBox();
            this.RoleLbl = new System.Windows.Forms.Label();
            this.RoleCB = new System.Windows.Forms.ComboBox();
            this.messagtxt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backbtn.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(35, 439);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(168, 33);
            this.backbtn.TabIndex = 87;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegister.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(504, 439);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(163, 38);
            this.btnRegister.TabIndex = 86;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(504, 176);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 20);
            this.dateTimePicker1.TabIndex = 85;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 28);
            this.label2.TabIndex = 84;
            this.label2.Text = "Birth Date:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // phontxt
            // 
            this.phontxt.Location = new System.Drawing.Point(147, 295);
            this.phontxt.Name = "phontxt";
            this.phontxt.Size = new System.Drawing.Size(178, 20);
            this.phontxt.TabIndex = 81;
            this.phontxt.TextChanged += new System.EventHandler(this.phontxt_TextChanged);
            // 
            // phonetxt
            // 
            this.phonetxt.AutoSize = true;
            this.phonetxt.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonetxt.Location = new System.Drawing.Point(31, 290);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(74, 28);
            this.phonetxt.TabIndex = 80;
            this.phonetxt.Text = "Phone:";
            this.phonetxt.Click += new System.EventHandler(this.phonetxt_Click);
            // 
            // Femalerb
            // 
            this.Femalerb.AutoSize = true;
            this.Femalerb.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Femalerb.Location = new System.Drawing.Point(201, 244);
            this.Femalerb.Name = "Femalerb";
            this.Femalerb.Size = new System.Drawing.Size(62, 20);
            this.Femalerb.TabIndex = 79;
            this.Femalerb.TabStop = true;
            this.Femalerb.Text = "Female";
            this.Femalerb.UseVisualStyleBackColor = true;
            this.Femalerb.CheckedChanged += new System.EventHandler(this.Femalerb_CheckedChanged);
            // 
            // Malerb
            // 
            this.Malerb.AutoSize = true;
            this.Malerb.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Malerb.Location = new System.Drawing.Point(147, 244);
            this.Malerb.Name = "Malerb";
            this.Malerb.Size = new System.Drawing.Size(50, 20);
            this.Malerb.TabIndex = 78;
            this.Malerb.TabStop = true;
            this.Malerb.Text = "Male";
            this.Malerb.UseVisualStyleBackColor = true;
            this.Malerb.CheckedChanged += new System.EventHandler(this.Malerb_CheckedChanged);
            // 
            // Genderlbl
            // 
            this.Genderlbl.AutoSize = true;
            this.Genderlbl.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genderlbl.Location = new System.Drawing.Point(31, 237);
            this.Genderlbl.Name = "Genderlbl";
            this.Genderlbl.Size = new System.Drawing.Size(84, 28);
            this.Genderlbl.TabIndex = 77;
            this.Genderlbl.Text = "Gender:";
            this.Genderlbl.Click += new System.EventHandler(this.Genderlbl_Click);
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(504, 237);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(178, 20);
            this.emailtxt.TabIndex = 76;
            this.emailtxt.TextChanged += new System.EventHandler(this.emailtxt_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(382, 232);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(70, 28);
            this.lblEmail.TabIndex = 75;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(504, 295);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(178, 20);
            this.txtPass.TabIndex = 74;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(382, 290);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(105, 28);
            this.lblPass.TabIndex = 73;
            this.lblPass.Text = "Password:";
            this.lblPass.Click += new System.EventHandler(this.lblPass_Click);
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(147, 174);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(178, 20);
            this.usertxt.TabIndex = 72;
            this.usertxt.TextChanged += new System.EventHandler(this.usertxt_TextChanged);
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.Location = new System.Drawing.Point(31, 174);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(110, 28);
            this.usernamelbl.TabIndex = 71;
            this.usernamelbl.Text = "Username:";
            this.usernamelbl.Click += new System.EventHandler(this.usernamelbl_Click);
            // 
            // Fnametxt
            // 
            this.Fnametxt.Location = new System.Drawing.Point(147, 125);
            this.Fnametxt.Name = "Fnametxt";
            this.Fnametxt.Size = new System.Drawing.Size(178, 20);
            this.Fnametxt.TabIndex = 70;
            this.Fnametxt.TextChanged += new System.EventHandler(this.Fnametxt_TextChanged);
            // 
            // uNamelbl
            // 
            this.uNamelbl.AutoSize = true;
            this.uNamelbl.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uNamelbl.Location = new System.Drawing.Point(31, 120);
            this.uNamelbl.Name = "uNamelbl";
            this.uNamelbl.Size = new System.Drawing.Size(118, 28);
            this.uNamelbl.TabIndex = 69;
            this.uNamelbl.Text = "First Name:";
            this.uNamelbl.Click += new System.EventHandler(this.uNamelbl_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 63);
            this.panel1.TabIndex = 88;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Sitka Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWelcome.Location = new System.Drawing.Point(222, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(275, 58);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Registeration";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 499);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(728, 10);
            this.panel2.TabIndex = 89;
            // 
            // Lnamelbl
            // 
            this.Lnamelbl.AutoSize = true;
            this.Lnamelbl.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lnamelbl.Location = new System.Drawing.Point(384, 125);
            this.Lnamelbl.Name = "Lnamelbl";
            this.Lnamelbl.Size = new System.Drawing.Size(113, 28);
            this.Lnamelbl.TabIndex = 91;
            this.Lnamelbl.Text = "Last Name:";
            this.Lnamelbl.Click += new System.EventHandler(this.Lnamelbl_Click);
            // 
            // Lnametxt
            // 
            this.Lnametxt.Location = new System.Drawing.Point(504, 136);
            this.Lnametxt.Name = "Lnametxt";
            this.Lnametxt.Size = new System.Drawing.Size(178, 20);
            this.Lnametxt.TabIndex = 92;
            this.Lnametxt.TextChanged += new System.EventHandler(this.Lnametxt_TextChanged);
            // 
            // RoleLbl
            // 
            this.RoleLbl.AutoSize = true;
            this.RoleLbl.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleLbl.Location = new System.Drawing.Point(31, 344);
            this.RoleLbl.Name = "RoleLbl";
            this.RoleLbl.Size = new System.Drawing.Size(59, 28);
            this.RoleLbl.TabIndex = 93;
            this.RoleLbl.Text = "Role:";
            this.RoleLbl.Click += new System.EventHandler(this.RoleLbl_Click);
            // 
            // RoleCB
            // 
            this.RoleCB.FormattingEnabled = true;
            this.RoleCB.Location = new System.Drawing.Point(147, 352);
            this.RoleCB.Margin = new System.Windows.Forms.Padding(2);
            this.RoleCB.Name = "RoleCB";
            this.RoleCB.Size = new System.Drawing.Size(114, 21);
            this.RoleCB.TabIndex = 94;
            this.RoleCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // messagtxt
            // 
            this.messagtxt.AutoSize = true;
            this.messagtxt.Location = new System.Drawing.Point(388, 358);
            this.messagtxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messagtxt.Name = "messagtxt";
            this.messagtxt.Size = new System.Drawing.Size(50, 13);
            this.messagtxt.TabIndex = 95;
            this.messagtxt.Text = "Message";
            this.messagtxt.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Happy_Journey_Airline.Properties.Resources.Screenshot_2024_12_04_004028;
            this.pictureBox1.Location = new System.Drawing.Point(258, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // UserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(725, 508);
            this.Controls.Add(this.messagtxt);
            this.Controls.Add(this.RoleCB);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.RoleLbl);
            this.Controls.Add(this.Lnametxt);
            this.Controls.Add(this.Lnamelbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phontxt);
            this.Controls.Add(this.phonetxt);
            this.Controls.Add(this.Femalerb);
            this.Controls.Add(this.Malerb);
            this.Controls.Add(this.Genderlbl);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.usernamelbl);
            this.Controls.Add(this.Fnametxt);
            this.Controls.Add(this.uNamelbl);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserRegister";
            this.Text = "UserRegister";
            this.Load += new System.EventHandler(this.UserRegister_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phontxt;
        private System.Windows.Forms.Label phonetxt;
        private System.Windows.Forms.RadioButton Femalerb;
        private System.Windows.Forms.RadioButton Malerb;
        private System.Windows.Forms.Label Genderlbl;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.TextBox Fnametxt;
        private System.Windows.Forms.Label uNamelbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lnamelbl;
        private System.Windows.Forms.TextBox Lnametxt;
        private System.Windows.Forms.Label RoleLbl;
        private System.Windows.Forms.ComboBox RoleCB;
        private System.Windows.Forms.Label messagtxt;
    }
}