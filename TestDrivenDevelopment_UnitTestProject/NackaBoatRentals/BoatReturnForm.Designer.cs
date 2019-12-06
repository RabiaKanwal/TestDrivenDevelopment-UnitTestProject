namespace NackaBoatRentals
{
    partial class BoatReturnForm
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
            this.dataGridViewRentedBoats = new System.Windows.Forms.DataGridView();
            this.dtReturnTime = new System.Windows.Forms.DateTimePicker();
            this.dtReturnDate = new System.Windows.Forms.DateTimePicker();
            this.btnBoatReturned = new System.Windows.Forms.Button();
            this.dateTime = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.boatNumber = new System.Windows.Forms.Label();
            this.txtBoatNumber = new System.Windows.Forms.TextBox();
            this.lblTotalPayable = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentedBoats)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label1.Location = new System.Drawing.Point(45, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Below is a list of all the boats currently rented out";
            // 
            // dataGridViewRentedBoats
            // 
            this.dataGridViewRentedBoats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRentedBoats.Location = new System.Drawing.Point(48, 266);
            this.dataGridViewRentedBoats.Name = "dataGridViewRentedBoats";
            this.dataGridViewRentedBoats.Size = new System.Drawing.Size(690, 150);
            this.dataGridViewRentedBoats.TabIndex = 2;
            // 
            // dtReturnTime
            // 
            this.dtReturnTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtReturnTime.Location = new System.Drawing.Point(425, 87);
            this.dtReturnTime.Name = "dtReturnTime";
            this.dtReturnTime.ShowUpDown = true;
            this.dtReturnTime.Size = new System.Drawing.Size(92, 20);
            this.dtReturnTime.TabIndex = 22;
            // 
            // dtReturnDate
            // 
            this.dtReturnDate.CustomFormat = "yyyy-MM-dd";
            this.dtReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtReturnDate.Location = new System.Drawing.Point(336, 87);
            this.dtReturnDate.Name = "dtReturnDate";
            this.dtReturnDate.Size = new System.Drawing.Size(83, 20);
            this.dtReturnDate.TabIndex = 21;
            // 
            // btnBoatReturned
            // 
            this.btnBoatReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBoatReturned.Location = new System.Drawing.Point(336, 128);
            this.btnBoatReturned.Name = "btnBoatReturned";
            this.btnBoatReturned.Size = new System.Drawing.Size(112, 29);
            this.btnBoatReturned.TabIndex = 20;
            this.btnBoatReturned.Text = "Boat Return";
            this.btnBoatReturned.UseVisualStyleBackColor = true;
            this.btnBoatReturned.Click += new System.EventHandler(this.btnBoatReturned_Click);
            // 
            // dateTime
            // 
            this.dateTime.AutoSize = true;
            this.dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Location = new System.Drawing.Point(150, 87);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(180, 16);
            this.dateTime.TabIndex = 19;
            this.dateTime.Text = "Date and Time of Return:";
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.back.Location = new System.Drawing.Point(701, 33);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 36);
            this.back.TabIndex = 23;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // boatNumber
            // 
            this.boatNumber.AutoSize = true;
            this.boatNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boatNumber.Location = new System.Drawing.Point(150, 52);
            this.boatNumber.Name = "boatNumber";
            this.boatNumber.Size = new System.Drawing.Size(102, 16);
            this.boatNumber.TabIndex = 25;
            this.boatNumber.Text = "Boat Number:";
            // 
            // txtBoatNumber
            // 
            this.txtBoatNumber.Location = new System.Drawing.Point(336, 49);
            this.txtBoatNumber.Name = "txtBoatNumber";
            this.txtBoatNumber.Size = new System.Drawing.Size(135, 20);
            this.txtBoatNumber.TabIndex = 24;
            // 
            // lblTotalPayable
            // 
            this.lblTotalPayable.AutoSize = true;
            this.lblTotalPayable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayable.Location = new System.Drawing.Point(217, 193);
            this.lblTotalPayable.Name = "lblTotalPayable";
            this.lblTotalPayable.Size = new System.Drawing.Size(110, 16);
            this.lblTotalPayable.TabIndex = 26;
            this.lblTotalPayable.Text = "Total Payable:";
            // 
            // lblCost
            // 
            this.lblCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(333, 193);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(0, 16);
            this.lblCost.TabIndex = 27;
            // 
            // BoatReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblTotalPayable);
            this.Controls.Add(this.boatNumber);
            this.Controls.Add(this.txtBoatNumber);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dtReturnTime);
            this.Controls.Add(this.dtReturnDate);
            this.Controls.Add(this.btnBoatReturned);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewRentedBoats);
            this.Name = "BoatReturnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoatReturnForm";
            this.Load += new System.EventHandler(this.BoatReturnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentedBoats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewRentedBoats;
        private System.Windows.Forms.DateTimePicker dtReturnTime;
        private System.Windows.Forms.DateTimePicker dtReturnDate;
        private System.Windows.Forms.Button btnBoatReturned;
        private System.Windows.Forms.Label dateTime;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label boatNumber;
        private System.Windows.Forms.TextBox txtBoatNumber;
        private System.Windows.Forms.Label lblTotalPayable;
        private System.Windows.Forms.Label lblCost;
    }
}