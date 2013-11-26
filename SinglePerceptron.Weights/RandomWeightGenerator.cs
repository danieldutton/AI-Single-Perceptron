using SinglePerceptron.Weights.Interfaces;
using System;

namespace SinglePerceptron.Weights
{
    public class RandomWeightGenerator : IRandomWeightGenerator
    {
        public double GetRandomDouble(double min, double max)
        {
            if(min > max) throw new ArgumentException("min must be >= max");

            var random = new Random();
            
            double value = Math.Round(random.NextDouble(), 1) * (max - min) + min;
            
            return value;
        }
    }
}
