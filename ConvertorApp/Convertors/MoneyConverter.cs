using ConvertorApp.Interfaces;
using System;
using System.Text.RegularExpressions;

namespace ConvertorApp.Convertors
{
    public class MoneyConverter : IMultipleConverter
    {
        public double Convert(double imperial)
        {
            return Math.Round(imperial * 117.50);
        }

        public double CustomConvert(string value)
        {
            try
            {
                string[] temp = Regex.Split(value, @"\s+");
                string[] temp1 = Regex.Split(temp[0], @"\d+");
                string[] temp2 = Regex.Split(temp[0], @"\D");

                string num = temp2[0];
                string curr1 = temp1[1];
                string curr2 = temp[2];

                if (curr1 == "€")
                {
                    if (curr2 == "$")
                        return Math.Round((Double.Parse(num) * 1.19), 3);
                    if (curr2 == "£")
                        return Math.Round((Double.Parse(num) * 0.86), 3);
                }
                else if (curr1 == "$")
                {
                    if (curr2 == "€")
                        return Math.Round((Double.Parse(num) * 0.84), 3);
                    if (curr2 == "£")
                        return Math.Round((Double.Parse(num) * 0.72), 3);
                }
                else if (curr1 == "£")
                {
                    if (curr2 == "€")
                        return Math.Round((Double.Parse(num) * 1.17), 3);
                    if (curr2 == "$")
                        return Math.Round((Double.Parse(num) * 1.39), 3);
                }
                return 0;
            }
            catch
            {
                throw;
            }
        }
    }
}
