using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using TourismForecastingApp.Core.Models;

namespace TourismForecastingApp.Core.Services
{
    public static class TourismDataLoader
    {
        public static List<TourismRecord> LoadFromJson(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"Файл не найден: {filePath}");

            string json = File.ReadAllText(filePath);
            var records = JsonConvert.DeserializeObject<List<TourismRecord>>(json);
            return records ?? new List<TourismRecord>();
        }
    }
}
