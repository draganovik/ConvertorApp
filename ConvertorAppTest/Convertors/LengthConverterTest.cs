using ConvertorApp.Convertors;
using ConvertorApp.Interfaces;
using NUnit.Framework;

namespace ConvertorAppTest.Convertors
{
    [TestFixture]
    public class LengthConverterTest
    {
        #region Global objects
        LengthConverter lengthConverter;
        #endregion

        [SetUp]
        public void SetUp()
        {
            lengthConverter = new LengthConverter();
        }

        [Test]
        public void Convert_InputOKSuccess()
        {
            double expected = 3.048;
            double tested = lengthConverter.Convert(10);
            Assert.AreEqual(expected, tested);
        }

        [Test]
        public void Convert_Array_InputOKSuccess()
        {
            double expected = 3.962;
            double tested = ((IMultipleConverter)lengthConverter).ConvertArray("1, 2, 6, 4");
            Assert.AreEqual(expected, tested);
        }
    }
}
