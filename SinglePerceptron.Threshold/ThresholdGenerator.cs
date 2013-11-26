using System;

namespace SinglePerceptron.Threshold
{
    public class ThresholdGenerator : IThresholdGenerator
    {
        public double GetThresholdValue(double tHoldValue)
        {
            const decimal minThreshold = -0.5m;
            const decimal maxThreshold = 0.5m;
            
            var random = new Random();
            
            var thresholdValue = (decimal)random.NextDouble();
            thresholdValue = thresholdValue * (maxThreshold - minThreshold) + minThreshold;

            return (double)thresholdValue;
        }
    }
}
