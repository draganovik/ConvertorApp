using ConvertorApp.DataTypes;
using ConvertorApp.Interfaces;

namespace ConvertorApp.Convertors
{
    public class TimeConverter : IConverter
    {
        public TimeType toTime;
        public TimeConverter() { }

        public TimeConverter(TimeType toTime)
        {
            this.toTime = toTime;
        }

        public double Convert(double imperial)
        {
            return Convert(imperial, toTime);
        }

        public double Convert(double imperial, TimeType toTime)
        {
            return toTime switch
            {
                TimeType.MINUTES => imperial * 24 * 60,
                TimeType.SECONDS => imperial * 24 * 60 * 60,
                _ => imperial * 24,
            };
        }
    }
}
