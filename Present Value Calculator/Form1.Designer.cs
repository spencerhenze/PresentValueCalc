namespace Present_Value_Calculator
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.howMuchLabel = new System.Windows.Forms.Label();
            this.howLongLabel = new System.Windows.Forms.Label();
            this.intRateLabel = new System.Windows.Forms.Label();
            this.goalAmtTextBox = new System.Windows.Forms.TextBox();
            this.yearsTextBox = new System.Windows.Forms.TextBox();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.yearsLabel = new System.Windows.Forms.Label();
            this.pcntLabel = new System.Windows.Forms.Label();
            this.youNeedLabel = new System.Windows.Forms.Label();
            this.resultDispLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.dollarLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(47, 343);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(105, 23);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate Amount";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(324, 343);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Present Value Calculator";
            // 
            // howMuchLabel
            // 
            this.howMuchLabel.Location = new System.Drawing.Point(56, 80);
            this.howMuchLabel.Name = "howMuchLabel";
            this.howMuchLabel.Size = new System.Drawing.Size(175, 46);
            this.howMuchLabel.TabIndex = 3;
            this.howMuchLabel.Text = "How much money do you want to have at the end of the period?";
            // 
            // howLongLabel
            // 
            this.howLongLabel.Location = new System.Drawing.Point(56, 126);
            this.howLongLabel.Name = "howLongLabel";
            this.howLongLabel.Size = new System.Drawing.Size(175, 39);
            this.howLongLabel.TabIndex = 4;
            this.howLongLabel.Text = "How many years are you willing to wait for interest to accrue?";
            // 
            // intRateLabel
            // 
            this.intRateLabel.AutoSize = true;
            this.intRateLabel.Location = new System.Drawing.Point(56, 187);
            this.intRateLabel.Name = "intRateLabel";
            this.intRateLabel.Size = new System.Drawing.Size(122, 13);
            this.intRateLabel.TabIndex = 5;
            this.intRateLabel.Text = "What\'s the interest rate?";
            // 
            // goalAmtTextBox
            // 
            this.goalAmtTextBox.Location = new System.Drawing.Point(275, 80);
            this.goalAmtTextBox.Name = "goalAmtTextBox";
            this.goalAmtTextBox.Size = new System.Drawing.Size(100, 20);
            this.goalAmtTextBox.TabIndex = 6;
            this.goalAmtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // yearsTextBox
            // 
            this.yearsTextBox.Location = new System.Drawing.Point(275, 126);
            this.yearsTextBox.Name = "yearsTextBox";
            this.yearsTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearsTextBox.TabIndex = 7;
            this.yearsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rateTextBox
            // 
            this.rateTextBox.Location = new System.Drawing.Point(275, 178);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(100, 20);
            this.rateTextBox.TabIndex = 8;
            this.rateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // yearsLabel
            // 
            this.yearsLabel.AutoSize = true;
            this.yearsLabel.Location = new System.Drawing.Point(381, 129);
            this.yearsLabel.Name = "yearsLabel";
            this.yearsLabel.Size = new System.Drawing.Size(32, 13);
            this.yearsLabel.TabIndex = 9;
            this.yearsLabel.Text = "years";
            // 
            // pcntLabel
            // 
            this.pcntLabel.AutoSize = true;
            this.pcntLabel.Location = new System.Drawing.Point(381, 181);
            this.pcntLabel.Name = "pcntLabel";
            this.pcntLabel.Size = new System.Drawing.Size(40, 13);
            this.pcntLabel.TabIndex = 10;
            this.pcntLabel.Text = "% APR";
            // 
            // youNeedLabel
            // 
            this.youNeedLabel.AutoSize = true;
            this.youNeedLabel.Location = new System.Drawing.Point(42, 249);
            this.youNeedLabel.Name = "youNeedLabel";
            this.youNeedLabel.Size = new System.Drawing.Size(379, 13);
            this.youNeedLabel.TabIndex = 11;
            this.youNeedLabel.Text = "Given the information provided, the amount you would need to deposit today is:";
            // 
            // resultDispLabel
            // 
            this.resultDispLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultDispLabel.Location = new System.Drawing.Point(159, 273);
            this.resultDispLabel.Name = "resultDispLabel";
            this.resultDispLabel.Size = new System.Drawing.Size(138, 29);
            this.resultDispLabel.TabIndex = 12;
            this.resultDispLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(201, 343);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // dollarLabel
            // 
            this.dollarLabel.AutoSize = true;
            this.dollarLabel.Location = new System.Drawing.Point(256, 83);
            this.dollarLabel.Name = "dollarLabel";
            this.dollarLabel.Size = new System.Drawing.Size(13, 13);
            this.dollarLabel.TabIndex = 14;
            this.dollarLabel.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 400);
            this.Controls.Add(this.dollarLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.resultDispLabel);
            this.Controls.Add(this.youNeedLabel);
            this.Controls.Add(this.pcntLabel);
            this.Controls.Add(this.yearsLabel);
            this.Controls.Add(this.rateTextBox);
            this.Controls.Add(this.yearsTextBox);
            this.Controls.Add(this.goalAmtTextBox);
            this.Controls.Add(this.intRateLabel);
            this.Controls.Add(this.howLongLabel);
            this.Controls.Add(this.howMuchLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Present Value Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label howMuchLabel;
        private System.Windows.Forms.Label howLongLabel;
        private System.Windows.Forms.Label intRateLabel;
        private System.Windows.Forms.TextBox goalAmtTextBox;
        private System.Windows.Forms.TextBox yearsTextBox;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.Label yearsLabel;
        private System.Windows.Forms.Label pcntLabel;
        private System.Windows.Forms.Label youNeedLabel;
        private System.Windows.Forms.Label resultDispLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label dollarLabel;
    }
}

