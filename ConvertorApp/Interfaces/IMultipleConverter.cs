using System;

namespace ConvertorApp.Interfaces
{
    public interface IMultipleConverter : IConverter
    {

        public double ConvertArray(string array)
        {
            string[] values = array.Split(',');

            double number = 0;
            for (int i = 0; i < values.Length; i++)
            {
                number += Double.Parse(values[i]);
            }

            return Convert(number);
        }
    }
}
