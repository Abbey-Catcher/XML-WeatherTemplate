using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

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
            for (int i = 0; i < Form1.days.Count; i++)
            //foreach (Day day in days)
            {
                //List<int> intList = Form1.days.Select(Day => Day.conditionValue).Select(int.Parse).ToList();
                //Console.WriteLine(string.Join(", ", intList));
                int conditionValues = int.Parse(Form1.days[i].conditionValue);
                double tempMax = double.Parse(Form1.days[i].tempHigh);
                double tempMin = double.Parse(Form1.days[i].tempLow);
                double maxTemp = Math.Round(tempMax);
                double minTemp = Math.Round(tempMin);
                min1.Text = minTemp + "°C";
                max1.Text = maxTemp + "°C";
            }

            //double maxTemp = Math.Round(tempMax);
            //double minTemp = Math.Round(tempMin);
            date1.Text = Form1.days[1].date;
            //if (conditionValue >= 200 && conditionValue <= 250)
            //{
            //    BackgroundImage = Properties.Resources.Rain3;
            //}
            //min1.Text = minTemp + "°C";
            //max1.Text = maxTemp + "°C";

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
