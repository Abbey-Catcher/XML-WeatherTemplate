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
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            int conditionValue = int.Parse(Form1.days[0].conditionValue);
            double tempCurrent = double.Parse(Form1.days[0].currentTemp);
            double currentTemp = Math.Round(tempCurrent);
            double tempMax = double.Parse(Form1.days[0].tempHigh);
            double maxTemp = Math.Round(tempMax);
            double tempMin = double.Parse(Form1.days[0].tempLow);
            double minTemp = Math.Round(tempMin);

            date1.Text = Form1.days[0].date;
            cityOutput.Text = Form1.days[0].city + Form1.days[0].country;
            //May have to format times
            sunriseLabel.Text = Form1.days[0].sunrise;
            sunsetLabel.Text = Form1.days[0].sunset;
            current.Text = currentTemp + "°C";
            min.Text = minTemp + "°C";
            max.Text = maxTemp + "°C";

            if (conditionValue >= 200 && conditionValue <= 235)
            {
                BackgroundImage = Properties.Resources.ThunderstormsIcon;
            }
            else if (conditionValue >= 300 && conditionValue <= 325)
            {
                BackgroundImage = Properties.Resources.drizzleIcon;
            }
            else if (conditionValue >= 500 && conditionValue <= 535)
            {
                BackgroundImage = Properties.Resources.RainIcon;
            }
            else if (conditionValue >= 600 && conditionValue <= 630)
            {
                BackgroundImage = Properties.Resources.snowIcon;
            }
            else if (conditionValue >= 700 && conditionValue <= 790)
            {
                BackgroundImage = Properties.Resources.foggyIcon;
            }
            else if (conditionValue == 800)
            {
                BackgroundImage = Properties.Resources.sunnyIcon;
            }
            else if (conditionValue >= 801 && conditionValue <= 805)
            {
                BackgroundImage = Properties.Resources.cloudyIcon;
            }

            //may have to find a way to properly format
            lastUpdatedLabel.Text = "Last updated" + Form1.days[0].lastUpdated;
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Size = new Size(800, 450);
            f.Controls.Add(fs);
        }
    }
}
