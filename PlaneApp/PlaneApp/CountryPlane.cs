using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PlaneApp
{
    public class CountryPlane : Plane
    {
        public string Country { get; set; }

        public CountryPlane(string brand, int engineCount, int altitude, string country)
            : base(brand, engineCount, altitude)
        {
            Country = country;
        }

        public override double CalculateQuality()
        {
            double quality = base.CalculateQuality();

            if (Country == "Россия")
            {
                quality += 1;
            }
            else if (Country == "Франция")
            {
                quality += 0.5;
            }

            return quality;
        }

        public override string ToString()
        {
            return $"Самолет страны {Country}, марки {Brand} с {EngineCount} двигателями, высота полёта - {Altitude} метров";
        }
    }
}
