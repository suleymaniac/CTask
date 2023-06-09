using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Circle
    {
        private readonly Point center;
        private readonly Circumference circumference;

        public Circle(Point center, Circumference circumference)
        {
            this.center = center;
            this.circumference = circumference;
        }

        public void PrintIsPointInsideCircleToConsole(Point point)
        {
            string pointLocationString;

            if (IsPointInsideCircle(point))
            {
                pointLocationString = "находится";
            }
            else
            {
                pointLocationString = "не находится";
            };

            Console.WriteLine($"Точка ({point.X}, {point.Y}) {pointLocationString} внутри круга радиуса {circumference.Radius} с центром в точке ({center.X}, {center.Y})");
        }

        public bool IsPointInsideCircle(Point point)
        {
            return (point.X - center.X) * (point.X - center.X) + (point.Y - center.Y) * (point.Y - center.Y) < circumference.Radius * circumference.Radius;
        }
        public void SetPosition(double x, double y)
        {
            this.center.SetPosition(x, y);
        }

        public void IncreaseRadius(double value)
        {
            circumference.IncreaseRadius(value);
        }

        public void DecreaseRadius(double value)
        {
            circumference.DecreaseRadius(value);
        }

        public void IncreaseLength(double value)
        {
            circumference.IncreaseLength(value);
        }

        public void DecreaseLength(double value)
        {
            circumference.DecreaseLength(value);
        }

        public double GetRadius()
        {
            return circumference.Radius;
        }

        public Point GetCenter()
        {
            return center;
        }
    }
}
