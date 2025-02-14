namespace TollApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExit = new Button();
            btnEntry = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(192, 255, 192);
            btnExit.Location = new Point(3, 69);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(244, 49);
            btnExit.TabIndex = 1;
            btnExit.Text = "Toll Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnEntry
            // 
            btnEntry.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEntry.BackColor = Color.FromArgb(192, 255, 192);
            btnEntry.Location = new Point(3, 3);
            btnEntry.Name = "btnEntry";
            btnEntry.Size = new Size(244, 49);
            btnEntry.TabIndex = 0;
            btnEntry.Text = "Toll Entry";
            btnEntry.UseVisualStyleBackColor = false;
            btnEntry.Click += btnEntry_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnEntry, 0, 0);
            tableLayoutPanel1.Controls.Add(btnExit, 0, 1);
            tableLayoutPanel1.Location = new Point(272, 144);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(250, 125);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(500, 400);
            Name = "MainForm";
            Text = "Toll Calculation";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Button btnEntry;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
