using NUnit.Framework;
using SinglePerceptron.Weights;
using System;

namespace SinglePerceptron.UnitTests.Weights
{
    [TestFixture]
    public class RandomWeightGenerator_Should
    {
        private RandomWeightGenerator _sut;

        [SetUp]
        public void Init()
        {
           _sut = new RandomWeightGenerator(); 
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void GetRandomDouble_ThrowAnArgumentExceptionImMinParameterIsGreaterThanMaxParameter()
        {
            _sut.GetRandomDouble(10.0, 5.0);
        }

        [Test]
        public void GetRandomDouble_ReturnADoubleGreaterOrEqualToThanNegative0PointFive()
        {
            double result = _sut.GetRandomDouble(-0.5, 0.5);

            Assert.IsTrue(result >= -0.5);
        }

        [Test]
        public void GetRandomDouble_ReturnADoubleLessThanOrEqualToThanPositive0PointFive()
        {
            double result = _sut.GetRandomDouble(-0.5, 0.5);

            Assert.IsTrue(result <= 0.5);
        }

        [TearDown]
        public void TearDown()
        {
            _sut = null;
        }
    }
}
