using SinglePerceptron.Weights.Interfaces;

namespace SinglePerceptron.Weights
{
    public class RandomWeightInitialiser : IWeightInitialiser
     {
        private readonly IRandomWeightGenerator _randomWeightGenerator;

        public RandomWeightInitialiser(IRandomWeightGenerator randomWeightGenerator)
        {
            _randomWeightGenerator = randomWeightGenerator;
        }


        public double[] GetInitialisedRandomWeights(double thresholdValue)
        {
            var inputWeights = new double[4];

            const double minWeightRange = -0.5;
            const double maxWeightRange = 0.5;

            inputWeights[0] = thresholdValue;

            for (int i = 1; i < inputWeights.Length; i++)
            {
                double value = _randomWeightGenerator.GetRandomDouble(minWeightRange, maxWeightRange);
                inputWeights[i] = value;
            }

            return inputWeights;
        }
    }
}
