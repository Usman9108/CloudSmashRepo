﻿namespace TollApp
{
    partial class FormEntry
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
            panel1 = new Panel();
            tollEntryForm = new TollEntryForm();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tollEntryForm);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 382);
            panel1.TabIndex = 0;
            // 
            // tollEntryForm
            // 
            tollEntryForm.BackColor = Color.White;
            tollEntryForm.ButtonText = "Submit";
            tollEntryForm.Location = new Point(0, 0);
            tollEntryForm.Name = "tollEntryForm";
            tollEntryForm.Size = new Size(424, 379);
            tollEntryForm.TabIndex = 0;
            // 
            // FormEntry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 382);
            Controls.Add(panel1);
            Name = "FormEntry";
            Text = "Toll Entry";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TollEntryForm tollEntryForm;
    }
}