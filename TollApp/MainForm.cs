using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace TollApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Prevents resizing
            this.MaximizeBox = false;
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            FormEntry formEntry = new FormEntry();
            formEntry.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormExit formExit = new FormExit();
            formExit.ShowDialog();
        }
    }

}

