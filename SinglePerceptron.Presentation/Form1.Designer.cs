namespace SinglePerceptron.Presentation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this._tabResults = new System.Windows.Forms.TabControl();
            this.tabPage = new System.Windows.Forms.TabPage();
            this._panelRun = new System.Windows.Forms.Panel();
            this._btnReset = new System.Windows.Forms.Button();
            this._btnRun = new System.Windows.Forms.Button();
            this._panelExit = new System.Windows.Forms.Panel();
            this._btnExit = new System.Windows.Forms.Button();
            this._gridDesiredOutput = new System.Windows.Forms.DataGridView();
            this.X1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._panelDesiredOutput = new System.Windows.Forms.Panel();
            this._nUpDownDesiredOutput = new System.Windows.Forms.NumericUpDown();
            this._lblDesiredOutput = new System.Windows.Forms.Label();
            this._panelLearningRate = new System.Windows.Forms.Panel();
            this._nUpDownLearningRate = new System.Windows.Forms.NumericUpDown();
            this._lblLearningRate = new System.Windows.Forms.Label();
            this._panelThreshold = new System.Windows.Forms.Panel();
            this._nUpDownThreshold = new System.Windows.Forms.NumericUpDown();
            this._lblThreshold = new System.Windows.Forms.Label();
            this._panelRandomise = new System.Windows.Forms.Panel();
            this._btnRandomise = new System.Windows.Forms.Button();
            this.genGraphLbl = new System.Windows.Forms.Label();
            this.weightsTabPage = new System.Windows.Forms.TabPage();
            this._panelTotalEpochs = new System.Windows.Forms.Panel();
            this.epochsCountLbl = new System.Windows.Forms.Label();
            this._lblTotalEpochs = new System.Windows.Forms.Label();
            this._panelFinalWeights = new System.Windows.Forms.Panel();
            this.finWeightsCountLbl = new System.Windows.Forms.Label();
            this._lblFinalWeights = new System.Windows.Forms.Label();
            this._gridTrainingResults = new System.Windows.Forms.DataGridView();
            this.Epoch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tabResults.SuspendLayout();
            this.tabPage.SuspendLayout();
            this._panelRun.SuspendLayout();
            this._panelExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridDesiredOutput)).BeginInit();
            this._panelDesiredOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nUpDownDesiredOutput)).BeginInit();
            this._panelLearningRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nUpDownLearningRate)).BeginInit();
            this._panelThreshold.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nUpDownThreshold)).BeginInit();
            this._panelRandomise.SuspendLayout();
            this.weightsTabPage.SuspendLayout();
            this._panelTotalEpochs.SuspendLayout();
            this._panelFinalWeights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridTrainingResults)).BeginInit();
            this.SuspendLayout();
            // 
            // _tabResults
            // 
            this._tabResults.Controls.Add(this.tabPage);
            this._tabResults.Controls.Add(this.weightsTabPage);
            this._tabResults.Location = new System.Drawing.Point(4, 4);
            this._tabResults.Name = "_tabResults";
            this._tabResults.SelectedIndex = 0;
            this._tabResults.Size = new System.Drawing.Size(395, 220);
            this._tabResults.TabIndex = 1;
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this._panelRun);
            this.tabPage.Controls.Add(this._panelExit);
            this.tabPage.Controls.Add(this._gridDesiredOutput);
            this.tabPage.Controls.Add(this._panelDesiredOutput);
            this.tabPage.Controls.Add(this._panelLearningRate);
            this.tabPage.Controls.Add(this._panelThreshold);
            this.tabPage.Controls.Add(this._panelRandomise);
            this.tabPage.Location = new System.Drawing.Point(4, 22);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(387, 194);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "Settings";
            this.tabPage.UseVisualStyleBackColor = true;
            // 
            // _panelRun
            // 
            this._panelRun.BackColor = System.Drawing.Color.Gainsboro;
            this._panelRun.Controls.Add(this._btnReset);
            this._panelRun.Controls.Add(this._btnRun);
            this._panelRun.Location = new System.Drawing.Point(6, 155);
            this._panelRun.Name = "_panelRun";
            this._panelRun.Size = new System.Drawing.Size(176, 33);
            this._panelRun.TabIndex = 21;
            // 
            // _btnReset
            // 
            this._btnReset.Location = new System.Drawing.Point(3, 5);
            this._btnReset.Name = "_btnReset";
            this._btnReset.Size = new System.Drawing.Size(52, 23);
            this._btnReset.TabIndex = 1;
            this._btnReset.Text = "Reset";
            this._btnReset.UseVisualStyleBackColor = true;
            this._btnReset.Click += new System.EventHandler(this.ResetLearningValuesToDefault_Click);
            // 
            // _btnRun
            // 
            this._btnRun.Location = new System.Drawing.Point(124, 5);
            this._btnRun.Name = "_btnRun";
            this._btnRun.Size = new System.Drawing.Size(46, 23);
            this._btnRun.TabIndex = 0;
            this._btnRun.Text = "Run";
            this._btnRun.UseVisualStyleBackColor = true;
            this._btnRun.Click += new System.EventHandler(this.RunAlgorithm_Click);
            // 
            // _panelExit
            // 
            this._panelExit.BackColor = System.Drawing.Color.Gainsboro;
            this._panelExit.Controls.Add(this._btnExit);
            this._panelExit.Location = new System.Drawing.Point(182, 155);
            this._panelExit.Name = "_panelExit";
            this._panelExit.Size = new System.Drawing.Size(199, 33);
            this._panelExit.TabIndex = 20;
            // 
            // _btnExit
            // 
            this._btnExit.Location = new System.Drawing.Point(153, 5);
            this._btnExit.Name = "_btnExit";
            this._btnExit.Size = new System.Drawing.Size(43, 23);
            this._btnExit.TabIndex = 2;
            this._btnExit.Text = "Exit";
            this._btnExit.UseVisualStyleBackColor = true;
            this._btnExit.Click += new System.EventHandler(this.ExitApplication_Click);
            // 
            // _gridDesiredOutput
            // 
            this._gridDesiredOutput.AllowUserToAddRows = false;
            this._gridDesiredOutput.AllowUserToDeleteRows = false;
            this._gridDesiredOutput.AllowUserToResizeColumns = false;
            this._gridDesiredOutput.AllowUserToResizeRows = false;
            this._gridDesiredOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._gridDesiredOutput.BackgroundColor = System.Drawing.Color.DarkGray;
            this._gridDesiredOutput.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._gridDesiredOutput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this._gridDesiredOutput.ColumnHeadersHeight = 17;
            this._gridDesiredOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X1,
            this.X2,
            this.X3});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._gridDesiredOutput.DefaultCellStyle = dataGridViewCellStyle9;
            this._gridDesiredOutput.EnableHeadersVisualStyles = false;
            this._gridDesiredOutput.Location = new System.Drawing.Point(188, 7);
            this._gridDesiredOutput.Name = "_gridDesiredOutput";
            this._gridDesiredOutput.ReadOnly = true;
            this._gridDesiredOutput.RowHeadersVisible = false;
            this._gridDesiredOutput.RowHeadersWidth = 20;
            this._gridDesiredOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._gridDesiredOutput.Size = new System.Drawing.Size(193, 142);
            this._gridDesiredOutput.TabIndex = 19;
            // 
            // X1
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            this.X1.DefaultCellStyle = dataGridViewCellStyle8;
            this.X1.HeaderText = "X1";
            this.X1.Name = "X1";
            this.X1.ReadOnly = true;
            this.X1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.X1.Width = 43;
            // 
            // X2
            // 
            this.X2.HeaderText = "X2";
            this.X2.Name = "X2";
            this.X2.ReadOnly = true;
            this.X2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.X2.Width = 43;
            // 
            // X3
            // 
            this.X3.HeaderText = "X3";
            this.X3.Name = "X3";
            this.X3.ReadOnly = true;
            this.X3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.X3.Width = 43;
            // 
            // _panelDesiredOutput
            // 
            this._panelDesiredOutput.BackColor = System.Drawing.Color.Lavender;
            this._panelDesiredOutput.Controls.Add(this._nUpDownDesiredOutput);
            this._panelDesiredOutput.Controls.Add(this._lblDesiredOutput);
            this._panelDesiredOutput.Location = new System.Drawing.Point(6, 7);
            this._panelDesiredOutput.Name = "_panelDesiredOutput";
            this._panelDesiredOutput.Size = new System.Drawing.Size(176, 31);
            this._panelDesiredOutput.TabIndex = 18;
            // 
            // _nUpDownDesiredOutput
            // 
            this._nUpDownDesiredOutput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._nUpDownDesiredOutput.Location = new System.Drawing.Point(124, 5);
            this._nUpDownDesiredOutput.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this._nUpDownDesiredOutput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nUpDownDesiredOutput.Name = "_nUpDownDesiredOutput";
            this._nUpDownDesiredOutput.Size = new System.Drawing.Size(46, 20);
            this._nUpDownDesiredOutput.TabIndex = 4;
            this._nUpDownDesiredOutput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nUpDownDesiredOutput.ValueChanged += new System.EventHandler(this.DesiredOutputComboBoxValue_Changed);
            // 
            // _lblDesiredOutput
            // 
            this._lblDesiredOutput.AutoSize = true;
            this._lblDesiredOutput.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblDesiredOutput.ForeColor = System.Drawing.Color.SteelBlue;
            this._lblDesiredOutput.Location = new System.Drawing.Point(12, 8);
            this._lblDesiredOutput.Name = "_lblDesiredOutput";
            this._lblDesiredOutput.Size = new System.Drawing.Size(80, 15);
            this._lblDesiredOutput.TabIndex = 3;
            this._lblDesiredOutput.Text = "Desired Output";
            // 
            // _panelLearningRate
            // 
            this._panelLearningRate.BackColor = System.Drawing.Color.Lavender;
            this._panelLearningRate.Controls.Add(this._nUpDownLearningRate);
            this._panelLearningRate.Controls.Add(this._lblLearningRate);
            this._panelLearningRate.Location = new System.Drawing.Point(6, 44);
            this._panelLearningRate.Name = "_panelLearningRate";
            this._panelLearningRate.Size = new System.Drawing.Size(176, 31);
            this._panelLearningRate.TabIndex = 15;
            // 
            // _nUpDownLearningRate
            // 
            this._nUpDownLearningRate.DecimalPlaces = 1;
            this._nUpDownLearningRate.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._nUpDownLearningRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this._nUpDownLearningRate.Location = new System.Drawing.Point(124, 5);
            this._nUpDownLearningRate.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this._nUpDownLearningRate.Name = "_nUpDownLearningRate";
            this._nUpDownLearningRate.Size = new System.Drawing.Size(46, 20);
            this._nUpDownLearningRate.TabIndex = 4;
            // 
            // _lblLearningRate
            // 
            this._lblLearningRate.AutoSize = true;
            this._lblLearningRate.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblLearningRate.ForeColor = System.Drawing.Color.SteelBlue;
            this._lblLearningRate.Location = new System.Drawing.Point(12, 8);
            this._lblLearningRate.Name = "_lblLearningRate";
            this._lblLearningRate.Size = new System.Drawing.Size(75, 15);
            this._lblLearningRate.TabIndex = 3;
            this._lblLearningRate.Text = "Learning Rate";
            // 
            // _panelThreshold
            // 
            this._panelThreshold.BackColor = System.Drawing.Color.Lavender;
            this._panelThreshold.Controls.Add(this._nUpDownThreshold);
            this._panelThreshold.Controls.Add(this._lblThreshold);
            this._panelThreshold.Location = new System.Drawing.Point(6, 81);
            this._panelThreshold.Name = "_panelThreshold";
            this._panelThreshold.Size = new System.Drawing.Size(176, 31);
            this._panelThreshold.TabIndex = 16;
            // 
            // _nUpDownThreshold
            // 
            this._nUpDownThreshold.DecimalPlaces = 1;
            this._nUpDownThreshold.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._nUpDownThreshold.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this._nUpDownThreshold.Location = new System.Drawing.Point(124, 5);
            this._nUpDownThreshold.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this._nUpDownThreshold.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147418112});
            this._nUpDownThreshold.Name = "_nUpDownThreshold";
            this._nUpDownThreshold.Size = new System.Drawing.Size(46, 20);
            this._nUpDownThreshold.TabIndex = 4;
            // 
            // _lblThreshold
            // 
            this._lblThreshold.AutoSize = true;
            this._lblThreshold.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblThreshold.ForeColor = System.Drawing.Color.SteelBlue;
            this._lblThreshold.Location = new System.Drawing.Point(12, 8);
            this._lblThreshold.Name = "_lblThreshold";
            this._lblThreshold.Size = new System.Drawing.Size(54, 15);
            this._lblThreshold.TabIndex = 3;
            this._lblThreshold.Text = "Threshold";
            // 
            // _panelRandomise
            // 
            this._panelRandomise.BackColor = System.Drawing.Color.Lavender;
            this._panelRandomise.Controls.Add(this._btnRandomise);
            this._panelRandomise.Controls.Add(this.genGraphLbl);
            this._panelRandomise.Location = new System.Drawing.Point(6, 118);
            this._panelRandomise.Name = "_panelRandomise";
            this._panelRandomise.Size = new System.Drawing.Size(176, 31);
            this._panelRandomise.TabIndex = 17;
            // 
            // _btnRandomise
            // 
            this._btnRandomise.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnRandomise.ForeColor = System.Drawing.Color.Blue;
            this._btnRandomise.Location = new System.Drawing.Point(124, 4);
            this._btnRandomise.Name = "_btnRandomise";
            this._btnRandomise.Size = new System.Drawing.Size(46, 23);
            this._btnRandomise.TabIndex = 4;
            this._btnRandomise.Text = "R";
            this._btnRandomise.UseVisualStyleBackColor = true;
            this._btnRandomise.Click += new System.EventHandler(this.ApplyRandomLearningValues_Click);
            // 
            // genGraphLbl
            // 
            this.genGraphLbl.AutoSize = true;
            this.genGraphLbl.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genGraphLbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.genGraphLbl.Location = new System.Drawing.Point(12, 8);
            this.genGraphLbl.Name = "genGraphLbl";
            this.genGraphLbl.Size = new System.Drawing.Size(61, 15);
            this.genGraphLbl.TabIndex = 3;
            this.genGraphLbl.Text = "Randomise";
            // 
            // weightsTabPage
            // 
            this.weightsTabPage.Controls.Add(this._panelTotalEpochs);
            this.weightsTabPage.Controls.Add(this._panelFinalWeights);
            this.weightsTabPage.Controls.Add(this._gridTrainingResults);
            this.weightsTabPage.Location = new System.Drawing.Point(4, 22);
            this.weightsTabPage.Name = "weightsTabPage";
            this.weightsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.weightsTabPage.Size = new System.Drawing.Size(387, 194);
            this.weightsTabPage.TabIndex = 1;
            this.weightsTabPage.Text = "Results";
            this.weightsTabPage.UseVisualStyleBackColor = true;
            // 
            // _panelTotalEpochs
            // 
            this._panelTotalEpochs.BackColor = System.Drawing.Color.Gainsboro;
            this._panelTotalEpochs.Controls.Add(this.epochsCountLbl);
            this._panelTotalEpochs.Controls.Add(this._lblTotalEpochs);
            this._panelTotalEpochs.Location = new System.Drawing.Point(7, 154);
            this._panelTotalEpochs.Name = "_panelTotalEpochs";
            this._panelTotalEpochs.Size = new System.Drawing.Size(373, 33);
            this._panelTotalEpochs.TabIndex = 9;
            // 
            // epochsCountLbl
            // 
            this.epochsCountLbl.AutoSize = true;
            this.epochsCountLbl.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.epochsCountLbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.epochsCountLbl.Location = new System.Drawing.Point(83, 8);
            this.epochsCountLbl.Name = "epochsCountLbl";
            this.epochsCountLbl.Size = new System.Drawing.Size(13, 15);
            this.epochsCountLbl.TabIndex = 1;
            this.epochsCountLbl.Text = "0";
            // 
            // _lblTotalEpochs
            // 
            this._lblTotalEpochs.AutoSize = true;
            this._lblTotalEpochs.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTotalEpochs.ForeColor = System.Drawing.Color.SteelBlue;
            this._lblTotalEpochs.Location = new System.Drawing.Point(3, 8);
            this._lblTotalEpochs.Name = "_lblTotalEpochs";
            this._lblTotalEpochs.Size = new System.Drawing.Size(71, 15);
            this._lblTotalEpochs.TabIndex = 0;
            this._lblTotalEpochs.Text = "Total Epochs:";
            // 
            // _panelFinalWeights
            // 
            this._panelFinalWeights.BackColor = System.Drawing.Color.Lavender;
            this._panelFinalWeights.Controls.Add(this.finWeightsCountLbl);
            this._panelFinalWeights.Controls.Add(this._lblFinalWeights);
            this._panelFinalWeights.Location = new System.Drawing.Point(7, 129);
            this._panelFinalWeights.Name = "_panelFinalWeights";
            this._panelFinalWeights.Size = new System.Drawing.Size(373, 22);
            this._panelFinalWeights.TabIndex = 11;
            // 
            // finWeightsCountLbl
            // 
            this.finWeightsCountLbl.AutoSize = true;
            this.finWeightsCountLbl.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finWeightsCountLbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.finWeightsCountLbl.Location = new System.Drawing.Point(83, 4);
            this.finWeightsCountLbl.Name = "finWeightsCountLbl";
            this.finWeightsCountLbl.Size = new System.Drawing.Size(0, 15);
            this.finWeightsCountLbl.TabIndex = 1;
            // 
            // _lblFinalWeights
            // 
            this._lblFinalWeights.AutoSize = true;
            this._lblFinalWeights.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblFinalWeights.ForeColor = System.Drawing.Color.SteelBlue;
            this._lblFinalWeights.Location = new System.Drawing.Point(3, 4);
            this._lblFinalWeights.Name = "_lblFinalWeights";
            this._lblFinalWeights.Size = new System.Drawing.Size(76, 15);
            this._lblFinalWeights.TabIndex = 0;
            this._lblFinalWeights.Text = "Final Weights:";
            // 
            // _gridTrainingResults
            // 
            this._gridTrainingResults.AllowUserToAddRows = false;
            this._gridTrainingResults.AllowUserToDeleteRows = false;
            this._gridTrainingResults.AllowUserToResizeRows = false;
            this._gridTrainingResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this._gridTrainingResults.BackgroundColor = System.Drawing.Color.White;
            this._gridTrainingResults.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this._gridTrainingResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._gridTrainingResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this._gridTrainingResults.ColumnHeadersHeight = 17;
            this._gridTrainingResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._gridTrainingResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Epoch,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.W1,
            this.W2,
            this.W3,
            this.errors});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._gridTrainingResults.DefaultCellStyle = dataGridViewCellStyle11;
            this._gridTrainingResults.EnableHeadersVisualStyles = false;
            this._gridTrainingResults.Location = new System.Drawing.Point(7, 7);
            this._gridTrainingResults.Name = "_gridTrainingResults";
            this._gridTrainingResults.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._gridTrainingResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this._gridTrainingResults.RowHeadersVisible = false;
            this._gridTrainingResults.RowHeadersWidth = 20;
            this._gridTrainingResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._gridTrainingResults.Size = new System.Drawing.Size(373, 118);
            this._gridTrainingResults.TabIndex = 10;
            // 
            // Epoch
            // 
            this.Epoch.HeaderText = "epoch";
            this.Epoch.Name = "Epoch";
            this.Epoch.ReadOnly = true;
            this.Epoch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Epoch.Width = 53;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "X1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "X2";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 43;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "X3";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 43;
            // 
            // W1
            // 
            this.W1.HeaderText = "W1";
            this.W1.Name = "W1";
            this.W1.ReadOnly = true;
            this.W1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.W1.Width = 43;
            // 
            // W2
            // 
            this.W2.HeaderText = "W2";
            this.W2.Name = "W2";
            this.W2.ReadOnly = true;
            this.W2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.W2.Width = 43;
            // 
            // W3
            // 
            this.W3.HeaderText = "W3";
            this.W3.Name = "W3";
            this.W3.ReadOnly = true;
            this.W3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.W3.Width = 43;
            // 
            // errors
            // 
            this.errors.HeaderText = "errors";
            this.errors.Name = "errors";
            this.errors.ReadOnly = true;
            this.errors.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.errors.Width = 48;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 228);
            this.Controls.Add(this._tabResults);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(418, 266);
            this.Name = "Form1";
            this.Text = "Form1";
            this._tabResults.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this._panelRun.ResumeLayout(false);
            this._panelExit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gridDesiredOutput)).EndInit();
            this._panelDesiredOutput.ResumeLayout(false);
            this._panelDesiredOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nUpDownDesiredOutput)).EndInit();
            this._panelLearningRate.ResumeLayout(false);
            this._panelLearningRate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nUpDownLearningRate)).EndInit();
            this._panelThreshold.ResumeLayout(false);
            this._panelThreshold.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nUpDownThreshold)).EndInit();
            this._panelRandomise.ResumeLayout(false);
            this._panelRandomise.PerformLayout();
            this.weightsTabPage.ResumeLayout(false);
            this._panelTotalEpochs.ResumeLayout(false);
            this._panelTotalEpochs.PerformLayout();
            this._panelFinalWeights.ResumeLayout(false);
            this._panelFinalWeights.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridTrainingResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _tabResults;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.Panel _panelRun;
        private System.Windows.Forms.Button _btnReset;
        private System.Windows.Forms.Button _btnRun;
        private System.Windows.Forms.Panel _panelExit;
        private System.Windows.Forms.Button _btnExit;
        private System.Windows.Forms.DataGridView _gridDesiredOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn X1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X2;
        private System.Windows.Forms.DataGridViewTextBoxColumn X3;
        private System.Windows.Forms.Panel _panelDesiredOutput;
        private System.Windows.Forms.NumericUpDown _nUpDownDesiredOutput;
        private System.Windows.Forms.Label _lblDesiredOutput;
        private System.Windows.Forms.Panel _panelLearningRate;
        private System.Windows.Forms.NumericUpDown _nUpDownLearningRate;
        private System.Windows.Forms.Label _lblLearningRate;
        private System.Windows.Forms.Panel _panelThreshold;
        private System.Windows.Forms.NumericUpDown _nUpDownThreshold;
        private System.Windows.Forms.Label _lblThreshold;
        private System.Windows.Forms.Panel _panelRandomise;
        private System.Windows.Forms.Button _btnRandomise;
        private System.Windows.Forms.Label genGraphLbl;
        private System.Windows.Forms.TabPage weightsTabPage;
        private System.Windows.Forms.Panel _panelTotalEpochs;
        private System.Windows.Forms.Label epochsCountLbl;
        private System.Windows.Forms.Label _lblTotalEpochs;
        private System.Windows.Forms.Panel _panelFinalWeights;
        private System.Windows.Forms.Label finWeightsCountLbl;
        private System.Windows.Forms.Label _lblFinalWeights;
        private System.Windows.Forms.DataGridView _gridTrainingResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn Epoch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn W1;
        private System.Windows.Forms.DataGridViewTextBoxColumn W2;
        private System.Windows.Forms.DataGridViewTextBoxColumn W3;
        private System.Windows.Forms.DataGridViewTextBoxColumn errors;
    }
}

