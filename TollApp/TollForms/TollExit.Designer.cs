namespace TollApp
{
    partial class FormExit
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tollEntryForm = new TollEntryForm();
            tollAmount = new TollAmount();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tollEntryForm, 0, 0);
            tableLayoutPanel1.Controls.Add(tollAmount, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1044, 414);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tollEntryForm
            // 
            tollEntryForm.BackColor = Color.White;
            tollEntryForm.Location = new Point(3, 3);
            tollEntryForm.Name = "tollEntryForm";
            tollEntryForm.Size = new Size(516, 406);
            tollEntryForm.TabIndex = 0;
            // 
            // tollAmount
            // 
            tollAmount.BackColor = Color.White;
            tollAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tollAmount.Location = new Point(525, 3);
            tollAmount.Name = "tollAmount";
            tollAmount.Size = new Size(514, 406);
            tollAmount.TabIndex = 1;
            // 
            // FormExit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 414);
            Controls.Add(tableLayoutPanel1);
            Name = "FormExit";
            Text = "Toll Exit";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TollEntryForm tollEntryForm;
        private TollAmount tollAmount;
    }
}