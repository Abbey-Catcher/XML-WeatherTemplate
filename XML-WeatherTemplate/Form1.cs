using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XML_WeatherTemplate
{
    public partial class Form1 : Form
    {
        //list to hold day objects
        public static List<Day> days = new List<Day>();

  
        string startSearch = "Stratford,CA";



        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();

            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            //CurrentScreen.days = days;
            this.Controls.Add(cs);
        }

        public static void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                //creates a day object
                Day d = new Day();

                //fill day object with required data
                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("day");

                reader.ReadToFollowing("symbol");
                d.conditionValue = reader.GetAttribute("number");

                reader.ReadToFollowing("temperature");
                d.tempLow = reader.GetAttribute("min");
                d.tempHigh = reader.GetAttribute("max");
                d.tempUnit = reader.GetAttribute("unit");

                //adds days to the list if not null
                if (d.date != null)
                {
                    days.Add(d);
                }
            }
            //foreach (Day day in days)
            //{
            //    int conditionValues = int.Parse(days.conditionValue)
            //}

            reader.Close();
        }

        public void ExtractCurrent()
        {
            string URL1 = "http://api.openweathermap.org/data/2.5/weather?q=";
            string URL2 = "&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0";
            //string search = SearchScreen.search1;
            string complete = URL1 + startSearch + URL2;
            
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create(complete);

            //TODO: find the city and current temperature and add to appropriate item in days list
            reader.ReadToFollowing("city");
            days[0].city = reader.GetAttribute("name");

            reader.ReadToFollowing("country");
            days[0].country = reader.ReadString();

            reader.ReadToFollowing("sun");
            days[0].sunrise = reader.GetAttribute("rise");
            days[0].sunset = reader.GetAttribute("set");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value"); //current temperature
            days[0].tempHigh = reader.GetAttribute("max");
            days[0].tempLow = reader.GetAttribute("min");

            reader.ReadToFollowing("feels_like");
            days[0].feelsLike = reader.GetAttribute("value");

            reader.ReadToFollowing("humidity");
            days[0].humidity = reader.GetAttribute("value");
            days[0].hUnits = reader.GetAttribute("unit");

            reader.ReadToFollowing("weather");
            days[0].conditionValue = reader.GetAttribute("number");


            reader.ReadToFollowing("lastupdate");
            days[0].lastUpdated = reader.GetAttribute("value");
        }
    }
}
