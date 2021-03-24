using ConvertorApp.Convertors;
using ConvertorApp.Interfaces;
using NUnit.Framework;

namespace ConvertorAppTest.Convertors
{
    [TestFixture]
    public class MoneyConverterTest
    {
        #region Global objects
        MoneyConverter moneyConverter;
        #endregion

        [SetUp]
        public void SetUp()
        {
            moneyConverter = new MoneyConverter();
        }

        [Test]
        public void Convert_InputOKSuccess()
        {
            double expected = 1175;
            double tested = moneyConverter.Convert(10);
            Assert.AreEqual(expected, tested);
        }

        [Test]
        public void ConvertArray_InputOKSuccess()
        {
            double expected = 1528;
            double tested = ((IMultipleConverter)moneyConverter).ConvertArray("1, 2, 6, 4");
            Assert.AreEqual(expected, tested);
        }

        [Test]
        public void Convert_EURToUSD_InputOKSuccess()
        {
            double expected = 11.9;
            double tested = moneyConverter.CustomConvert("10€ to $");
            Assert.AreEqual(expected, tested);
        }

        [Test]
        public void Convert_EURToBGP_InputOKSuccess()
        {
            double expected = 8.6;
            double tested = moneyConverter.CustomConvert("10€ to £");
            Assert.AreEqual(expected, tested);
        }

        [Test]
        public void Convert_USDToEUR_InputOKSuccess()
        {
            double expected = 8.4;
            double tested = moneyConverter.CustomConvert("10$ to €");
            Assert.AreEqual(expected, tested);
        }

        [Test]
        public void Convert_USDtoBGP_InputOKSuccess()
        {
            double expected = 7.2;
            double tested = moneyConverter.CustomConvert("10$ to £");
            Assert.AreEqual(expected, tested);
        }

        [Test]
        public void Convert_GBPtoEUR_InputOKSuccess()
        {
            double expected = 11.7;
            double tested = moneyConverter.CustomConvert("10£ to €");
            Assert.AreEqual(expected, tested);
        }

        [Test]
        public void Convert_GBPtoUSD_InputOKSuccess()
        {
            double expected = 13.9;
            double tested = moneyConverter.CustomConvert("10£ to $");
            Assert.AreEqual(expected, tested);
        }

    }
}
