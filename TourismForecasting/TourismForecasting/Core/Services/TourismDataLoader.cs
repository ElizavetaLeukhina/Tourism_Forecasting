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
            string json = File.ReadAllText(filePath);
            var records = JsonConvert.DeserializeObject<List<TourismRecord>>(json);
            return records ?? new List<TourismRecord>();
        }
    }
}
