using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneApp
{
    public class Plane
    {
        public string Brand { get; set; }
        public int EngineCount { get; set; }
        public int Altitude { get; set; }

        public Plane(string brand, int engineCount, int altitude)
        {
            Brand = brand;
            EngineCount = engineCount;
            Altitude = altitude;
        }

        public virtual double CalculateQuality()
        {
            return (double)EngineCount * Altitude / 1000;
        }

        public override string ToString()
        {
            return $"Самолет марки {Brand} с {EngineCount} двигателями, высота полёта - {Altitude} метров";
        }
    }
}
