namespace SinglePerceptron.Presentation
{
    public static class Mother
    {
        public static double[,] GetInitialisedTrainingSet()
        {
            var trainingSet = new double[8, 8];

            trainingSet[0, 1] = 1;
            trainingSet[0, 2] = 1;
            trainingSet[0, 3] = 1;

            trainingSet[1, 1] = 0;
            trainingSet[1, 2] = 1;
            trainingSet[1, 3] = 1;

            trainingSet[2, 1] = 1;
            trainingSet[2, 2] = 0;
            trainingSet[2, 3] = 1;

            trainingSet[3, 1] = 0;
            trainingSet[3, 2] = 0;
            trainingSet[3, 3] = 1;

            trainingSet[4, 1] = 1;
            trainingSet[4, 2] = 1;
            trainingSet[4, 3] = 0;

            trainingSet[5, 1] = 0;
            trainingSet[5, 2] = 1;
            trainingSet[5, 3] = 0;

            trainingSet[6, 1] = 1;
            trainingSet[6, 2] = 0;
            trainingSet[6, 3] = 0;

            trainingSet[7, 1] = 0;
            trainingSet[7, 2] = 0;
            trainingSet[7, 3] = 0;

            return trainingSet;
        }

        public static double[,] GetDesiredOutputs()
        {
            var desiredOutputs = new double[8, 8];

            desiredOutputs[0, 1] = 1;
            desiredOutputs[0, 2] = 1;
            desiredOutputs[0, 3] = 0;

            desiredOutputs[1, 1] = 0;
            desiredOutputs[1, 2] = 1;
            desiredOutputs[1, 3] = 0;

            desiredOutputs[2, 1] = 1;
            desiredOutputs[2, 2] = 0;
            desiredOutputs[2, 3] = 1;

            desiredOutputs[3, 1] = 0;
            desiredOutputs[3, 2] = 0;
            desiredOutputs[3, 3] = 1;

            desiredOutputs[4, 1] = 1;
            desiredOutputs[4, 2] = 1;
            desiredOutputs[4, 3] = 0;

            desiredOutputs[5, 1] = 0;
            desiredOutputs[5, 2] = 1;
            desiredOutputs[5, 3] = 0;

            desiredOutputs[6, 1] = 1;
            desiredOutputs[6, 2] = 0;
            desiredOutputs[6, 3] = 1;

            desiredOutputs[7, 1] = 0;
            desiredOutputs[7, 2] = 0;
            desiredOutputs[7, 3] = 1;

            return desiredOutputs;
        }
    }
}
