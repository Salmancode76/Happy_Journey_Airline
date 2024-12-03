namespace Happy_Journey_Airline
{
    partial class UpdateFlightcs
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
            this.label1 = new System.Windows.Forms.Label();
            this.FlightNolbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.capacitylbl = new System.Windows.Forms.Label();
            this.captxt = new System.Windows.Forms.TextBox();
            this.destlbl = new System.Windows.Forms.Label();
            this.Deptlbl = new System.Windows.Forms.Label();
            this.pricelbl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Durationtxt = new System.Windows.Forms.TextBox();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Deptcmb = new System.Windows.Forms.ComboBox();
            this.Descmb = new System.Windows.Forms.ComboBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.statuslbl = new System.Windows.Forms.Label();
            this.statustxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(287, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Update Flight";
            // 
            // FlightNolbl
            // 
            this.FlightNolbl.AutoSize = true;
            this.FlightNolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightNolbl.Location = new System.Drawing.Point(34, 93);
            this.FlightNolbl.Name = "FlightNolbl";
            this.FlightNolbl.Size = new System.Drawing.Size(91, 24);
            this.FlightNolbl.TabIndex = 2;
            this.FlightNolbl.Text = "Flight No:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // capacitylbl
            // 
            this.capacitylbl.AutoSize = true;
            this.capacitylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacitylbl.Location = new System.Drawing.Point(34, 156);
            this.capacitylbl.Name = "capacitylbl";
            this.capacitylbl.Size = new System.Drawing.Size(86, 24);
            this.capacitylbl.TabIndex = 12;
            this.capacitylbl.Text = "Capacity:";
            // 
            // captxt
            // 
            this.captxt.Location = new System.Drawing.Point(143, 160);
            this.captxt.Name = "captxt";
            this.captxt.Size = new System.Drawing.Size(197, 20);
            this.captxt.TabIndex = 13;
            // 
            // destlbl
            // 
            this.destlbl.AutoSize = true;
            this.destlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destlbl.Location = new System.Drawing.Point(34, 220);
            this.destlbl.Name = "destlbl";
            this.destlbl.Size = new System.Drawing.Size(107, 24);
            this.destlbl.TabIndex = 14;
            this.destlbl.Text = "Destination:";
            // 
            // Deptlbl
            // 
            this.Deptlbl.AutoSize = true;
            this.Deptlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deptlbl.Location = new System.Drawing.Point(386, 89);
            this.Deptlbl.Name = "Deptlbl";
            this.Deptlbl.Size = new System.Drawing.Size(98, 24);
            this.Deptlbl.TabIndex = 16;
            this.Deptlbl.Text = "Departure:";
            this.Deptlbl.Click += new System.EventHandler(this.Deptlbl_Click);
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelbl.Location = new System.Drawing.Point(386, 155);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(109, 24);
            this.pricelbl.TabIndex = 18;
            this.pricelbl.Text = "Flight Price:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(504, 156);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 20);
            this.textBox2.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Duration:";
            // 
            // Durationtxt
            // 
            this.Durationtxt.Location = new System.Drawing.Point(504, 220);
            this.Durationtxt.Name = "Durationtxt";
            this.Durationtxt.Size = new System.Drawing.Size(197, 20);
            this.Durationtxt.TabIndex = 28;
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebtn.Location = new System.Drawing.Point(659, 386);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(129, 38);
            this.Savebtn.TabIndex = 29;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = false;
            // 
            // Deptcmb
            // 
            this.Deptcmb.FormattingEnabled = true;
            this.Deptcmb.Location = new System.Drawing.Point(504, 95);
            this.Deptcmb.Name = "Deptcmb";
            this.Deptcmb.Size = new System.Drawing.Size(197, 21);
            this.Deptcmb.TabIndex = 31;
            // 
            // Descmb
            // 
            this.Descmb.FormattingEnabled = true;
            this.Descmb.Location = new System.Drawing.Point(143, 221);
            this.Descmb.Name = "Descmb";
            this.Descmb.Size = new System.Drawing.Size(197, 21);
            this.Descmb.TabIndex = 32;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(681, 12);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(107, 33);
            this.backbtn.TabIndex = 33;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            // 
            // statuslbl
            // 
            this.statuslbl.AutoSize = true;
            this.statuslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslbl.Location = new System.Drawing.Point(34, 289);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(65, 24);
            this.statuslbl.TabIndex = 36;
            this.statuslbl.Text = "Status:";
            // 
            // statustxt
            // 
            this.statustxt.Location = new System.Drawing.Point(143, 289);
            this.statustxt.Name = "statustxt";
            this.statustxt.Size = new System.Drawing.Size(197, 20);
            this.statustxt.TabIndex = 37;
            // 
            // UpdateFlightcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statustxt);
            this.Controls.Add(this.statuslbl);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.Descmb);
            this.Controls.Add(this.Deptcmb);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Durationtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pricelbl);
            this.Controls.Add(this.Deptlbl);
            this.Controls.Add(this.destlbl);
            this.Controls.Add(this.captxt);
            this.Controls.Add(this.capacitylbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FlightNolbl);
            this.Controls.Add(this.label1);
            this.Name = "UpdateFlightcs";
            this.Text = "UpdateFlightcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FlightNolbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label capacitylbl;
        private System.Windows.Forms.TextBox captxt;
        private System.Windows.Forms.Label destlbl;
        private System.Windows.Forms.Label Deptlbl;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Durationtxt;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.ComboBox Deptcmb;
        private System.Windows.Forms.ComboBox Descmb;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label statuslbl;
        private System.Windows.Forms.TextBox statustxt;
    }
}