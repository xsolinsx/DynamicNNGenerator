﻿using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DynamicNNGenerator
{
    public partial class FormDynamicNNGenerator : Form
    {
        public FormDynamicNNGenerator()
        {
            InitializeComponent();
            //making things work like:
            //numbers are expressed with this notation: X.Y where X is the integer part and Y is the decimal part (if present), no group separator
            //examples: 100000000.00001     101  1.1     1.123   11111.1     0.1
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            customCulture.NumberFormat.NumberGroupSeparator = "";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void numericUpDowns_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (numericUpDown_InputUnits.Value + numericUpDown_HiddenUnits.Value + numericUpDown_OutputUnits.Value > Decimal.MaxValue)
                    throw new Exception();
            }
            catch
            {
                MessageBox.Show("Too much units.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericUpDown_InputUnits.Value = 1;
                numericUpDown_HiddenUnits.Value = 1;
                numericUpDown_OutputUnits.Value = 1;
            }
        }

        private void checkBox_RandomWeights_CheckedChanged(object sender, EventArgs e)
        {
            textBox_To.Enabled = !textBox_To.Enabled;
            textBox_From.Enabled = !textBox_From.Enabled;
        }

        private void button_GenerateNetwork_Click(object sender, EventArgs e)
        {
            double min, max;
            if (checkBox_RandomWeights.Checked)
            {
                Regex regexWeights = new Regex("^[+-]?[0-9]*[\\.\\,]?[0-9]+$");
                if (regexWeights.IsMatch(textBox_From.Text) && regexWeights.IsMatch(textBox_To.Text))
                {
                    min = Convert.ToDouble(textBox_From.Text);
                    max = Convert.ToDouble(textBox_To.Text);
                }
                else
                {
                    MessageBox.Show("Incorrect input.\nNeed Real Numbers.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                min = 0;
                max = 0;
            }
            string FileName = "evenOdd-" + DateTime.UtcNow.ToFileTime() + "-Network" + numericUpDown_InputUnits.Value + "I" + numericUpDown_HiddenUnits.Value + "H" + numericUpDown_OutputUnits.Value + "O.net";

            try
            {
                StreamWriter SW = new StreamWriter(new FileStream(FileName, FileMode.CreateNew, FileAccess.Write, FileShare.None));
                SW.WriteLine("SNNS network definition file V1.4-3D\ngenerated at " + DateTime.UtcNow.ToString("ddd MMM dd HH:mm:ss yyyy") + "\n");

                SW.WriteLine("network name : " + FileName);
                SW.WriteLine("source files : ");
                SW.WriteLine("no. of units : " + (numericUpDown_InputUnits.Value + numericUpDown_HiddenUnits.Value + numericUpDown_OutputUnits.Value));
                SW.WriteLine("no. of connections : 0");
                SW.WriteLine("no. of unit types : 0");
                SW.WriteLine("no. of site types : 0\n\n");

                SW.WriteLine("learning function : Std_Backpropagation");
                SW.WriteLine("update function   : Topological_Order\n\n");

                SW.WriteLine("unit default section :\n");
                SW.WriteLine("act      | bias     | st | subnet | layer | act func     | out func");
                SW.WriteLine("---------|----------|----|--------|-------|--------------|-------------");
                SW.WriteLine(" 0.00000 |  0.00000 | h  |      0 |     1 | Act_Logistic | Out_Identity ");
                SW.WriteLine("---------|----------|----|--------|-------|--------------|-------------\n\n");

                SW.WriteLine("unit definition section :\n");
                SW.WriteLine("no. | typeName | unitName | act      | bias     | st | position | act func | out func | sites");
                SW.WriteLine("----|----------|----------|----------|----------|----|----------|----------|----------|-------");
                int iTot = 1;
                Random rnd = new Random();
                //write input units
                for (decimal i = 1; i <= numericUpDown_InputUnits.Value; i++)
                {
                    SW.WriteLine(" " + iTot + " |          | noName   |  0.00000 | " + (rnd.NextDouble() * (max - min) + min) + " | i  | " + i + ", 1, 1 |||");
                    iTot++;
                }
                //write hidden units
                for (decimal i = 1; i <= numericUpDown_HiddenUnits.Value; i++)
                {
                    SW.WriteLine(" " + iTot + " |          | noName   |  0.00000 | " + (rnd.NextDouble() * (max - min) + min) + " | h  | " + i + ", 2, 1 |||");
                    iTot++;
                }
                //write output units
                for (decimal i = 1; i <= numericUpDown_OutputUnits.Value; i++)
                {
                    SW.WriteLine(" " + iTot + " |          | noName   |  0.00000 | " + (rnd.NextDouble() * (max - min) + min) + " | o  | " + i + ", 3, 1 |||");
                    iTot++;
                }
                SW.WriteLine("----|----------|----------|----------|----------|----|----------|----------|----------|-------\n\n");

                SW.WriteLine("layer definition section :\n");
                SW.WriteLine("layer | unitNo.");
                SW.WriteLine("------|----------------------------------------------------------------------------------------------------------------------------");

                string numbers = "";
                if (numericUpDown_InputUnits.Value + numericUpDown_HiddenUnits.Value != numericUpDown_InputUnits.Value)
                {
                    //write units layer 2
                    for (decimal i = (decimal)(numericUpDown_InputUnits.Value + 1); i <= numericUpDown_InputUnits.Value + numericUpDown_HiddenUnits.Value; i++)
                        numbers += i + ", ";
                    if (numbers.LastIndexOf(',') > -1)
                        //remove last comma
                        numbers = numbers.Remove(numbers.LastIndexOf(','));
                    SW.WriteLine("    2 | " + numbers);
                }
                if (numericUpDown_InputUnits.Value + numericUpDown_HiddenUnits.Value + numericUpDown_OutputUnits.Value != numericUpDown_InputUnits.Value + numericUpDown_HiddenUnits.Value)
                {
                    numbers = "";
                    //write units layer 3
                    for (decimal i = (decimal)(numericUpDown_InputUnits.Value + numericUpDown_HiddenUnits.Value + 1); i <= numericUpDown_InputUnits.Value + numericUpDown_HiddenUnits.Value + numericUpDown_OutputUnits.Value; i++)
                        numbers += i + ", ";
                    if (numbers.LastIndexOf(',') > -1)
                        //remove last comma
                        numbers = numbers.Remove(numbers.LastIndexOf(','));
                    SW.WriteLine("    3 | " + numbers);
                }
                SW.WriteLine("------|----------------------------------------------------------------------------------------------------------------------------");
                SW.Close();
            }
            catch (Exception ex)
            { MessageBox.Show("Error\n" + ex.Source + "\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /* PATTERN EXAMPLE WITH 3 INPUT UNITS
         * 0 EVEN
         * 1 ODD
         * I1   I2  I3  RESULT
         * 0    0   0   0
         * 0    0   1   1
         * 0    1   0   1
         * 0    1   1   0
         * 1    0   0   1
         * 1    0   1   0
         * 1    1   0   0
         * 1    1   1   1
         */
        private void button_GeneratePattern_Click(object sender, EventArgs e)
        {
            if (numericUpDown_BitsOfParity.Value > 15)
            {
                if (MessageBox.Show("This is a high number, the process can take a lot while computing and writing 2^" + numericUpDown_BitsOfParity.Value + " training patterns, do you really want to continue?.", "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }
            bool[,] truthTable = new bool[(int)Math.Pow(2.0, (double)numericUpDown_BitsOfParity.Value), (int)numericUpDown_BitsOfParity.Value];
            int alternateIndex = 0;
            bool valueToWrite;
            //fill the matrix
            //starts from the last column
            for (int column = truthTable.GetLength(1) - 1; column >= 0; column--)
            {
                valueToWrite = false;
                int alternate = (int)Math.Pow(2, alternateIndex);
                int rowIndex = 1;
                //starts from the first row
                for (int row = 0; row < truthTable.GetLength(0); row++)
                {
                    truthTable[row, column] = Convert.ToBoolean(valueToWrite);
                    //alternate values every 2^(complement of the column) values
                    if (rowIndex >= alternate)
                    {
                        rowIndex = 1;
                        valueToWrite = !valueToWrite;
                    }
                    else
                        rowIndex++;
                }
                alternateIndex++;
            }
            string FileName = "evenOdd-" + DateTime.UtcNow.ToFileTime() + "-Pattern" + truthTable.GetLength(1) + ".pat";

            try
            {
                StreamWriter SW = new StreamWriter(new FileStream(FileName, FileMode.CreateNew, FileAccess.Write, FileShare.None));
                SW.WriteLine("SNNS pattern definition file V3.2\ngenerated at " + DateTime.UtcNow.ToString("ddd MMM dd HH:mm:ss yyyy") + "\n\n");

                SW.WriteLine("No. of patterns : " + truthTable.GetLength(0));
                SW.WriteLine("No. of input units : " + truthTable.GetLength(1));
                SW.WriteLine("No. of output units : 1\n");

                //write values on file
                for (int row = 0; row < truthTable.GetLength(0); row++)
                {
                    string line = "";
                    int activeUnits = 0;
                    for (int column = 0; column < truthTable.GetLength(1); column++)
                    {
                        if (truthTable[row, column])
                            activeUnits++;
                        line += Convert.ToInt16(truthTable[row, column]) + " ";
                    }
                    SW.WriteLine(line);
                    SW.WriteLine(activeUnits % 2);
                }
                SW.Close();
            }
            catch (Exception ex)
            { MessageBox.Show("Error\n" + ex.Source + "\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}