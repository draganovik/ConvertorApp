using ConvertorApp.Interfaces;
using System;

namespace ConvertorApp.Convertors
{
    public class LengthConverter : IMultipleConverter
    {

        public double Convert(double imperial)
        {
            return Math.Round(imperial / 3.2808, 3);
        }
    }
}
