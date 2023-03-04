using System;
using lab;
using Strategy;
using Decorator;
using Builder;
using Observer;
namespace StructurePatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Strategy

            /* SortingAlgorithm sortingAlgorithm = new();
             Library library = new();
             Menu menu = new(library);
             menu.ShowBooks();

             PagesCountBookComparer pagesCountBookComparer = new();
             TitleBookComparer bookComparer = new();
             menu.SortBooks(sortingAlgorithm, pagesCountBookComparer);
             menu.ShowBooks();
             menu.SortBooks(sortingAlgorithm, bookComparer);
             menu.ShowBooks();*/

            #endregion

            #region Decorator
            /*BeveragePriceCalculator beveragePriceCalculator = new();
            Beverage beverage = new() { Price = 50 };
            Chocolate chocolate = new(beveragePriceCalculator);
            Milk milk = new(chocolate);
            Syrup syrup = new(milk);
            Console.WriteLine(syrup.CalculatePrice(beverage)); */
            #endregion

            #region Лабораторная работа
            /* //Новость о спорте
             Note note = Generator.GenerateNote("спорт","что-то о спорте","кто-то победил");
             //Новость о политике
             Note note1 = Generator.GenerateNote("политика","что-то о политике","кого-то избрали");
             //Новость о культуре
             Note note2 = Generator.GenerateNote("культура", "что-то о культуре", "культура");

             //Декорирую все в один формат
             OutputModule outputModule = new();
             Format1Decorator format1Decorator = new(outputModule);
             Console.WriteLine(format1Decorator.ShowNews(note));
             Console.WriteLine(format1Decorator.ShowNews(note1));
             Console.WriteLine(format1Decorator.ShowNews(note2));*/
            #endregion

            #region Строитель
            /*House houseFrame = House.Builder
                .AddFoundation(36)
                .AddWalls(4)
                .AddRoof("iron")
                .Build();
            House fullHouse = House.Builder
                .AddFoundation(50)
                .AddWalls(10)
                .AddRoof("wood")
                .AddDoor(2, "iron")
                .AddWindows(5)
                .Build();
            Console.WriteLine(@"Площадь дома - {0}, Стен - {1}, Материал крыши - {2}",houseFrame.Foundation.Square
                ,houseFrame.Wall.Count
                ,houseFrame.Roof.Material);
            Console.WriteLine(@"Площадь дома - {0}, Стен - {1}, Материал крыши - {2}, Окон - {3}, Дверей - {4}",
                fullHouse.Foundation.Square,
                fullHouse.Wall.Count,
                fullHouse.Roof.Material,
                fullHouse.Window.Count,
                fullHouse.Door.Count);*/
            #endregion

            #region Наблюдатель

            WeatherSensor centerSensor = new();
            NovosibirskWeatherObserver novosibirskWeatherObserver = new();
            NovokuznetskWeatherObserver novokuznetskWeatherObserver = new();

            centerSensor.AddObserver(novokuznetskWeatherObserver);
            centerSensor.AddObserver(novosibirskWeatherObserver);
            centerSensor.WeatherChanged(WeatherData.Builder.SetTemperature(20).SetHumidity(0.5).SetWindSpeed(5).Build());

            Console.WriteLine(novokuznetskWeatherObserver.Forecast);
            Console.WriteLine("------------------------------");
            Console.WriteLine(novosibirskWeatherObserver.Forecast);
            #endregion
        }

    }
}
