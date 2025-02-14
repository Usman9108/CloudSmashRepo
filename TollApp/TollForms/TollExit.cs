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
    public partial class FormExit : Form
    {
        public FormExit()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Prevents resizing
            this.MaximizeBox = false;
            tollEntryForm.ButtonText = "Calculate";
            tollEntryForm.TitleLable = "Exit";
            tollEntryForm.TollButtonClicked += TollEntryForm_TollButtonClicked;
        }
        public async Task<RTOExit> PostExitTollAsync(TollModel exit)
        {
            try
            {
                string json = JsonSerializer.Serialize(exit);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await HttpClientInstance.GetClient().PostAsync(StringConstants.TollExitUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(this, "Toll Exit Recorded Successfully!");
                    var data = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    tollEntryForm.ResetControls();
                    return JsonSerializer.Deserialize<RTOExit>(data, options)!;
                    

                }
                else
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(this, $"Not Able to Add Toll Exit Record");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Exception was thrown by Server");
            }
            return new RTOExit();
        }
        private async void TollEntryForm_TollButtonClicked(object? sender, EventArgs e)
        {
            var rtoExit = await PostExitTollAsync(tollEntryForm.TollModel);
            tollAmount.RTOExit = rtoExit;
        }
    }
}
