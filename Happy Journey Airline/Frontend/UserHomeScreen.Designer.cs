namespace Happy_Journey_Airline
{
    partial class UserHomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHomeScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblHome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.btnBookFlight = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMessage = new System.Windows.Forms.Button();
            this.btnSearchFlight = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.lblHome);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 60);
            this.panel1.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogout.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(12, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(107, 33);
            this.btnLogout.TabIndex = 27;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Sitka Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHome.Location = new System.Drawing.Point(326, 0);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(135, 58);
            this.lblHome.TabIndex = 3;
            this.lblHome.Text = "Home";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 441);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 10);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubscribe.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubscribe.Location = new System.Drawing.Point(483, 185);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(155, 38);
            this.btnSubscribe.TabIndex = 28;
            this.btnSubscribe.Text = "View Subscriptions";
            this.btnSubscribe.UseVisualStyleBackColor = false;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // btnBookFlight
            // 
            this.btnBookFlight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBookFlight.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookFlight.Location = new System.Drawing.Point(483, 124);
            this.btnBookFlight.Name = "btnBookFlight";
            this.btnBookFlight.Size = new System.Drawing.Size(155, 38);
            this.btnBookFlight.TabIndex = 27;
            this.btnBookFlight.Text = "Book Flight";
            this.btnBookFlight.UseVisualStyleBackColor = false;
            this.btnBookFlight.Click += new System.EventHandler(this.btnBookFlight_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Happy_Journey_Airline.Properties.Resources.logoo1;
            this.pictureBox1.Location = new System.Drawing.Point(93, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 203);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // btnMessage
            // 
            this.btnMessage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMessage.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessage.Location = new System.Drawing.Point(483, 304);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(155, 38);
            this.btnMessage.TabIndex = 31;
            this.btnMessage.Text = "View Messages";
            this.btnMessage.UseVisualStyleBackColor = false;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // btnSearchFlight
            // 
            this.btnSearchFlight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchFlight.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFlight.Location = new System.Drawing.Point(483, 245);
            this.btnSearchFlight.Name = "btnSearchFlight";
            this.btnSearchFlight.Size = new System.Drawing.Size(155, 38);
            this.btnSearchFlight.TabIndex = 36;
            this.btnSearchFlight.Text = "Search Flights";
            this.btnSearchFlight.UseVisualStyleBackColor = false;
            this.btnSearchFlight.Click += new System.EventHandler(this.btnSearchFlight_Click);
            // 
            // UserHomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearchFlight);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.btnBookFlight);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserHomeScreen";
            this.Text = "UserHomeScreen";
            this.Load += new System.EventHandler(this.UserHomeScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Button btnBookFlight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Button btnSearchFlight;
    }
}