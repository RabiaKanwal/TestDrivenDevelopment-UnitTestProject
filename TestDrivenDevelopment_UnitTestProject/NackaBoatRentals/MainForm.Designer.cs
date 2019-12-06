namespace NackaBoatRentals
{
    partial class MainForm
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
            this.btnBoatReturned = new System.Windows.Forms.Button();
            this.btnRentBoat = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(180, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nacka Boat Rentals - Welcome";
            // 
            // btnBoatReturned
            // 
            this.btnBoatReturned.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBoatReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoatReturned.Location = new System.Drawing.Point(405, 154);
            this.btnBoatReturned.Name = "btnBoatReturned";
            this.btnBoatReturned.Size = new System.Drawing.Size(237, 95);
            this.btnBoatReturned.TabIndex = 2;
            this.btnBoatReturned.Text = "Boat Return";
            this.btnBoatReturned.UseVisualStyleBackColor = false;
            this.btnBoatReturned.Click += new System.EventHandler(this.btnBoatReturned_Click);
            // 
            // btnRentBoat
            // 
            this.btnRentBoat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRentBoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentBoat.Location = new System.Drawing.Point(142, 154);
            this.btnRentBoat.Name = "btnRentBoat";
            this.btnRentBoat.Size = new System.Drawing.Size(237, 95);
            this.btnRentBoat.TabIndex = 1;
            this.btnRentBoat.Text = "Rent Boat";
            this.btnRentBoat.UseVisualStyleBackColor = false;
            this.btnRentBoat.Click += new System.EventHandler(this.btnRentBoat_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(328, 277);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 31);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRentBoat);
            this.Controls.Add(this.btnBoatReturned);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBoatReturned;
        private System.Windows.Forms.Button btnRentBoat;
        private System.Windows.Forms.Button btnExit;
    }
}