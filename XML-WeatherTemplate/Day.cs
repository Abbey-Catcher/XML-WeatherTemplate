using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_WeatherTemplate
{
    public class Day
    {

        public string date, currentTemp, city, country, conditionValue, tempHigh, tempLow, tempUnit, sunrise, sunset, feelsLike, windSpeed, windDirection, precipitation, humidity, hUnits, lastUpdated;
        //public int conditionValue = Convert.ToInt32("number");

        public Day()
        {
            //conditionValue = 0;
            date = currentTemp = city = country = conditionValue = tempHigh = tempLow = tempUnit = feelsLike = sunrise = sunset = windSpeed = windDirection = precipitation = humidity = hUnits = lastUpdated = "";
            //conditionValue = Convert.ToDouble(conditionValue);
        }
    }
}
