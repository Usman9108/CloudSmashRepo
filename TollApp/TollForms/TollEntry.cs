using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using TollApp.Helper;
using TollClassLibrary.Helper;
using TollClassLibrary.ViewModels;

namespace TollApp
{
    public partial class FormEntry : Form
    {
        public FormEntry()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Prevents resizing
            this.MaximizeBox = false;
            tollEntryForm.TollButtonClicked += TollEntryForm_TollButtonClicked;
        }

        public async Task PostEntryTollAsync(TollModel entry)
        {
            try
            {
                string json = JsonSerializer.Serialize(entry);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await HttpClientInstance.GetClient().PostAsync(StringConstants.TollEntryUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(this,"Toll Entry Recorded Successfully!");
                    tollEntryForm.ResetControls();
                }
                else
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(this,$"Not Able to Add Toll Entry Record");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,$"Exception was thrown by Server");
            }
        }
        

        private async void TollEntryForm_TollButtonClicked(object? sender, EventArgs e)
        {
            await PostEntryTollAsync(tollEntryForm.TollModel);

        }
    }
}
