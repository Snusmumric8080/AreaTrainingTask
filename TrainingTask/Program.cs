using System;
using ClassLibrary1.Figures;
using ClassLibrary1;


namespace TrainingTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Console.WriteLine(circle.AreaCalc());
  
            Console.ReadKey();
        }
    }
}
