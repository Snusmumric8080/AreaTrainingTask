using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Figures
{
   public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(int Radius)
        {
            if (Radius < 0)
                throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным");
            this.Radius = Radius;
        }
        public override double AreaCalc()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
