namespace SinglePerceptron.Weights.Interfaces
{
    public interface IWeightInitialiser
    {
        double[] GetRandomWeights(double thresholdValue);
    }
}
