using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_WeatherTemplate
{
    public class Day
    {

        public string date, currentTemp, currentTime, location, conditionValue, tempHigh, tempLow, tempUnit, windSpeed, windDirection, precipitation, visibility, humidity, hUnits;
        //public int conditionValue = Convert.ToInt32("number");

        public Day()
        {
            //conditionValue = 0;
            date = currentTemp = currentTime = location = conditionValue = tempHigh = tempLow = tempUnit = windSpeed = windDirection = precipitation = visibility = humidity = hUnits = "";
            //conditionValue = Convert.ToDouble(conditionValue);
        }
    }
}
