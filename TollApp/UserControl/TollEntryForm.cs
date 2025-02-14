using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
    public partial class TollEntryForm : UserControl
    {
        public event EventHandler TollButtonClicked;
        private System.Windows.Forms.Timer timer;
        private bool isManuallyModified = false;
        public TollModel TollModel { get; set; }
        public string ButtonText
        {
            get
            {
                return btnSubmit.Text;
            }
            set
            {
                btnSubmit.Text = value;
            }
        }

        public string TitleLable
        {
            get
            {
                return lblTitle.Text;
            }
            set
            {
                lblTitle.Text = value;
            }
        }
        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer
            {
                Interval = 1000 // Update every second
            };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if(!isManuallyModified)
            {
                dtPicker.Value = DateTime.Now;
                setModelDate(dtPicker.Value);
            }
        }

        public IEnumerable<string> GetInterchangeList()
        {
            var response = HttpClientInstance.GetClient().GetAsync(StringConstants.GetInterchangeUrl).Result;
            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                return JsonSerializer.Deserialize<IEnumerable<string>>(data)!;
            }
            return null;
        }

        private void cb_InterChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cb_InterChange.SelectedIndex != -1) // Ensure an item is selected
            {
                TollModel.InterchangeName = cb_InterChange.SelectedItem!.ToString()!;
            }

        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            TollModel.VehicleNumber = textBox1.Text;
        }
        private void dtPicker_ValueChanged(object sender, EventArgs e)
        {
            if (isManuallyModified)
            {
                setModelDate(dtPicker.Value);
            }
        }
        private DateTime _previousValue;
        private void DtPicker_Leave(object sender, EventArgs e)
        {
            if(_previousValue == dtPicker.Value)
            {
                isManuallyModified = false;
            }
        }

        private void DtPicker_Enter(object sender, EventArgs e)
        {
            isManuallyModified = true;
            _previousValue = dtPicker.Value;
        }
        private void setModelDate(DateTime value)
        {
            
             TollModel.Date = value;
            
        }
        public TollEntryForm()
        {
            InitializeComponent();
            TollModel = new TollModel();
            IEnumerable<string> InterchangeList = GetInterchangeList();
            cb_InterChange.DataSource = new BindingSource(InterchangeList, null);
            InitializeTimer();

        }
        public void ResetControls()
        {
            textBox1.Text = string.Empty;
            isManuallyModified = false;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            TollButtonClicked?.Invoke(this, e);
        }
    }
}
