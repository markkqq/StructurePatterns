using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class WeatherData
    {
        public double Temperature { get; private set; }
        public double Humidity { get; private set; } = 0;
        public double WindSpeed { get; private set; } = 0;
        public static WeatherDataBuilder Builder => new();
        private WeatherData()
        {

        }
        public class WeatherDataBuilder
        {
            WeatherData weatherData;
            public WeatherDataBuilder()
            {
                weatherData = new WeatherData();
            }
            public FinalWeatherDataBuilder SetTemperature(double temperature)
            {
                weatherData.Temperature = temperature;
                return new FinalWeatherDataBuilder(weatherData);
            }
            
            public class FinalWeatherDataBuilder
            {
                WeatherData weatherData;
                public FinalWeatherDataBuilder(WeatherData weatherData)
                {
                    this.weatherData = weatherData;
                    
                }
                public FinalWeatherDataBuilder SetHumidity(double humidity)
                {
                    weatherData.Humidity = humidity;
                    return this;
                }
                public FinalWeatherDataBuilder SetWindSpeed(double windSpeed)
                {
                    weatherData.WindSpeed = windSpeed;
                    return this;
                }
                public WeatherData Build()
                {
                    return weatherData;
                }
            }
        }
    }
}
