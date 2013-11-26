using SinglePerceptron.Logic.Interfaces;
using System;

namespace SinglePerceptron.Logic
{
    public class RandomWeightGenerator : IRandomWeightGenerator
    {
        public double GetRandomDouble(double min, double max)
        {
            var random = new Random();
            
            double value = Math.Round(random.NextDouble(), 1) * (max - min) + min;
            
            return value;
        }
    }
}
