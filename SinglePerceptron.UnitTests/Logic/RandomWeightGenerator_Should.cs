using NUnit.Framework;
using SinglePerceptron.Logic;

namespace SinglePerceptron.UnitTests.Logic
{
    [TestFixture]
    public class RandomWeightGenerator_Should
    {
        [Test]
        public void ReturnADoubleGreaterOrEqualToThanNegative0PointFive()
        {
            var sut = new RandomWeightGenerator();

            double result = sut.GetRandomDouble(-0.5, 0.5);

            Assert.IsTrue(result >= -0.5);
        }

        [Test]
        public void ReturnADoubleLessThanOrEqualToThanPositive0PointFive()
        {
            var sut = new RandomWeightGenerator();

            double result = sut.GetRandomDouble(-0.5, 0.5);

            Assert.IsTrue(result <= 0.5);
        }
    }
}
