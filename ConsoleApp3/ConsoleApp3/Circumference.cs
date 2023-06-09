using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Circumference
    {
        private double radius;
        private double length;

        public double Radius
        {
            get => radius;
            set
            {
                radius = value;
                length = 2 * Math.PI * radius;
            }
        }

        public double Length
        {
            get => length;
            set
            {
                length = value;
                radius = length / (2 * Math.PI);
            }
        }

        public Circumference(double radius)
        {
            this.Radius = radius;
        }

        public void IncreaseRadius(double radius)
        {
            this.Radius += radius;
        }

        public void IncreaseLength(double length)
        {
            this.Length += length;
        }

        public void DecreaseRadius(double radius)
        {
            if (Radius - radius >= 0) { Radius -= radius; }
        }

        public void DecreaseLength(double length)
        {
            if (Length - length >= 0) { Length -= length; }
        }
    }
}
