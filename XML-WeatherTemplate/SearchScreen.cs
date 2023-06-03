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
            //Search();
        }

        //private async Task Search()
        //{
        //    string query = searchBox.Text;
        //    string apiKey = "your_api_key";
        //    string url = $"https://dev.virtualearth.net/REST/v1/Locations?q={query}&key={apiKey}";

        //    using (HttpClient client = new HttpClient())
        //    {
        //        HttpResponseMessage response = await client.GetAsync(url);
        //        response.EnsureSuccessStatusCode();
        //        string responseBody = await response.Content.ReadAsStringAsync();
        //        // Parse response body to get search results
        //        // Display search results

        //        List<string> suggestions = new List<string>();
        //        searchBox.AutoCompleteCustomSource.AddRange(suggestions.ToArray());
        //    }
        //}

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


        //public static string search1 = "";

        public void goButton_Click(object sender, EventArgs e)
        {
            //search1 = searchBox.Text;

        }
    }
}
