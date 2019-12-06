namespace NackaBoatRentals
{
    partial class RentBoatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentBoatForm));
            this.dataGridViewAvailableBoats = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.txtBookingNumber = new System.Windows.Forms.TextBox();
            this.txtBoatNumber = new System.Windows.Forms.TextBox();
            this.txtSocialSecurityNumber = new System.Windows.Forms.TextBox();
            this.bookingNumber = new System.Windows.Forms.Label();
            this.boatNumber = new System.Windows.Forms.Label();
            this.securityNumber = new System.Windows.Forms.Label();
            this.boatCategory = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.Label();
            this.btnRentBoat = new System.Windows.Forms.Button();
            this.cmbBoatCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtRentDate = new System.Windows.Forms.DateTimePicker();
            this.dtRentTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableBoats)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAvailableBoats
            // 
            this.dataGridViewAvailableBoats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailableBoats.Location = new System.Drawing.Point(46, 344);
            this.dataGridViewAvailableBoats.Name = "dataGridViewAvailableBoats";
            this.dataGridViewAvailableBoats.Size = new System.Drawing.Size(690, 150);
            this.dataGridViewAvailableBoats.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label1.Location = new System.Drawing.Point(43, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Below is a list of all the boats currently available to rent";
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.back.Location = new System.Drawing.Point(700, 32);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 36);
            this.back.TabIndex = 2;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // txtBookingNumber
            // 
            this.txtBookingNumber.Location = new System.Drawing.Point(293, 35);
            this.txtBookingNumber.Name = "txtBookingNumber";
            this.txtBookingNumber.Size = new System.Drawing.Size(121, 20);
            this.txtBookingNumber.TabIndex = 3;
           
            // 
            // txtBoatNumber
            // 
            this.txtBoatNumber.Location = new System.Drawing.Point(293, 71);
            this.txtBoatNumber.Name = "txtBoatNumber";
            this.txtBoatNumber.Size = new System.Drawing.Size(135, 20);
            this.txtBoatNumber.TabIndex = 4;
            // 
            // txtSocialSecurityNumber
            // 
            this.txtSocialSecurityNumber.Location = new System.Drawing.Point(293, 106);
            this.txtSocialSecurityNumber.Name = "txtSocialSecurityNumber";
            this.txtSocialSecurityNumber.Size = new System.Drawing.Size(135, 20);
            this.txtSocialSecurityNumber.TabIndex = 5;
            // 
            // bookingNumber
            // 
            this.bookingNumber.AutoSize = true;
            this.bookingNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingNumber.Location = new System.Drawing.Point(107, 38);
            this.bookingNumber.Name = "bookingNumber";
            this.bookingNumber.Size = new System.Drawing.Size(127, 16);
            this.bookingNumber.TabIndex = 8;
            this.bookingNumber.Text = "Booking Number:";
            // 
            // boatNumber
            // 
            this.boatNumber.AutoSize = true;
            this.boatNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boatNumber.Location = new System.Drawing.Point(107, 74);
            this.boatNumber.Name = "boatNumber";
            this.boatNumber.Size = new System.Drawing.Size(102, 16);
            this.boatNumber.TabIndex = 9;
            this.boatNumber.Text = "Boat Number:";
            // 
            // securityNumber
            // 
            this.securityNumber.AutoSize = true;
            this.securityNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.securityNumber.Location = new System.Drawing.Point(107, 109);
            this.securityNumber.Name = "securityNumber";
            this.securityNumber.Size = new System.Drawing.Size(174, 16);
            this.securityNumber.TabIndex = 10;
            this.securityNumber.Text = "Social Security Number:";
            // 
            // boatCategory
            // 
            this.boatCategory.AutoSize = true;
            this.boatCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boatCategory.Location = new System.Drawing.Point(107, 143);
            this.boatCategory.Name = "boatCategory";
            this.boatCategory.Size = new System.Drawing.Size(111, 16);
            this.boatCategory.TabIndex = 11;
            this.boatCategory.Text = "Boat Category:";
            // 
            // dateTime
            // 
            this.dateTime.AutoSize = true;
            this.dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Location = new System.Drawing.Point(107, 178);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(180, 16);
            this.dateTime.TabIndex = 12;
            this.dateTime.Text = "Date and Time of Rental:";
            // 
            // btnRentBoat
            // 
            this.btnRentBoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRentBoat.Location = new System.Drawing.Point(293, 233);
            this.btnRentBoat.Name = "btnRentBoat";
            this.btnRentBoat.Size = new System.Drawing.Size(119, 33);
            this.btnRentBoat.TabIndex = 13;
            this.btnRentBoat.Text = "Rent Boat";
            this.btnRentBoat.UseVisualStyleBackColor = true;
            this.btnRentBoat.Click += new System.EventHandler(this.btnRentBoat_Click);
            // 
            // cmbBoatCategory
            // 
            this.cmbBoatCategory.FormattingEnabled = true;
            this.cmbBoatCategory.Items.AddRange(new object[] {
            "jolly-boat",
            "< 40 feet",
            ">= 40 feet"});
            this.cmbBoatCategory.Location = new System.Drawing.Point(293, 142);
            this.cmbBoatCategory.Name = "cmbBoatCategory";
            this.cmbBoatCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbBoatCategory.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "(YYMMDD-XXXX)";
            // 
            // dtRentDate
            // 
            this.dtRentDate.CustomFormat = "yyyy-MM-dd";
            this.dtRentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtRentDate.Location = new System.Drawing.Point(293, 178);
            this.dtRentDate.Name = "dtRentDate";
            this.dtRentDate.Size = new System.Drawing.Size(83, 20);
            this.dtRentDate.TabIndex = 17;
            // 
            // dtRentTime
            // 
            this.dtRentTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtRentTime.Location = new System.Drawing.Point(382, 178);
            this.dtRentTime.Name = "dtRentTime";
            this.dtRentTime.ShowUpDown = true;
            this.dtRentTime.Size = new System.Drawing.Size(92, 20);
            this.dtRentTime.TabIndex = 18;
            // 
            // RentBoatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.dtRentTime);
            this.Controls.Add(this.dtRentDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBoatCategory);
            this.Controls.Add(this.btnRentBoat);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.boatCategory);
            this.Controls.Add(this.securityNumber);
            this.Controls.Add(this.boatNumber);
            this.Controls.Add(this.bookingNumber);
            this.Controls.Add(this.txtSocialSecurityNumber);
            this.Controls.Add(this.txtBoatNumber);
            this.Controls.Add(this.txtBookingNumber);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewAvailableBoats);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RentBoatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentBoatForm";
            this.Load += new System.EventHandler(this.RentBoatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableBoats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAvailableBoats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox txtBookingNumber;
        private System.Windows.Forms.TextBox txtBoatNumber;
        private System.Windows.Forms.TextBox txtSocialSecurityNumber;
        private System.Windows.Forms.Label bookingNumber;
        private System.Windows.Forms.Label boatNumber;
        private System.Windows.Forms.Label securityNumber;
        private System.Windows.Forms.Label boatCategory;
        private System.Windows.Forms.Label dateTime;
        private System.Windows.Forms.Button btnRentBoat;
        private System.Windows.Forms.ComboBox cmbBoatCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtRentDate;
        private System.Windows.Forms.DateTimePicker dtRentTime;
    }
}