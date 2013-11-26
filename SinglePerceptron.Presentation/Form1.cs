using System;
using System.Drawing;
using System.Windows.Forms;
using SinglePerceptron.Threshold;
using SinglePerceptron.Weights.Interfaces;

namespace SinglePerceptron.Presentation
{
    public partial class Form1 : Form
    {
        private readonly IWeightInitialiser _weightInitialiser;
        
        private readonly IThresholdGenerator _thresholdGenerator;

        private readonly double[,] _trainingSet;

        private readonly double[,] _desiredOutputs;

        private double[] _inputWeights;

        private int _epochs;

        private double _learningRate = 0.1;

        private double _error;

        private double _actualOutput;

        private double _ex;


        public Form1(IWeightInitialiser weightInitialiser, IThresholdGenerator thresholdGenerator)
        {
            _weightInitialiser = weightInitialiser;
            _thresholdGenerator = thresholdGenerator;

            _trainingSet = Mother.GetInitialisedTrainingSet();
            _desiredOutputs = Mother.GetDesiredOutputs();

            InitializeComponent();
            PopulateDesiredOutputGrid();
        }

        
        private void PopulateDesiredOutputGrid()
        {
            for (int i = 0; i < _desiredOutputs.Length / 8; i++)
            {
                _gridDesiredOutput.Rows.Add(_desiredOutputs[i, 1].ToString(), _desiredOutputs[i, 2].ToString(),
                                            _desiredOutputs[i, 3].ToString());
            }
            _gridDesiredOutput.CurrentCell.Selected = false;
        }

        private void ClearTrainingResultsGrid()
        {
            _gridTrainingResults.Rows.Clear();
        }

        private void SetRandomLearningRate()
        {
            var random = new Random();

            _learningRate = random.NextDouble();

            _nUpDownLearningRate.Value = (decimal)(_learningRate);
        }

        private void SetRandomThresholdRate()
        {
            double thresholdValue = _thresholdGenerator.GetThresholdValue((double)_nUpDownThreshold.Value);
            
            _nUpDownThreshold.Value = (decimal)thresholdValue;
        }

        private void RunAlgorithm_Click(object sender, EventArgs e)
        {
            RunAlgorithm();
        }

        private void RunAlgorithm()
        {
            RandomlyInitialiseWeights();
            ClearTrainingResultsGrid();
            _tabResults.SelectTab(weightsTabPage);

            _epochs = 0;

            int desiredOutput = (int)_nUpDownDesiredOutput.Value;

            var aOutput = new double[8];

            do
            {
                _error = 0;
                _epochs++;

                for (int i = 0; i <= 7; i++)
                {
                    _actualOutput = (_trainingSet[i, 1] * _inputWeights[1]) + (_trainingSet[i, 2] * _inputWeights[2]) +
                                                         (_trainingSet[i, 3] * _inputWeights[3]) + _inputWeights[0];

                    _actualOutput = _actualOutput > 0 ? 1 : 0;

                    aOutput[i] = _actualOutput;

                    _ex = _desiredOutputs[i, desiredOutput] - _actualOutput;
                    _error += _ex * _ex;

                    _inputWeights[0] = _inputWeights[0] + _learningRate * _ex;
                    _inputWeights[1] = _inputWeights[1] + _learningRate * _ex * _trainingSet[i, 1];
                    _inputWeights[2] = _inputWeights[2] + _learningRate * _ex * _trainingSet[i, 2];
                    _inputWeights[3] = _inputWeights[3] + _learningRate * _ex * _trainingSet[i, 3];

                    PopulateResultsGrid(i);
                }

            } while (_error > 0);

            epochsCountLbl.Text = _epochs.ToString();
            HighlightFinalWeights();
        }

        private void RandomlyInitialiseWeights()
        {
            _inputWeights = _weightInitialiser.GetInitialisedRandomWeights((double)_nUpDownThreshold.Value);
        }

        private void PopulateResultsGrid(int i)
        {
            _gridTrainingResults.Rows.Add(_epochs, _trainingSet[i, 1], _trainingSet[i, 2], _trainingSet[i, 3], 
                                          _inputWeights[1].ToString("N2"), _inputWeights[2].ToString("N2"), 
                                          _inputWeights[3].ToString("N2"), _error);
        }

        private void HighlightFinalWeights()
        {
            int num = _gridTrainingResults.Rows.Count - 1;
            
            _gridTrainingResults.Rows[num].DefaultCellStyle.BackColor = Color.CornflowerBlue;
            _gridTrainingResults.Rows[num].DefaultCellStyle.ForeColor = Color.White;

            finWeightsCountLbl.Text = "W1: " + _inputWeights[_inputWeights.Length - 3].ToString("N2") + ", " + "  W2: " + 
                                               _inputWeights[_inputWeights.Length - 2].ToString("N2") + ", " + "  W3: " + 
                                               _inputWeights[_inputWeights.Length - 1].ToString("N2");
        }
        
        private void ResetLearningValuesToDefault_Click(object sender, EventArgs e)
        {
            _nUpDownLearningRate.Value = 0.0M;
            _nUpDownThreshold.Value = 0.0M;
            _nUpDownDesiredOutput.Value = 1M;
            ClearTrainingResultsGrid();
            epochsCountLbl.Text = "0";
            finWeightsCountLbl.Text = string.Empty;
        }

        private void ApplyRandomLearningValues_Click(object sender, EventArgs e)
        {
            SetRandomLearningRate();
            System.Threading.Thread.Sleep(150);
            SetRandomThresholdRate();
        }

        private void DesiredOutputComboBoxValue_Changed(object sender, EventArgs e)
        {
            int num = (int)_nUpDownDesiredOutput.Value;

            for (int i = 0; i < _gridDesiredOutput.Columns.Count; i++)
            {
                _gridDesiredOutput.Columns[i].DefaultCellStyle.BackColor = Color.White;
                _gridDesiredOutput.Columns[i].DefaultCellStyle.ForeColor = Color.Black;
            }
            _gridDesiredOutput.Columns[num - 1].DefaultCellStyle.BackColor = Color.CornflowerBlue;
            _gridDesiredOutput.Columns[num - 1].DefaultCellStyle.ForeColor = Color.White;
        }

        private void ExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
