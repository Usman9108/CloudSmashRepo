namespace TollApp
{
    partial class TollAmount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHeading = new Label();
            lblBaseRate = new Label();
            lblDistanceCost = new Label();
            lblDistanceCovered = new Label();
            lblDistanceRate = new Label();
            lblWeekendRate = new Label();
            lblSubTotal = new Label();
            lblDiscount = new Label();
            lbl = new Label();
            tbBaseRate = new TextBox();
            tbDistanceCovered = new TextBox();
            tbDistanceRate = new TextBox();
            tbWeekEndCharges = new TextBox();
            tbSubTotal = new TextBox();
            tbDiscount = new TextBox();
            tbTotal = new TextBox();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.Location = new Point(40, 28);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(180, 25);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Break Down of Cost";
            // 
            // lblBaseRate
            // 
            lblBaseRate.AutoSize = true;
            lblBaseRate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBaseRate.Location = new Point(91, 74);
            lblBaseRate.Name = "lblBaseRate";
            lblBaseRate.Size = new Size(92, 23);
            lblBaseRate.TabIndex = 1;
            lblBaseRate.Text = "Base Rate:";
            // 
            // lblDistanceCost
            // 
            lblDistanceCost.AutoSize = true;
            lblDistanceCost.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDistanceCost.Location = new Point(63, 116);
            lblDistanceCost.Name = "lblDistanceCost";
            lblDistanceCost.Size = new Size(127, 25);
            lblDistanceCost.TabIndex = 2;
            lblDistanceCost.Text = "Distance Cost";
            // 
            // lblDistanceCovered
            // 
            lblDistanceCovered.AutoSize = true;
            lblDistanceCovered.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDistanceCovered.Location = new Point(91, 154);
            lblDistanceCovered.Name = "lblDistanceCovered";
            lblDistanceCovered.Size = new Size(154, 23);
            lblDistanceCovered.TabIndex = 3;
            lblDistanceCovered.Text = "Distance Covered:";
            // 
            // lblDistanceRate
            // 
            lblDistanceRate.AutoSize = true;
            lblDistanceRate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDistanceRate.Location = new Point(91, 190);
            lblDistanceRate.Name = "lblDistanceRate";
            lblDistanceRate.Size = new Size(124, 23);
            lblDistanceRate.TabIndex = 4;
            lblDistanceRate.Text = "Distance Rate:";
            // 
            // lblWeekendRate
            // 
            lblWeekendRate.AutoSize = true;
            lblWeekendRate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWeekendRate.Location = new Point(91, 227);
            lblWeekendRate.Name = "lblWeekendRate";
            lblWeekendRate.Size = new Size(159, 23);
            lblWeekendRate.TabIndex = 5;
            lblWeekendRate.Text = "Weekend Charges:";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubTotal.Location = new Point(91, 266);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(90, 23);
            lblSubTotal.TabIndex = 6;
            lblSubTotal.Text = "Sub Total:";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiscount.Location = new Point(93, 311);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(140, 23);
            lblDiscount.TabIndex = 7;
            lblDiscount.Text = "Discount/Other:";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.Location = new Point(40, 356);
            lbl.Name = "lbl";
            lbl.Size = new Size(219, 25);
            lbl.TabIndex = 8;
            lbl.Text = "TOTAL TO BE CHARGED:";
            // 
            // tbBaseRate
            // 
            tbBaseRate.Location = new Point(274, 73);
            tbBaseRate.Name = "tbBaseRate";
            tbBaseRate.Size = new Size(158, 27);
            tbBaseRate.TabIndex = 9;
            tbBaseRate.Enabled = false;
            // 
            // tbDistanceCovered
            // 
            tbDistanceCovered.Location = new Point(274, 153);
            tbDistanceCovered.Name = "tbDistanceCovered";
            tbDistanceCovered.Size = new Size(158, 27);
            tbDistanceCovered.TabIndex = 10;
            tbDistanceCovered.Enabled = false;
            // 
            // tbDistanceRate
            // 
            tbDistanceRate.Location = new Point(274, 190);
            tbDistanceRate.Name = "tbDistanceRate";
            tbDistanceRate.Size = new Size(158, 27);
            tbDistanceRate.TabIndex = 11;
            tbDistanceRate.Enabled = false;
            // 
            // tbWeekEndCharges
            // 
            tbWeekEndCharges.Location = new Point(274, 226);
            tbWeekEndCharges.Name = "tbWeekEndCharges";
            tbWeekEndCharges.Size = new Size(158, 27);
            tbWeekEndCharges.TabIndex = 12;
            tbWeekEndCharges.Enabled = false;
            // 
            // tbSubTotal
            // 
            tbSubTotal.Location = new Point(274, 265);
            tbSubTotal.Name = "tbSubTotal";
            tbSubTotal.Size = new Size(158, 27);
            tbSubTotal.TabIndex = 13;
            tbSubTotal.Enabled = false;
            // 
            // tbDiscount
            // 
            tbDiscount.Location = new Point(274, 307);
            tbDiscount.Name = "tbDiscount";
            tbDiscount.Size = new Size(158, 27);
            tbDiscount.TabIndex = 14;
            tbDiscount.Enabled = false;
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(274, 357);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(158, 27);
            tbTotal.TabIndex = 15;
            tbTotal.Enabled = false;
            // 
            // TollAmount
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tbTotal);
            Controls.Add(tbDiscount);
            Controls.Add(tbSubTotal);
            Controls.Add(tbWeekEndCharges);
            Controls.Add(tbDistanceRate);
            Controls.Add(tbDistanceCovered);
            Controls.Add(tbBaseRate);
            Controls.Add(lbl);
            Controls.Add(lblDiscount);
            Controls.Add(lblSubTotal);
            Controls.Add(lblWeekendRate);
            Controls.Add(lblDistanceRate);
            Controls.Add(lblDistanceCovered);
            Controls.Add(lblDistanceCost);
            Controls.Add(lblBaseRate);
            Controls.Add(lblHeading);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "TollAmount";
            Size = new Size(514, 406);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private Label lblBaseRate;
        private Label lblDistanceCost;
        private Label lblDistanceCovered;
        private Label lblDistanceRate;
        private Label lblWeekendRate;
        private Label lblSubTotal;
        private Label lblDiscount;
        private Label lbl;
        private TextBox tbBaseRate;
        private TextBox tbDistanceCovered;
        private TextBox tbDistanceRate;
        private TextBox tbWeekEndCharges;
        private TextBox tbSubTotal;
        private TextBox tbDiscount;
        private TextBox tbTotal;
    }
}
