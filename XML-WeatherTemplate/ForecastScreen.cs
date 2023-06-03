using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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
            //convertions
            int conditionValue1 = int.Parse(Form1.days[1].conditionValue);
            int conditionValue2 = int.Parse(Form1.days[2].conditionValue);
            int conditionValue3 = int.Parse(Form1.days[3].conditionValue);
            int conditionValue4 = int.Parse(Form1.days[4].conditionValue);
            int conditionValue5 = int.Parse(Form1.days[5].conditionValue);
            int conditionValue6 = int.Parse(Form1.days[6].conditionValue);

            DateTime Date1 = DateTime.Parse(Form1.days[1].date);
            string dateFormatted1 = Date1.ToString("D");
            DateTime Date2 = DateTime.Parse(Form1.days[2].date);
            string dateFormatted2 = Date2.ToString("D");
            DateTime Date3 = DateTime.Parse(Form1.days[3].date);
            string dateFormatted3 = Date3.ToString("D");
            DateTime Date4 = DateTime.Parse(Form1.days[4].date);
            string dateFormatted4 = Date4.ToString("D");
            DateTime Date5 = DateTime.Parse(Form1.days[5].date);
            string dateFormatted5 = Date5.ToString("D");
            DateTime Date6 = DateTime.Parse(Form1.days[6].date);
            string dateFormatted6 = Date6.ToString("D");


            double tMax1 = double.Parse(Form1.days[1].tempHigh);
            double maxT1 = Math.Round(tMax1);
            double tMin1 = double.Parse(Form1.days[1].tempLow);
            double minT1 = Math.Round(tMin1);

            double tMax2 = double.Parse(Form1.days[2].tempHigh);
            double maxT2 = Math.Round(tMax2);
            double tMin2 = double.Parse(Form1.days[2].tempLow);
            double minT2 = Math.Round(tMin2);

            double tMax3 = double.Parse(Form1.days[3].tempHigh);
            double maxT3 = Math.Round(tMax3);
            double tMin3 = double.Parse(Form1.days[3].tempLow);
            double minT3 = Math.Round(tMin3);

            double tMax4 = double.Parse(Form1.days[4].tempHigh);
            double maxT4 = Math.Round(tMax4);
            double tMin4 = double.Parse(Form1.days[4].tempLow);
            double minT4 = Math.Round(tMin4);

            double tMax5 = double.Parse(Form1.days[5].tempHigh);
            double maxT5 = Math.Round(tMax5);
            double tMin5 = double.Parse(Form1.days[5].tempLow);
            double minT5 = Math.Round(tMin5);

            double tMax6 = double.Parse(Form1.days[6].tempHigh);
            double maxT6 = Math.Round(tMax6);
            double tMin6 = double.Parse(Form1.days[6].tempLow);
            double minT6 = Math.Round(tMin6);

           

            //Day 1
            date1.Text = dateFormatted1;

            if (conditionValue1 >= 200 && conditionValue1 <= 250)
            {
                conditions1.Image = Properties.Resources.ThunderstormsIcon;
            }
            else if (conditionValue1 >= 300 && conditionValue1 <= 325)
            {
                conditions1.Image = Properties.Resources.drizzleIcon;
            }
            else if (conditionValue1 >= 500 && conditionValue1 <= 535)
            {
                conditions1.Image = Properties.Resources.RainIcon;
            }
            else if (conditionValue1 >= 600 && conditionValue1 <= 630)
            {
                conditions1.Image = Properties.Resources.snowIcon;
            }
            else if (conditionValue1 >= 700 && conditionValue1 <= 790)
            {
                conditions1.Image = Properties.Resources.foggyIcon;
            }
            else if (conditionValue1 == 800)
            {
                conditions1.Image = Properties.Resources.sunnyIcon;
            }
            else if (conditionValue1 >= 801 && conditionValue1 <= 805)
            {
                conditions1.Image = Properties.Resources.cloudyIcon;
            }
            
            max1.Text = maxT1 + "°C";
            min1.Text = minT1 + "°C";

            //Day 2
            date2.Text = dateFormatted2;

            if (conditionValue2 >= 200 && conditionValue2 <= 250)
            {
                conditions2.Image = Properties.Resources.ThunderstormsIcon;
            }
            else if (conditionValue2 >= 300 && conditionValue2 <= 325)
            {
                conditions2.Image = Properties.Resources.drizzleIcon;
            }
            else if (conditionValue2 >= 500 && conditionValue2 <= 535)
            {
                conditions2.Image = Properties.Resources.RainIcon;
            }
            else if (conditionValue2 >= 600 && conditionValue2 <= 630)
            {
                conditions2.Image = Properties.Resources.snowIcon;
            }
            else if (conditionValue2 >= 700 && conditionValue2 <= 790)
            {
                conditions2.Image = Properties.Resources.foggyIcon;
            }
            else if (conditionValue2 == 800)
            {
                conditions2.Image = Properties.Resources.sunnyIcon;
            }
            else if (conditionValue2 >= 801 && conditionValue2 <= 805)
            {
                conditions2.Image = Properties.Resources.cloudyIcon;
            }

            max2.Text = maxT2 + "°C";
            min2.Text = minT2 + "°C";

            //Day 3
            date3.Text = dateFormatted3;

            if (conditionValue3 >= 200 && conditionValue3 <= 250)
            {
                conditions3.Image = Properties.Resources.ThunderstormsIcon;
            }
            else if (conditionValue3 >= 300 && conditionValue3 <= 325)
            {
                conditions3.Image = Properties.Resources.drizzleIcon;
            }
            else if (conditionValue3 >= 500 && conditionValue3 <= 535)
            {
                conditions3.Image = Properties.Resources.RainIcon;
            }
            else if (conditionValue3 >= 600 && conditionValue3 <= 630)
            {
                conditions3.Image = Properties.Resources.snowIcon;
            }
            else if (conditionValue3 >= 700 && conditionValue3 <= 790)
            {
                conditions3.Image = Properties.Resources.foggyIcon;
            }
            else if (conditionValue3 == 800)
            {
                conditions3.Image = Properties.Resources.sunnyIcon;
            }
            else if (conditionValue3 >= 801 && conditionValue3 <= 805)
            {
                conditions3.Image = Properties.Resources.cloudyIcon;
            }

            max3.Text = maxT3 + "°C";
            min3.Text = minT3 + "°C";

            //Day 4
            date4.Text = dateFormatted4;

            if (conditionValue4 >= 200 && conditionValue4 <= 250)
            {
                conditions4.Image = Properties.Resources.ThunderstormsIcon;
            }
            else if (conditionValue4 >= 300 && conditionValue4 <= 325)
            {
                conditions4.Image = Properties.Resources.drizzleIcon;
            }
            else if (conditionValue4 >= 500 && conditionValue4 <= 535)
            {
                conditions4.Image = Properties.Resources.RainIcon;
            }
            else if (conditionValue4 >= 600 && conditionValue4 <= 630)
            {
                conditions4.Image = Properties.Resources.snowIcon;
            }
            else if (conditionValue4 >= 700 && conditionValue4 <= 790)
            {
                conditions4.Image = Properties.Resources.foggyIcon;
            }
            else if (conditionValue4 == 800)
            {
                conditions4.Image = Properties.Resources.sunnyIcon;
            }
            else if (conditionValue4 >= 801 && conditionValue4 <= 805)
            {
                conditions4.Image = Properties.Resources.cloudyIcon;
            }

            max4.Text = maxT4 + "°C";
            min4.Text = minT4 + "°C";

            //Day 5
            date5.Text = dateFormatted5;

            if (conditionValue5 >= 200 && conditionValue5 <= 250)
            {
                conditions5.Image = Properties.Resources.ThunderstormsIcon;
            }
            else if (conditionValue5 >= 300 && conditionValue5 <= 325)
            {
                conditions5.Image = Properties.Resources.drizzleIcon;
            }
            else if (conditionValue5 >= 500 && conditionValue5 <= 535)
            {
                conditions5.Image = Properties.Resources.RainIcon;
            }
            else if (conditionValue5 >= 600 && conditionValue5 <= 630)
            {
                conditions5.Image = Properties.Resources.snowIcon;
            }
            else if (conditionValue5 >= 700 && conditionValue5 <= 790)
            {
                conditions5.Image = Properties.Resources.foggyIcon;
            }
            else if (conditionValue5 == 800)
            {
                conditions5.Image = Properties.Resources.sunnyIcon;
            }
            else if (conditionValue5 >= 801 && conditionValue5 <= 805)
            {
                conditions5.Image = Properties.Resources.cloudyIcon;
            }

            max5.Text = maxT5 + "°C";
            min5.Text = minT5 + "°C";

            //Day 6
            date6.Text = dateFormatted6;

            if (conditionValue6 >= 200 && conditionValue6 <= 250)
            {
                conditions6.Image = Properties.Resources.ThunderstormsIcon;
            }
            else if (conditionValue6 >= 300 && conditionValue6 <= 325)
            {
                conditions6.Image = Properties.Resources.drizzleIcon;
            }
            else if (conditionValue6 >= 500 && conditionValue6 <= 535)
            {
                conditions6.Image = Properties.Resources.RainIcon;
            }
            else if (conditionValue6 >= 600 && conditionValue6 <= 630)
            {
                conditions6.Image = Properties.Resources.snowIcon;
            }
            else if (conditionValue6 >= 700 && conditionValue6 <= 790)
            {
                conditions6.Image = Properties.Resources.foggyIcon;
            }
            else if (conditionValue6 == 800)
            {
                conditions6.Image = Properties.Resources.sunnyIcon;
            }
            else if (conditionValue6 >= 801 && conditionValue6 <= 805)
            {
                conditions6.Image = Properties.Resources.cloudyIcon;
            }

            max6.Text = maxT6 + "°C";
            min6.Text = minT6 + "°C";
        }

        private void todaysForecast_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Size = new Size(325, 475);
            f.Controls.Add(cs);
            cs.Focus();
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
