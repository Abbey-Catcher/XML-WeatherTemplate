using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

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
            
            //convert and round values
            int conditionValue = int.Parse(Form1.days[0].conditionValue);
            double tempCurrent = double.Parse(Form1.days[0].currentTemp);
            double currentTemp = Math.Round(tempCurrent);
            double tempMax = double.Parse(Form1.days[0].tempHigh);
            double maxTemp = Math.Round(tempMax);
            double tempMin = double.Parse(Form1.days[0].tempLow);
            double minTemp = Math.Round(tempMin);

            //Format sun times
            DateTime sunriseDateTime = DateTime.Parse(Form1.days[0].sunrise);
            //DateTimeKind sunriseDateTimeKind = DateTimeKind.Utc;
            string sunriseTime = sunriseDateTime.ToString("t");
            DateTime sunsetDateTime = DateTime.Parse(Form1.days[0].sunset);
            string sunsetTime = sunsetDateTime.ToString("t");

            //formatted date & last updated
            DateTime Date = DateTime.Parse(Form1.days[0].date);
            string dateFormatted = Date.ToString("D");
            DateTime LU = DateTime.Parse(Form1.days[0].lastUpdated);
            string LUFormatted = LU.ToString("g");

            //Display information
            date1.Text = dateFormatted;
            cityOutput.Text = Form1.days[0].city + ", " + Form1.days[0].country;
            sunriseLabel.Text = "Sunrise:" + sunriseTime;
            sunsetLabel.Text = "Sunset:" + sunsetTime;
            current.Text = "Currently: " + currentTemp + "°C";
            min.Text = minTemp + "°C";
            max.Text = maxTemp + "°C";

            //display Conditions
            if (conditionValue >= 200 && conditionValue <= 235)
            {
                conditionsBox.Image = Properties.Resources.ThunderstormsIcon;
                BackColor = Color.DarkSlateGray;
            }
            else if (conditionValue >= 300 && conditionValue <= 325)
            {
                conditionsBox.Image = Properties.Resources.drizzleIcon;
                BackColor = Color.DarkGray;
            }
            else if (conditionValue >= 500 && conditionValue <= 535)
            {
                conditionsBox.Image = Properties.Resources.RainIcon;
                BackColor = Color.DimGray;
            }
            else if (conditionValue >= 600 && conditionValue <= 630)
            {
                conditionsBox.Image = Properties.Resources.snowIcon;
                BackColor = Color.Gainsboro;
            }
            else if (conditionValue >= 700 && conditionValue <= 790)
            {
                conditionsBox.Image = Properties.Resources.foggyIcon;
                BackColor = Color.LightGray;
            }
            else if (conditionValue == 800)
            {
                conditionsBox.Image = Properties.Resources.sunnyIcon;
                BackColor = Color.DeepSkyBlue;
            }
            else if (conditionValue >= 801 && conditionValue <= 805)
            {
                conditionsBox.Image = Properties.Resources.cloudyIcon;
                BackColor = Color.SkyBlue;
            }

            //Last updated label
            lastUpdatedLabel.Text = "Last updated: " + LUFormatted;
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Size = new Size(800, 450);
            f.Controls.Add(fs);
            fs.Focus();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            SearchScreen ss = new SearchScreen();
            f.Size = new Size(500, 500);
            f.Controls.Add(ss);
            ss.Focus();
        }
    }
}
