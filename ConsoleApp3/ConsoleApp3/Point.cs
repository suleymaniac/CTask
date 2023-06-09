using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Point
    {
        private double x;
        private double y;

        public double X
        {
            get { return x; }
        }
        public double Y
        { 
            get { return y; } 
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void SetPosition(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
