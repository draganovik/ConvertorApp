using ConvertorApp.Convertors;
using ConvertorApp.Interfaces;
using NUnit.Framework;

namespace ConvertorAppTest.Convertors
{
    [TestFixture]
    public class MassConverterTest
    {
        #region Global objects
        MassConverter massConverter;
        #endregion

        [SetUp]
        public void SetUp()
        {
            massConverter = new MassConverter();
        }

        [Test]
        public void Convert_InputOKSuccess()
        {
            double expected = 4.536;
            double tested = massConverter.Convert(10);
            Assert.AreEqual(expected, tested);
        }

        [Test]
        public void Convert_Array_InputOKSuccess()
        {
            double expected = 5.897;
            double tested = ((IMultipleConverter)massConverter).ConvertArray("1, 2, 4, 6");
            Assert.AreEqual(expected, tested);
        }
    }
}
