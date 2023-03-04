using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class WeatherSensor : IWeatherObservable
    {
        List<WeatherObserver> observers = new();
        WeatherData _weatherData;
        public void AddObserver(WeatherObserver weatherObserver)
        {
            observers.Add(weatherObserver);
        }

        private void NotifyObservers()
        {
            foreach(var observer in observers)
            {
                observer.Notify(_weatherData);
            }
        }
        public void WeatherChanged(WeatherData weatherData)
        {
            _weatherData = weatherData;
            NotifyObservers();
        }
        public void RemoveObserver(WeatherObserver weatherObserver)
        {
            observers.Remove(weatherObserver);
        }
    }
}
