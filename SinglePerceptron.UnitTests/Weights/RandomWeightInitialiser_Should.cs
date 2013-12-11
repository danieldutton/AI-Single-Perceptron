using Moq;
using NUnit.Framework;
using SinglePerceptron.Weights;
using SinglePerceptron.Weights.Interfaces;
using System.Linq;

namespace SinglePerceptron._UnitTests.Weights
{
    [TestFixture]
    public class RandomWeightInitialiser_Should
    {
        private Mock<IRandomWeightGenerator> _fakeWeightGenerator;

        private RandomWeightInitialiser _sut;
        
        [SetUp]
        public void Init()
        {
            _fakeWeightGenerator = new Mock<IRandomWeightGenerator>();
            _sut = new RandomWeightInitialiser(_fakeWeightGenerator.Object);
        }

        [Test]
        public void GetInitialisedRandomWeights_InitialiseFirstReturnArrayElement_ToThresholdValue()
        {
            double[] result = _sut.GetRandomWeights(2.0);

            Assert.AreEqual(2.0, result[0]);
        }

        [Test]
        public void GetInitialisedRandomWeights_CallGetRandomDouble_ThreeTimes()
        {
            _sut.GetRandomWeights(It.IsAny<double>());

            _fakeWeightGenerator.Verify(x => x.GetRandomDouble(It.IsAny<double>(), It.IsAny<double>()), Times.Exactly(3));
        }

        [Test]
        public void GetInitialisedRandomWeights_PassTheCorrectParameterOfNegative0Point5_ToGetRandomDouble()
        {
            _sut.GetRandomWeights(It.IsAny<double>());

            _fakeWeightGenerator.Verify(x => x.GetRandomDouble(It.Is<double>(y => y == -0.5), It.IsAny<double>()));
        }

        [Test]
        public void GetInitialisedRandomWeights_PassTheCorrectParameterOfPositive0Point5_ToGetRandomDouble()
        {
            _sut.GetRandomWeights(It.IsAny<double>());

            _fakeWeightGenerator.Verify(x => x.GetRandomDouble(It.IsAny<double>(), It.Is<double>(y => y == 0.5)));
        }

        [Test]
        public void GetInitialisedRandomWeights_EnsureNoArrayElementIsLessThan_Negative0Point5()
        {
            double[] result = _sut.GetRandomWeights(2.0);

            Assert.IsTrue(result.All(x => x >= -0.5));
        }

        [Test]
        public void GetInitialisedRandomWeights_ReturnsAnArrayContainingOnlyDoubles()
        {
            double[] result = _sut.GetRandomWeights(2.0);

            CollectionAssert.AllItemsAreInstancesOfType(result, typeof(double));
        }

        [TearDown]
        public void TearDown()
        {
            _fakeWeightGenerator = null;
            _sut = null;
        }
    }
}
