using System.Windows.Forms;

namespace TollApp
{
    partial class TollEntryForm
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
            lblTitle = new Label();
            cb_InterChange = new ComboBox();
            textBox1 = new TextBox();
            dtPicker = new DateTimePicker();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(34, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(57, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Entry";
            // 
            // cb_InterChange
            // 
            cb_InterChange.FormattingEnabled = true;
            cb_InterChange.Location = new Point(34, 98);
            cb_InterChange.Name = "cb_InterChange";
            cb_InterChange.Size = new Size(250, 28);
            cb_InterChange.TabIndex = 1;
            cb_InterChange.SelectedIndexChanged += cb_InterChange_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 163);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Number-Plate";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += TextBox1_TextChanged;
            // 
            // dtPicker
            // 
            dtPicker.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            dtPicker.Format = DateTimePickerFormat.Custom;
            dtPicker.Location = new Point(34, 239);
            dtPicker.Name = "dtPicker";
            dtPicker.Size = new Size(250, 27);
            dtPicker.TabIndex = 3;
            dtPicker.ValueChanged += dtPicker_ValueChanged;
            dtPicker.Enter += DtPicker_Enter;
            dtPicker.Leave += DtPicker_Leave;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(192, 255, 192);
            btnSubmit.Location = new Point(308, 305);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // TollEntryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnSubmit);
            Controls.Add(dtPicker);
            Controls.Add(textBox1);
            Controls.Add(cb_InterChange);
            Controls.Add(lblTitle);
            Name = "TollEntryForm";
            Size = new Size(424, 379);
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label lblTitle;
        private ComboBox cb_InterChange;
        private TextBox textBox1;
        private DateTimePicker dtPicker;
        private Button btnSubmit;
    }
}
