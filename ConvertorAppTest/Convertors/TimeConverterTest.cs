using ConvertorApp.Convertors;
using ConvertorApp.DataTypes;
using NUnit.Framework;

namespace ConvertorAppTest.Convertors
{
    [TestFixture]
    public class TimeConverterTest
    {
        #region Global objects
        TimeConverter timeConverter;
        #endregion

        [SetUp]
        public void SetUp()
        {
            timeConverter = new TimeConverter();
        }

        [Test]
        public void Convert_DayToHours_OKInputSuccess()
        {
            double expected = 240;
            double tested = timeConverter.Convert(10, TimeType.HOURS);
            Assert.AreEqual(expected, tested);
        }

        [Test]
        public void Convert_DayToMinutes_InputOKSuccess()
        {
            double expected = 14400;
            double tested = timeConverter.Convert(10, TimeType.MINUTES);
            Assert.AreEqual(expected, tested);
        }

        [Test]
        public void Convert_DayToSeconds_InputOKSuccess()
        {
            double expected = 864000;
            double tested = timeConverter.Convert(10, TimeType.SECONDS);
            Assert.AreEqual(expected, tested);
        }
    }
}
