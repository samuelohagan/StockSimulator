namespace montecarloform
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.myTextBox = new System.Windows.Forms.TextBox();
            this.myTextBox2 = new System.Windows.Forms.TextBox();
            this.myTextBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(2, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(911, 597);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 638);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // myTextBox
            // 
            this.myTextBox.Location = new System.Drawing.Point(46, 676);
            this.myTextBox.Name = "myTextBox";
            this.myTextBox.Size = new System.Drawing.Size(151, 20);
            this.myTextBox.TabIndex = 2;
            this.myTextBox.Text = "Starting Price";
            // 
            // myTextBox2
            // 
            this.myTextBox2.Location = new System.Drawing.Point(575, 667);
            this.myTextBox2.Name = "myTextBox2";
            this.myTextBox2.Size = new System.Drawing.Size(129, 20);
            this.myTextBox2.TabIndex = 3;
            this.myTextBox2.Text = "Expected Price Increase";
            // 
            // myTextBox3
            // 
            this.myTextBox3.Location = new System.Drawing.Point(746, 667);
            this.myTextBox3.Name = "myTextBox3";
            this.myTextBox3.Size = new System.Drawing.Size(100, 20);
            this.myTextBox3.TabIndex = 4;
            this.myTextBox3.Text = "StdDeviation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(63, 745);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "90% chance that the price will be greater then this";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(486, 745);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "75% chance that the price will be greater then this";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(63, 826);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "50% chance that the price will be greater then this";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(486, 826);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "25% chance that the price will be greater then this";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label90.Location = new System.Drawing.Point(155, 789);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(42, 18);
            this.label90.TabIndex = 9;
            this.label90.Text = "Price";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label75.Location = new System.Drawing.Point(662, 789);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(42, 18);
            this.label75.TabIndex = 10;
            this.label75.Text = "Price";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label50.Location = new System.Drawing.Point(155, 875);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(42, 18);
            this.label50.TabIndex = 11;
            this.label50.Text = "Price";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label25.Location = new System.Drawing.Point(662, 875);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(42, 18);
            this.label25.TabIndex = 12;
            this.label25.Text = "Price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 920);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.label75);
            this.Controls.Add(this.label90);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myTextBox3);
            this.Controls.Add(this.myTextBox2);
            this.Controls.Add(this.myTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Monte Carlo Stock Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox myTextBox;
        private System.Windows.Forms.TextBox myTextBox2;
        private System.Windows.Forms.TextBox myTextBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label25;
    }
}

