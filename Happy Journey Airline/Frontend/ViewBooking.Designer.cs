namespace Happy_Journey_Airline.Frontend
{
    partial class ViewBookFlight
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFlights = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnFilterFlights = new System.Windows.Forms.Button();
            this.gridFlight = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFlight)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(-32, 536);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1073, 12);
            this.panel2.TabIndex = 100;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lblFlights);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(-32, -6);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 76);
            this.panel1.TabIndex = 99;
            // 
            // lblFlights
            // 
            this.lblFlights.AutoSize = true;
            this.lblFlights.Font = new System.Drawing.Font("Sitka Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlights.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFlights.Location = new System.Drawing.Point(433, 0);
            this.lblFlights.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlights.Name = "lblFlights";
            this.lblFlights.Size = new System.Drawing.Size(190, 72);
            this.lblFlights.TabIndex = 3;
            this.lblFlights.Text = "Flights";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(45, 19);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(143, 41);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(8, 86);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(195, 35);
            this.lblDesc.TabIndex = 98;
            this.lblDesc.Text = "Current Flights:";
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBook.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(719, 134);
            this.btnBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(209, 39);
            this.btnBook.TabIndex = 97;
            this.btnBook.Text = "Book Flight";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnFilterFlights
            // 
            this.btnFilterFlights.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFilterFlights.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterFlights.Location = new System.Drawing.Point(719, 280);
            this.btnFilterFlights.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilterFlights.Name = "btnFilterFlights";
            this.btnFilterFlights.Size = new System.Drawing.Size(209, 39);
            this.btnFilterFlights.TabIndex = 96;
            this.btnFilterFlights.Text = "Delete Flight";
            this.btnFilterFlights.UseVisualStyleBackColor = false;
            // 
            // gridFlight
            // 
            this.gridFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFlight.Location = new System.Drawing.Point(13, 134);
            this.gridFlight.Margin = new System.Windows.Forms.Padding(4);
            this.gridFlight.Name = "gridFlight";
            this.gridFlight.RowHeadersWidth = 51;
            this.gridFlight.Size = new System.Drawing.Size(680, 321);
            this.gridFlight.TabIndex = 94;
            this.gridFlight.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFlight_CellContentClick);
            // 
            // ViewBookFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 524);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnFilterFlights);
            this.Controls.Add(this.gridFlight);
            this.Name = "ViewBookFlight";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ViewBookFlight_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFlight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFlights;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnFilterFlights;
        private System.Windows.Forms.DataGridView gridFlight;
    }
}