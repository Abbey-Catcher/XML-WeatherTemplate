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
            convertTo();

            //cityOutput.Text = Form1.days[0].location;
            date1.Text = Form1.days[0].date;
            //Form1.days[0].conditionValue =
            //int conditionValue = int.Parse(Form1.days[0].conditionValue);

            //if (Form1.days[0].conditionValue >= "200" && Form1.days[0].conditionValue >= "250") {
            //CurrentScreen.BackgroundImage = Properties.Resources.Rain3;
            //}

            ////OconditionsLabel.Text = Form1.days[0].condition;
            ////add pictures
            ////assign numbers to pictures (i.e. Sunny = 1, Cloudy = 2...)
            ////add to pictureBox
            ////if conditions = 1, display sun picture
            current.Text = Form1.days[0].currentTemp;
            min.Text = Form1.days[0].tempLow;
            max.Text = Form1.days[0].tempHigh;
        }

        private void convertTo()
        {
            for (int i = 0; i < Form1.days.Count; i++)
            {
                int conditionValue = int.Parse(Form1.days[i].conditionValue);
                int maxTemp = int.Parse(Form1.days[i].tempHigh);
                int minTemp = int.Parse(Form1.days[i].tempLow);
            }
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
