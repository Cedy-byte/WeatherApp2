using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class Weather : IComparable
    {
        // Variable declarations
        private string city;
        private DateTime date;
        private int minTemp;
        private int maxTemp;
        private int prec;
        private int hum;
        private int wind;

        public Weather()
        {

        }

        // Constructor
        public Weather(string city, DateTime date, int minTemp, int maxTemp, int prec, int hum, int wind)
        {
            this.city = city;
            this.date = date;
            this.minTemp = minTemp;
            this.maxTemp = maxTemp;
            this.prec = prec;
            this.hum = hum;
            this.wind = wind;
        }

        // Get and Set methods
        public string City { get => city; set => city = value; }
        public DateTime Date { get => date; set => date = value; }
        public int MinTemp { get => minTemp; set => minTemp = value; }
        public int MaxTemp { get => maxTemp; set => maxTemp = value; }
        public int Prec { get => prec; set => prec = value; }
        public int Hum { get => hum; set => hum = value; }
        public int Wind { get => wind; set => wind = value; }

        // Method used to filter through the weather object and sort weathers
        public int CompareTo(object obj)
        {
            return City.CompareTo(obj.ToString());
        }
        public override string ToString()
        {
            return City;
        }

    }

}
