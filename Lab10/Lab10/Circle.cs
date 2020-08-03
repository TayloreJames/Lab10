using System;
namespace Lab10
{
    public class Circle
    {
        private double radius = 0;

        //public double Radius { get; set; }

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                this.radius = value;
            }
        }

        public Circle(double radius)
        {
            Radius = radius; 
        }

        private string FormatNumber(double unformattedNum)
        {
            return Math.Round(unformattedNum, 2).ToString();
        }

        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }

        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());   
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }
    }
}
