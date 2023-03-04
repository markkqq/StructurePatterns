using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface IWeatherObservable
    {
        public void AddObserver(WeatherObserver weatherObserver);
        public void RemoveObserver(WeatherObserver weatherObserver);
        public void WeatherChanged(WeatherData weatherData);
    }
}
