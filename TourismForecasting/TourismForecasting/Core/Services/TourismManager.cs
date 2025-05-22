using System;
using System.Collections.Generic;
using System.Linq;
using TourismForecastingApp.Core.Models;

namespace TourismForecastingApp.Core.Services
{
    //Управляет туристическими данными: загрузка, фильтрация, анализ, прогнозирование.
    public static class TourismManager
    {
        private static List<TourismRecord> _records = new();

        // Инициализирует данные из JSON-файла.
        public static void Initialize(string filePath)
        {
            _records = TourismDataLoader.LoadFromJson(filePath);
        }

        // Возвращает все записи.
        public static List<TourismRecord> GetAllRecords()
        {
            return _records;
        }

        // Получает список уникальных стран.
        public static List<string> GetAvailableCountries()
        {
            return _records
                .Select(r => r.Country)
                .Distinct()
                .OrderBy(c => c)
                .ToList();
        }

        // Получает записи по заданной стране, отсортированные по году.
        public static List<TourismRecord> GetRecordsByCountry(string country)
        {
            return _records
                .Where(r => r.Country == country)
                .OrderBy(r => r.Year)
                .ToList();
        }

        // Возвращает страну с наибольшим числом туристов и количество туристов.
        public static (string Country, int TotalTourists) GetCountryWithMaxTourists()
        {
            return _records
                .GroupBy(r => r.Country)
                .Select(g => new { Country = g.Key, Total = g.Sum(r => r.Tourists) })
                .OrderByDescending(g => g.Total)
                .Select(g => (g.Country, g.Total))
                .First();
        }

        // Возвращает страну с наименьшим числом туристов и количество туристов.
        public static (string Country, int TotalTourists) GetCountryWithMinTourists()
        {
            return _records
                .GroupBy(r => r.Country)
                .Select(g => new { Country = g.Key, Total = g.Sum(r => r.Tourists) })
                .OrderBy(g => g.Total)
                .Select(g => (g.Country, g.Total))
                .First();
        }


        // Выполняет прогнозирование методом скользящей средней на N лет.
        public static List<TourismRecord> ForecastByMovingAverage(string country, int yearsToForecast, int window = 3)
        {
            var historical = GetRecordsByCountry(country);
            var forecast = new List<TourismRecord>();

            for (int i = 0; i < yearsToForecast; i++)
            {
                var lastYears = historical
                    .Skip(Math.Max(0, historical.Count - window))
                    .Take(window)
                    .ToList();

                int avg = (int)Math.Round(lastYears.Average(r => r.Tourists));
                int nextYear = historical.Last().Year + 1;

                var newRecord = new TourismRecord
                {
                    Country = country,
                    Year = nextYear,
                    Tourists = avg
                };

                historical.Add(newRecord);
                forecast.Add(newRecord);
            }

            return forecast;
        }
    }
}
