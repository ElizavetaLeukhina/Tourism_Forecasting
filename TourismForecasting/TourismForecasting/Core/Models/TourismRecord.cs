using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismForecastingApp.Core.Models
{
    public class TourismRecord
    {
        public int Year { get; set; }
        public string Country { get; set; }
        public int Tourists { get; set; }
    }
}
