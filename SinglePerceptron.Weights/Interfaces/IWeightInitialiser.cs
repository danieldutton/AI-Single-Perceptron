namespace SinglePerceptron.Weights.Interfaces
{
    public interface IWeightInitialiser
    {
        double[] GetInitialisedRandomWeights(double thresholdValue);
    }
}
