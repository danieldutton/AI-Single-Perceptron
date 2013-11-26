using NUnit.Framework;
using SinglePerceptron.Logic;

namespace SinglePerceptron.UnitTests.Logic
{
    [TestFixture]
    public class ThresholdGenerator_Should
    {
        [Test]
        public void GetThresholdValue_ReturnADoubleGreaterOrEqualToThanNegative0PointFive()
        {
            var sut = new ThresholdGenerator();

            double result = sut.GetThresholdValue(1.0);

            Assert.IsTrue(result >= -0.5);
        }

        [Test]
        public void GetThresholdValue_ReturnADoubleLessThanOrEqualToThanPositive0PointFive()
        {
            var sut = new ThresholdGenerator();

            double result = sut.GetThresholdValue(1.0);

            Assert.IsTrue(result <= 0.5);
        }
    }
}
