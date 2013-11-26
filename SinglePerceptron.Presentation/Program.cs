using System;
using System.Windows.Forms;
using SinglePerceptron.Threshold;
using SinglePerceptron.Weights;
using SinglePerceptron.Weights.Interfaces;

namespace SinglePerceptron.Presentation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IWeightInitialiser weightInitialiser = new RandomWeightInitialiser(new RandomWeightGenerator());
            IThresholdGenerator thresholdGenerator = new ThresholdGenerator();
            Application.Run(new Form1(weightInitialiser, thresholdGenerator));
        }
    }
}
