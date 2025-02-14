using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TollClassLibrary.ViewModels;

namespace TollApp
{
    public partial class TollAmount : UserControl
    {
        private RTOExit _rtoExit;
        public RTOExit RTOExit
        {
            get
            {
                return _rtoExit;
            }
            set
            {
                _rtoExit = value;
                tbBaseRate.Text = $"{Math.Round(_rtoExit.BaseRate)} PKR" ;
                tbDistanceCovered.Text = $"{_rtoExit.Distance.ToString()} KM";
                tbDistanceRate.Text = $"{Math.Round(_rtoExit.DistanceRate)} PKR";
                tbDiscount.Text = $"{Math.Round(_rtoExit.DiscountRate) * 100} %";
                tbSubTotal.Text = $"{Math.Round(_rtoExit.DistanceCost)} PKR";
                tbWeekEndCharges.Text = $"{Math.Round(_rtoExit.WeekendRate,2) * 100} %";
                tbTotal.Text = $"{Math.Round(_rtoExit.TotalCost, 2)} PKR";
            }
        }
        public TollAmount()
        {
            InitializeComponent();
        }
    }
}
