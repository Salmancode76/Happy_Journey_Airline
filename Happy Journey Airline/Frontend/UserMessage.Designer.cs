﻿namespace Happy_Journey_Airline
{
    partial class UserMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMessage));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblrecievedMessage = new System.Windows.Forms.Label();
            this.txtreciever = new System.Windows.Forms.TextBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.lblreciever = new System.Windows.Forms.Label();
            this.lblEnter = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(-2, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 13);
            this.panel2.TabIndex = 107;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 61);
            this.panel1.TabIndex = 106;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Sitka Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMessage.Location = new System.Drawing.Point(296, 3);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(204, 58);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Messages";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(33, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 33);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(233, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(320, 150);
            this.dataGridView1.TabIndex = 105;
            // 
            // lblrecievedMessage
            // 
            this.lblrecievedMessage.AutoSize = true;
            this.lblrecievedMessage.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrecievedMessage.Location = new System.Drawing.Point(42, 278);
            this.lblrecievedMessage.Name = "lblrecievedMessage";
            this.lblrecievedMessage.Size = new System.Drawing.Size(187, 28);
            this.lblrecievedMessage.TabIndex = 104;
            this.lblrecievedMessage.Text = "Recieved Messages:";
            // 
            // txtreciever
            // 
            this.txtreciever.Location = new System.Drawing.Point(214, 92);
            this.txtreciever.Name = "txtreciever";
            this.txtreciever.Size = new System.Drawing.Size(339, 20);
            this.txtreciever.TabIndex = 103;
            // 
            // btnsend
            // 
            this.btnsend.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsend.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsend.Location = new System.Drawing.Point(443, 218);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(110, 32);
            this.btnsend.TabIndex = 102;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = false;
            // 
            // lblreciever
            // 
            this.lblreciever.AutoSize = true;
            this.lblreciever.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreciever.Location = new System.Drawing.Point(42, 87);
            this.lblreciever.Name = "lblreciever";
            this.lblreciever.Size = new System.Drawing.Size(96, 28);
            this.lblreciever.TabIndex = 101;
            this.lblreciever.Text = "Reciever:";
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.Location = new System.Drawing.Point(42, 138);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(149, 28);
            this.lblEnter.TabIndex = 100;
            this.lblEnter.Text = "Enter Message:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(214, 138);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(339, 74);
            this.txtMessage.TabIndex = 99;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Happy_Journey_Airline.Properties.Resources.Screenshot_2024_12_04_004028;
            this.pictureBox1.Location = new System.Drawing.Point(264, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 108;
            this.pictureBox1.TabStop = false;
            // 
            // UserMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblrecievedMessage);
            this.Controls.Add(this.txtreciever);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.lblreciever);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserMessage";
            this.Text = "UserMessage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblrecievedMessage;
        private System.Windows.Forms.TextBox txtreciever;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Label lblreciever;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}