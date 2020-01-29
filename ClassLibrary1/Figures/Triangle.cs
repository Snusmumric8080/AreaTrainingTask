using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Figures
{
    public class Triangle : Figure
    {
        
        public double Side_A { get; set; }
        public double Side_B { get; set; }
        public double Side_C { get; set; }

        public Triangle(double Side_A, double Side_B, double Side_C)
        {
            if ((Side_A < 0 || Side_A < 0 || Side_C < 0) ||
                    (Side_A + Side_B <= Side_C) || (Side_A + Side_C <= Side_B) || (Side_B + Side_C <= Side_A))
                throw new ArgumentOutOfRangeException("Треугольника с заданными сторонами не может существовать");

            this.Side_A = Side_A;
            this.Side_B = Side_B;
            this.Side_C = Side_C;
        }

        public override double AreaCalc()
        {
            double p = (Side_A + Side_B + Side_C) / 2; //полупериметр треугольника
            return Math.Sqrt(p * (p - Side_A) * (p - Side_B) * (p - Side_C));
        }

        public bool IsRightTriangle()
        {
            return (Math.Pow(Side_A, 2) == Math.Pow(Side_B, 2) + Math.Pow(Side_C, 2)) ||
                (Math.Pow(Side_B, 2) == Math.Pow(Side_A, 2) + Math.Pow(Side_C, 2)) ||
                (Math.Pow(Side_C, 2) == Math.Pow(Side_A, 2) + Math.Pow(Side_B, 2));
 
            
        }
    }
}
