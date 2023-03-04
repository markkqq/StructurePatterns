using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class NovokuznetskWeatherObserver : WeatherObserver
    {
        private WeatherData _weatherData;
        const double WIND_COEFFICIENT = 1;
        const double HUMIDITY_COEFFICIENT = 1.1;
        public override void Notify(WeatherData weatherData)
        {
            _weatherData = WeatherData.Builder
                .SetTemperature(weatherData.Temperature  - weatherData.WindSpeed*WIND_COEFFICIENT*weatherData.Humidity*HUMIDITY_COEFFICIENT)
                .SetHumidity(weatherData.Humidity)
                .SetWindSpeed(weatherData.WindSpeed)
                .Build();
        }
        public string Forecast 
        { 
            
            get
            { return String.Format(@"В Новокузнецке {0} градусов, скорость ветра {1} метров в секунду, влажность {2} процентов.",
            _weatherData.Temperature, 
            _weatherData.WindSpeed, 
            _weatherData.Humidity*100); 
            } 
        }
    }
}
