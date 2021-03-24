using ConvertorApp.Interfaces;
using System;

namespace ConvertorApp.Convertors
{
    public class MassConverter : IMultipleConverter
    {
        public double Convert(double imperial)
        {
            return Math.Round(imperial / 2.2046, 3);

        }
    }
}
