namespace Happy_Journey_Airline
{
    partial class CreateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUser));
            this.lblfname = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.lblgender = new System.Windows.Forms.Label();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.lblphone = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.lblrole = new System.Windows.Forms.Label();
            this.cmbrole = new System.Windows.Forms.ComboBox();
            this.lblbirthdate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btncreate = new System.Windows.Forms.Button();
            this.lblbalance = new System.Windows.Forms.Label();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.lblcreate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.lbllname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfname.Location = new System.Drawing.Point(46, 105);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(106, 24);
            this.lblfname.TabIndex = 5;
            this.lblfname.Text = "First Name:";
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(168, 109);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(178, 20);
            this.txtfname.TabIndex = 29;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(46, 206);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(102, 24);
            this.lblusername.TabIndex = 30;
            this.lblusername.Text = "Username:";
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(168, 211);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(178, 20);
            this.usertxt.TabIndex = 31;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(46, 261);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(97, 24);
            this.lblpass.TabIndex = 32;
            this.lblpass.Text = "Password:";
            this.lblpass.Click += new System.EventHandler(this.passlbl_Click);
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(168, 261);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(178, 20);
            this.passtxt.TabIndex = 33;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(46, 307);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(62, 24);
            this.lblemail.TabIndex = 34;
            this.lblemail.Text = "Email:";
            this.lblemail.Click += new System.EventHandler(this.emaillbl_Click);
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(168, 311);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(178, 20);
            this.emailtxt.TabIndex = 35;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(423, 311);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(79, 24);
            this.lblgender.TabIndex = 36;
            this.lblgender.Text = "Gender:";
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Location = new System.Drawing.Point(527, 318);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(48, 17);
            this.rbmale.TabIndex = 37;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "Male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Location = new System.Drawing.Point(610, 318);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(59, 17);
            this.rbfemale.TabIndex = 38;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "Female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.Location = new System.Drawing.Point(423, 103);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(71, 24);
            this.lblphone.TabIndex = 39;
            this.lblphone.Text = "Phone:";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(530, 104);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(178, 20);
            this.txtphone.TabIndex = 40;
            // 
            // lblrole
            // 
            this.lblrole.AutoSize = true;
            this.lblrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrole.Location = new System.Drawing.Point(423, 155);
            this.lblrole.Name = "lblrole";
            this.lblrole.Size = new System.Drawing.Size(54, 24);
            this.lblrole.TabIndex = 41;
            this.lblrole.Text = "Role:";
            // 
            // cmbrole
            // 
            this.cmbrole.FormattingEnabled = true;
            this.cmbrole.Location = new System.Drawing.Point(530, 155);
            this.cmbrole.Name = "cmbrole";
            this.cmbrole.Size = new System.Drawing.Size(178, 21);
            this.cmbrole.TabIndex = 42;
            this.cmbrole.Text = "select";
            // 
            // lblbirthdate
            // 
            this.lblbirthdate.AutoSize = true;
            this.lblbirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbirthdate.Location = new System.Drawing.Point(423, 261);
            this.lblbirthdate.Name = "lblbirthdate";
            this.lblbirthdate.Size = new System.Drawing.Size(95, 24);
            this.lblbirthdate.TabIndex = 43;
            this.lblbirthdate.Text = "Birth Date:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(530, 261);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(178, 20);
            this.dateTimePicker.TabIndex = 44;
            // 
            // btncreate
            // 
            this.btncreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreate.Location = new System.Drawing.Point(630, 388);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(129, 38);
            this.btncreate.TabIndex = 45;
            this.btncreate.Text = "Create";
            this.btncreate.UseVisualStyleBackColor = false;
            this.btncreate.Click += new System.EventHandler(this.createbtn_Click);
            // 
            // lblbalance
            // 
            this.lblbalance.AutoSize = true;
            this.lblbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbalance.Location = new System.Drawing.Point(423, 206);
            this.lblbalance.Name = "lblbalance";
            this.lblbalance.Size = new System.Drawing.Size(83, 24);
            this.lblbalance.TabIndex = 66;
            this.lblbalance.Text = "Balance:";
            // 
            // txtbalance
            // 
            this.txtbalance.Location = new System.Drawing.Point(530, 210);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(178, 20);
            this.txtbalance.TabIndex = 67;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.lblcreate);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(-3, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 65);
            this.panel1.TabIndex = 98;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnback.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(682, 15);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(107, 33);
            this.btnback.TabIndex = 26;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lblcreate
            // 
            this.lblcreate.AutoSize = true;
            this.lblcreate.Font = new System.Drawing.Font("Sitka Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcreate.Location = new System.Drawing.Point(3, 0);
            this.lblcreate.Name = "lblcreate";
            this.lblcreate.Size = new System.Drawing.Size(243, 58);
            this.lblcreate.TabIndex = 3;
            this.lblcreate.Text = "Create User";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(-2, 441);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 13);
            this.panel2.TabIndex = 104;
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(168, 159);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(178, 20);
            this.txtlname.TabIndex = 106;
            // 
            // lbllname
            // 
            this.lbllname.AutoSize = true;
            this.lbllname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllname.Location = new System.Drawing.Point(46, 155);
            this.lbllname.Name = "lbllname";
            this.lbllname.Size = new System.Drawing.Size(104, 24);
            this.lbllname.TabIndex = 105;
            this.lbllname.Text = "Last Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Happy_Journey_Airline.Properties.Resources.Screenshot_2024_12_04_004028;
            this.pictureBox1.Location = new System.Drawing.Point(272, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 107;
            this.pictureBox1.TabStop = false;
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.lbllname);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtbalance);
            this.Controls.Add(this.lblbalance);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblbirthdate);
            this.Controls.Add(this.cmbrole);
            this.Controls.Add(this.lblrole);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.rbfemale);
            this.Controls.Add(this.rbmale);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.lblfname);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateUser";
            this.Text = "CreateUser";
            this.Load += new System.EventHandler(this.CreateUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblfname;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lblrole;
        private System.Windows.Forms.ComboBox cmbrole;
        private System.Windows.Forms.Label lblbirthdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Label lblbalance;
        private System.Windows.Forms.TextBox txtbalance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label lblcreate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.Label lbllname;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}