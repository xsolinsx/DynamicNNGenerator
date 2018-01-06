namespace DynamicNNGenerator
{
    partial class FormDynamicNNGenerator
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDown_BitsOfParity = new System.Windows.Forms.NumericUpDown();
            this.button_GeneratePattern = new System.Windows.Forms.Button();
            this.label_BitsOfParity = new System.Windows.Forms.Label();
            this.groupBox_Pattern = new System.Windows.Forms.GroupBox();
            this.groupBox_Network = new System.Windows.Forms.GroupBox();
            this.label_To = new System.Windows.Forms.Label();
            this.label_From = new System.Windows.Forms.Label();
            this.checkBox_RandomWeights = new System.Windows.Forms.CheckBox();
            this.textBox_From = new System.Windows.Forms.TextBox();
            this.textBox_To = new System.Windows.Forms.TextBox();
            this.button_GenerateNetwork = new System.Windows.Forms.Button();
            this.numericUpDown_OutputUnits = new System.Windows.Forms.NumericUpDown();
            this.label_OutputUnits = new System.Windows.Forms.Label();
            this.numericUpDown_HiddenUnits = new System.Windows.Forms.NumericUpDown();
            this.label_HiddenUnits = new System.Windows.Forms.Label();
            this.numericUpDown_InputUnits = new System.Windows.Forms.NumericUpDown();
            this.label_InputUnits = new System.Windows.Forms.Label();
            this.backgroundWorker_PatternComputation = new System.ComponentModel.BackgroundWorker();
            this.progressBar_PatternComputation = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker_NetworkComputation = new System.ComponentModel.BackgroundWorker();
            this.progressBar_NetworkComputation = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BitsOfParity)).BeginInit();
            this.groupBox_Pattern.SuspendLayout();
            this.groupBox_Network.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_OutputUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_HiddenUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_InputUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_BitsOfParity
            // 
            this.numericUpDown_BitsOfParity.Location = new System.Drawing.Point(83, 28);
            this.numericUpDown_BitsOfParity.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.numericUpDown_BitsOfParity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_BitsOfParity.Name = "numericUpDown_BitsOfParity";
            this.numericUpDown_BitsOfParity.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown_BitsOfParity.TabIndex = 6;
            this.numericUpDown_BitsOfParity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_BitsOfParity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_GeneratePattern
            // 
            this.button_GeneratePattern.Location = new System.Drawing.Point(158, 19);
            this.button_GeneratePattern.Name = "button_GeneratePattern";
            this.button_GeneratePattern.Size = new System.Drawing.Size(75, 35);
            this.button_GeneratePattern.TabIndex = 5;
            this.button_GeneratePattern.Text = "Generate pattern";
            this.button_GeneratePattern.UseVisualStyleBackColor = true;
            this.button_GeneratePattern.Click += new System.EventHandler(this.button_GeneratePattern_Click);
            // 
            // label_BitsOfParity
            // 
            this.label_BitsOfParity.AutoSize = true;
            this.label_BitsOfParity.Location = new System.Drawing.Point(6, 30);
            this.label_BitsOfParity.Name = "label_BitsOfParity";
            this.label_BitsOfParity.Size = new System.Drawing.Size(71, 13);
            this.label_BitsOfParity.TabIndex = 4;
            this.label_BitsOfParity.Text = "Bits of Parity: ";
            // 
            // groupBox_Pattern
            // 
            this.groupBox_Pattern.Controls.Add(this.button_GeneratePattern);
            this.groupBox_Pattern.Controls.Add(this.numericUpDown_BitsOfParity);
            this.groupBox_Pattern.Controls.Add(this.label_BitsOfParity);
            this.groupBox_Pattern.Location = new System.Drawing.Point(12, 198);
            this.groupBox_Pattern.Name = "groupBox_Pattern";
            this.groupBox_Pattern.Size = new System.Drawing.Size(240, 60);
            this.groupBox_Pattern.TabIndex = 7;
            this.groupBox_Pattern.TabStop = false;
            this.groupBox_Pattern.Text = "Pattern";
            // 
            // groupBox_Network
            // 
            this.groupBox_Network.Controls.Add(this.label_To);
            this.groupBox_Network.Controls.Add(this.label_From);
            this.groupBox_Network.Controls.Add(this.checkBox_RandomWeights);
            this.groupBox_Network.Controls.Add(this.textBox_From);
            this.groupBox_Network.Controls.Add(this.textBox_To);
            this.groupBox_Network.Controls.Add(this.button_GenerateNetwork);
            this.groupBox_Network.Controls.Add(this.numericUpDown_OutputUnits);
            this.groupBox_Network.Controls.Add(this.label_OutputUnits);
            this.groupBox_Network.Controls.Add(this.numericUpDown_HiddenUnits);
            this.groupBox_Network.Controls.Add(this.label_HiddenUnits);
            this.groupBox_Network.Controls.Add(this.numericUpDown_InputUnits);
            this.groupBox_Network.Controls.Add(this.label_InputUnits);
            this.groupBox_Network.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Network.Name = "groupBox_Network";
            this.groupBox_Network.Size = new System.Drawing.Size(240, 151);
            this.groupBox_Network.TabIndex = 8;
            this.groupBox_Network.TabStop = false;
            this.groupBox_Network.Text = "Network";
            // 
            // label_To
            // 
            this.label_To.AutoSize = true;
            this.label_To.Location = new System.Drawing.Point(120, 126);
            this.label_To.Name = "label_To";
            this.label_To.Size = new System.Drawing.Size(26, 13);
            this.label_To.TabIndex = 11;
            this.label_To.Text = "To: ";
            // 
            // label_From
            // 
            this.label_From.AutoSize = true;
            this.label_From.Location = new System.Drawing.Point(120, 100);
            this.label_From.Name = "label_From";
            this.label_From.Size = new System.Drawing.Size(36, 13);
            this.label_From.TabIndex = 10;
            this.label_From.Text = "From: ";
            // 
            // checkBox_RandomWeights
            // 
            this.checkBox_RandomWeights.AutoSize = true;
            this.checkBox_RandomWeights.Location = new System.Drawing.Point(6, 111);
            this.checkBox_RandomWeights.Name = "checkBox_RandomWeights";
            this.checkBox_RandomWeights.Size = new System.Drawing.Size(108, 17);
            this.checkBox_RandomWeights.TabIndex = 9;
            this.checkBox_RandomWeights.Text = "Random Weights";
            this.checkBox_RandomWeights.UseVisualStyleBackColor = true;
            this.checkBox_RandomWeights.CheckedChanged += new System.EventHandler(this.checkBox_RandomWeights_CheckedChanged);
            // 
            // textBox_From
            // 
            this.textBox_From.Enabled = false;
            this.textBox_From.Location = new System.Drawing.Point(162, 97);
            this.textBox_From.Name = "textBox_From";
            this.textBox_From.Size = new System.Drawing.Size(72, 20);
            this.textBox_From.TabIndex = 8;
            this.textBox_From.Text = "-1.0";
            this.textBox_From.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_To
            // 
            this.textBox_To.Enabled = false;
            this.textBox_To.Location = new System.Drawing.Point(162, 123);
            this.textBox_To.Name = "textBox_To";
            this.textBox_To.Size = new System.Drawing.Size(72, 20);
            this.textBox_To.TabIndex = 7;
            this.textBox_To.Text = "1.0";
            this.textBox_To.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_GenerateNetwork
            // 
            this.button_GenerateNetwork.Location = new System.Drawing.Point(159, 19);
            this.button_GenerateNetwork.Name = "button_GenerateNetwork";
            this.button_GenerateNetwork.Size = new System.Drawing.Size(75, 72);
            this.button_GenerateNetwork.TabIndex = 5;
            this.button_GenerateNetwork.Text = "Generate network";
            this.button_GenerateNetwork.UseVisualStyleBackColor = true;
            this.button_GenerateNetwork.Click += new System.EventHandler(this.button_GenerateNetwork_Click);
            // 
            // numericUpDown_OutputUnits
            // 
            this.numericUpDown_OutputUnits.Location = new System.Drawing.Point(84, 71);
            this.numericUpDown_OutputUnits.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numericUpDown_OutputUnits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_OutputUnits.Name = "numericUpDown_OutputUnits";
            this.numericUpDown_OutputUnits.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown_OutputUnits.TabIndex = 6;
            this.numericUpDown_OutputUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_OutputUnits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_OutputUnits
            // 
            this.label_OutputUnits.AutoSize = true;
            this.label_OutputUnits.Location = new System.Drawing.Point(6, 73);
            this.label_OutputUnits.Name = "label_OutputUnits";
            this.label_OutputUnits.Size = new System.Drawing.Size(70, 13);
            this.label_OutputUnits.TabIndex = 4;
            this.label_OutputUnits.Text = "Output units: ";
            // 
            // numericUpDown_HiddenUnits
            // 
            this.numericUpDown_HiddenUnits.Location = new System.Drawing.Point(84, 45);
            this.numericUpDown_HiddenUnits.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numericUpDown_HiddenUnits.Name = "numericUpDown_HiddenUnits";
            this.numericUpDown_HiddenUnits.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown_HiddenUnits.TabIndex = 6;
            this.numericUpDown_HiddenUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_HiddenUnits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_HiddenUnits
            // 
            this.label_HiddenUnits.AutoSize = true;
            this.label_HiddenUnits.Location = new System.Drawing.Point(6, 47);
            this.label_HiddenUnits.Name = "label_HiddenUnits";
            this.label_HiddenUnits.Size = new System.Drawing.Size(72, 13);
            this.label_HiddenUnits.TabIndex = 4;
            this.label_HiddenUnits.Text = "Hidden units: ";
            // 
            // numericUpDown_InputUnits
            // 
            this.numericUpDown_InputUnits.Location = new System.Drawing.Point(84, 19);
            this.numericUpDown_InputUnits.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numericUpDown_InputUnits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_InputUnits.Name = "numericUpDown_InputUnits";
            this.numericUpDown_InputUnits.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown_InputUnits.TabIndex = 6;
            this.numericUpDown_InputUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_InputUnits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_InputUnits.ValueChanged += new System.EventHandler(this.numericUpDowns_ValueChanged);
            // 
            // label_InputUnits
            // 
            this.label_InputUnits.AutoSize = true;
            this.label_InputUnits.Location = new System.Drawing.Point(6, 21);
            this.label_InputUnits.Name = "label_InputUnits";
            this.label_InputUnits.Size = new System.Drawing.Size(62, 13);
            this.label_InputUnits.TabIndex = 4;
            this.label_InputUnits.Text = "Input units: ";
            // 
            // backgroundWorker_PatternComputation
            // 
            this.backgroundWorker_PatternComputation.WorkerReportsProgress = true;
            this.backgroundWorker_PatternComputation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_PatternComputation_DoWork);
            this.backgroundWorker_PatternComputation.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_PatternComputation_ProgressChanged);
            this.backgroundWorker_PatternComputation.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_PatternComputation_RunWorkerCompleted);
            // 
            // progressBar_PatternComputation
            // 
            this.progressBar_PatternComputation.Location = new System.Drawing.Point(12, 264);
            this.progressBar_PatternComputation.Name = "progressBar_PatternComputation";
            this.progressBar_PatternComputation.Size = new System.Drawing.Size(240, 23);
            this.progressBar_PatternComputation.TabIndex = 9;
            // 
            // backgroundWorker_NetworkComputation
            // 
            this.backgroundWorker_NetworkComputation.WorkerReportsProgress = true;
            this.backgroundWorker_NetworkComputation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_NetworkComputation_DoWork);
            this.backgroundWorker_NetworkComputation.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_NetworkComputation_ProgressChanged);
            this.backgroundWorker_NetworkComputation.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_NetworkComputation_RunWorkerCompleted);
            // 
            // progressBar_NetworkComputation
            // 
            this.progressBar_NetworkComputation.Location = new System.Drawing.Point(12, 169);
            this.progressBar_NetworkComputation.Name = "progressBar_NetworkComputation";
            this.progressBar_NetworkComputation.Size = new System.Drawing.Size(240, 23);
            this.progressBar_NetworkComputation.TabIndex = 10;
            // 
            // FormDynamicNNGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 299);
            this.Controls.Add(this.progressBar_NetworkComputation);
            this.Controls.Add(this.progressBar_PatternComputation);
            this.Controls.Add(this.groupBox_Network);
            this.Controls.Add(this.groupBox_Pattern);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDynamicNNGenerator";
            this.Text = "Dynamic NN Generator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BitsOfParity)).EndInit();
            this.groupBox_Pattern.ResumeLayout(false);
            this.groupBox_Pattern.PerformLayout();
            this.groupBox_Network.ResumeLayout(false);
            this.groupBox_Network.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_OutputUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_HiddenUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_InputUnits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_BitsOfParity;
        private System.Windows.Forms.Button button_GeneratePattern;
        private System.Windows.Forms.Label label_BitsOfParity;
        private System.Windows.Forms.GroupBox groupBox_Pattern;
        private System.Windows.Forms.GroupBox groupBox_Network;
        private System.Windows.Forms.Button button_GenerateNetwork;
        private System.Windows.Forms.NumericUpDown numericUpDown_InputUnits;
        private System.Windows.Forms.Label label_InputUnits;
        private System.Windows.Forms.NumericUpDown numericUpDown_OutputUnits;
        private System.Windows.Forms.Label label_OutputUnits;
        private System.Windows.Forms.NumericUpDown numericUpDown_HiddenUnits;
        private System.Windows.Forms.Label label_HiddenUnits;
        private System.Windows.Forms.Label label_To;
        private System.Windows.Forms.Label label_From;
        private System.Windows.Forms.CheckBox checkBox_RandomWeights;
        private System.Windows.Forms.TextBox textBox_From;
        private System.Windows.Forms.TextBox textBox_To;
        private System.ComponentModel.BackgroundWorker backgroundWorker_PatternComputation;
        private System.Windows.Forms.ProgressBar progressBar_PatternComputation;
        private System.ComponentModel.BackgroundWorker backgroundWorker_NetworkComputation;
        private System.Windows.Forms.ProgressBar progressBar_NetworkComputation;

    }
}

