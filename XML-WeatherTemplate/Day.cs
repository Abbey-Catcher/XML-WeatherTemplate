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

        public Day()
        {
            date = currentTemp = city = country = conditionValue = tempHigh = tempLow = tempUnit = feelsLike = sunrise = sunset = windSpeed = windDirection = precipitation = humidity = hUnits = lastUpdated = "";
        }
    }
}
