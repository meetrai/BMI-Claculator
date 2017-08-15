namespace BmiCalculator
{
    partial class TheCalculatorForm
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
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.ImperialButton = new System.Windows.Forms.RadioButton();
            this.ImperialRadio = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Unit2Label = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.UnitLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.ImperialRadio.SuspendLayout();
            this.panel2.SuspendLayout();
            this.HeightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricRadioButton.Location = new System.Drawing.Point(145, 3);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(88, 38);
            this.MetricRadioButton.TabIndex = 1;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.MetricRadioButtons_CheckedChanged);
            // 
            // ImperialButton
            // 
            this.ImperialButton.AutoSize = true;
            this.ImperialButton.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialButton.Location = new System.Drawing.Point(3, 3);
            this.ImperialButton.Name = "ImperialButton";
            this.ImperialButton.Size = new System.Drawing.Size(102, 38);
            this.ImperialButton.TabIndex = 0;
            this.ImperialButton.TabStop = true;
            this.ImperialButton.Text = "Imperial";
            this.ImperialButton.UseVisualStyleBackColor = true;
            this.ImperialButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ImperialRadio
            // 
            this.ImperialRadio.ColumnCount = 2;
            this.ImperialRadio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.71429F));
            this.ImperialRadio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.28571F));
            this.ImperialRadio.Controls.Add(this.panel2, 1, 1);
            this.ImperialRadio.Controls.Add(this.HeightPanel, 1, 2);
            this.ImperialRadio.Controls.Add(this.ImperialButton, 0, 0);
            this.ImperialRadio.Controls.Add(this.MetricRadioButton, 1, 0);
            this.ImperialRadio.Controls.Add(this.HeightLabel, 0, 1);
            this.ImperialRadio.Controls.Add(this.WeightLabel, 0, 2);
            this.ImperialRadio.Controls.Add(this.CalculateButton, 0, 3);
            this.ImperialRadio.Controls.Add(this.ResetButton, 1, 3);
            this.ImperialRadio.Controls.Add(this.ResultTextBox, 0, 4);
            this.ImperialRadio.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialRadio.Location = new System.Drawing.Point(12, 12);
            this.ImperialRadio.Name = "ImperialRadio";
            this.ImperialRadio.RowCount = 5;
            this.ImperialRadio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.67516F));
            this.ImperialRadio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.32484F));
            this.ImperialRadio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.ImperialRadio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.ImperialRadio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.ImperialRadio.Size = new System.Drawing.Size(280, 405);
            this.ImperialRadio.TabIndex = 0;
            this.ImperialRadio.Paint += new System.Windows.Forms.PaintEventHandler(this.ImperialRadio_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Unit2Label);
            this.panel2.Controls.Add(this.HeightTextBox);
            this.panel2.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(145, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 67);
            this.panel2.TabIndex = 1;
            // 
            // Unit2Label
            // 
            this.Unit2Label.AutoSize = true;
            this.Unit2Label.Location = new System.Drawing.Point(48, 20);
            this.Unit2Label.Name = "Unit2Label";
            this.Unit2Label.Size = new System.Drawing.Size(0, 24);
            this.Unit2Label.TabIndex = 6;
            this.Unit2Label.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(3, 20);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(42, 31);
            this.HeightTextBox.TabIndex = 5;
            this.HeightTextBox.TextChanged += new System.EventHandler(this.WeightTextBox_TextChanged);
            // 
            // HeightPanel
            // 
            this.HeightPanel.Controls.Add(this.label1);
            this.HeightPanel.Controls.Add(this.UnitLabel);
            this.HeightPanel.Controls.Add(this.WeightTextBox);
            this.HeightPanel.Location = new System.Drawing.Point(145, 158);
            this.HeightPanel.Name = "HeightPanel";
            this.HeightPanel.Size = new System.Drawing.Size(132, 64);
            this.HeightPanel.TabIndex = 2;
            this.HeightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 5;
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // UnitLabel
            // 
            this.UnitLabel.AutoSize = true;
            this.UnitLabel.Location = new System.Drawing.Point(48, 21);
            this.UnitLabel.Name = "UnitLabel";
            this.UnitLabel.Size = new System.Drawing.Size(0, 32);
            this.UnitLabel.TabIndex = 4;
            this.UnitLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightTextBox.Location = new System.Drawing.Point(0, 18);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(42, 31);
            this.WeightTextBox.TabIndex = 3;
            this.WeightTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(3, 66);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(136, 89);
            this.HeightLabel.TabIndex = 2;
            this.HeightLabel.Text = "My Height";
            this.HeightLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(3, 155);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(103, 34);
            this.WeightLabel.TabIndex = 4;
            this.WeightLabel.Text = "My Weight";
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.Thistle;
            this.CalculateButton.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(3, 242);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(103, 37);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Thistle;
            this.ResetButton.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(145, 242);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(100, 37);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ResultTextBox
            // 
            this.ImperialRadio.SetColumnSpan(this.ResultTextBox, 2);
            this.ResultTextBox.Location = new System.Drawing.Point(3, 309);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(258, 78);
            this.ResultTextBox.TabIndex = 8;
            this.ResultTextBox.TextChanged += new System.EventHandler(this.ResultTextBox_TextChanged);
            // 
            // TheCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(296, 442);
            this.Controls.Add(this.ImperialRadio);
            this.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "TheCalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BmiCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ImperialRadio.ResumeLayout(false);
            this.ImperialRadio.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.HeightPanel.ResumeLayout(false);
            this.HeightPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.RadioButton ImperialButton;
        private System.Windows.Forms.TableLayoutPanel ImperialRadio;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Panel HeightPanel;
        private System.Windows.Forms.Label UnitLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Unit2Label;
        private System.Windows.Forms.Label label1;
    }
}

