using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Collections;
using System.Xml;

namespace XML_WeatherTemplate
{
    public partial class SearchScreen : UserControl
    {
        public SearchScreen()
        {
            InitializeComponent();
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

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Size = new Size(800, 450);
            f.Controls.Add(fs);
            fs.Focus();
        }

        public void goButton_Click(object sender, EventArgs e)
        {
            //Current btn
            Form1.startSearch = searchBox.Text;

            Form1.ExtractForecast();
            Form1.ExtractCurrent();

            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Size = new Size(325, 475);
            f.Controls.Add(cs);
            cs.Focus();
        }
    }
}
