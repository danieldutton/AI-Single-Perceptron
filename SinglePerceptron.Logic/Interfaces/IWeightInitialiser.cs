namespace SinglePerceptron.Logic.Interfaces
{
    public interface IWeightInitialiser
    {
        double[] GetInitialisedRandomWeights(double thresholdValue);
    }
}
