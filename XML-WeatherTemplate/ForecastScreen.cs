using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XML_WeatherTemplate
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            convertTo();

            date1.Text = Form1.days[1].date;
            ////conditionsLabel.Text = Form1.days[1].condition;
            //Form1.days[1].conditionValue
            //if (Form1.days[].conditionValue >= "200")
            //{
            //    conditions1.Image = Properties.Resources.RainIcon;
            //}
            //Form1.days[1].tempHigh = Convert.ToInt32();
            max1.Text = Form1.days[1].tempHigh;
            min1.Text = Form1.days[1].tempLow;

            date2.Text = Form1.days[2].date;
            //conditionsLabel.Text = Form1.days[2].condition;
            max2.Text = Form1.days[2].tempHigh;
            min2.Text = Form1.days[2].tempLow;

            date3.Text = Form1.days[3].date;
            //conditionsLabel.Text = Form1.days[3].condition;
            max3.Text = Form1.days[3].tempHigh;
            min3.Text = Form1.days[3].tempLow;

            date4.Text = Form1.days[4].date;
            max4.Text = Form1.days[4].tempHigh;
            min4.Text = Form1.days[4].tempLow;

            date5.Text = Form1.days[5].date;
            max5.Text = Form1.days[5].tempHigh;
            min5.Text = Form1.days[5].tempLow;

            date6.Text = Form1.days[6].date;
            max6.Text = Form1.days[6].tempHigh;
            min6.Text = Form1.days[6].tempLow;
        }

        private void convertTo()
        {
            for (int i = 0; i < Form1.days.Count; i++)
            {
                int maxTemp = int.Parse(Form1.days[i].tempHigh);
                int minTemp = int.Parse(Form1.days[i].tempLow);
            }
        }

        private void todaysForecast_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Size = new Size(325, 475);
            f.Controls.Add(cs);
        }
    }
}
