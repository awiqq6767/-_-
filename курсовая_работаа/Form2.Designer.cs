
namespace курсовая_работаа
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnGraph = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnResearch = new System.Windows.Forms.Button();
            this.lblK = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.lblD = new System.Windows.Forms.Label();
            this.txtPhi = new System.Windows.Forms.TextBox();
            this.lblPhi = new System.Windows.Forms.Label();
            this.txtOmega = new System.Windows.Forms.TextBox();
            this.txtAmplitude = new System.Windows.Forms.TextBox();
            this.lblOmega = new System.Windows.Forms.Label();
            this.lblAmplitude = new System.Windows.Forms.Label();
            this.lblFormula = new System.Windows.Forms.Label();
            this.lblDomain = new System.Windows.Forms.Label();
            this.lblDomainValue = new System.Windows.Forms.Label();
            this.lblZeros = new System.Windows.Forms.Label();
            this.lblZerosValue = new System.Windows.Forms.Label();
            this.lblExtrema = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblPeriodValue = new System.Windows.Forms.Label();
            this.labelParity = new System.Windows.Forms.Label();
            this.lblMonot = new System.Windows.Forms.Label();
            this.lblRange = new System.Windows.Forms.Label();
            this.labelExtremaValue = new System.Windows.Forms.Label();
            this.labelParityValue = new System.Windows.Forms.Label();
            this.labelMonotValue = new System.Windows.Forms.Label();
            this.lblRangeValue = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // chartGraph
            // 
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.Crossing = 0D;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.Maximum = 5D;
            chartArea1.AxisX.Minimum = -5D;
            chartArea1.AxisX.Title = "x";
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisY.Crossing = 0D;
            chartArea1.AxisY.Interval = 1D;
            chartArea1.AxisY.Maximum = 5D;
            chartArea1.AxisY.Minimum = -5D;
            chartArea1.AxisY.Title = "y";
            chartArea1.Name = "ChartArea1";
            this.chartGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGraph.Legends.Add(legend1);
            this.chartGraph.Location = new System.Drawing.Point(872, 155);
            this.chartGraph.Name = "chartGraph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.LabelBorderWidth = 2;
            series1.Legend = "Legend1";
            series1.Name = "FunctionSeries";
            this.chartGraph.Series.Add(series1);
            this.chartGraph.Size = new System.Drawing.Size(491, 360);
            this.chartGraph.TabIndex = 0;
            this.chartGraph.Text = "chart1";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 16F);
            this.labelTitle.Location = new System.Drawing.Point(94, 28);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(110, 25);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Формула:";
            // 
            // btnGraph
            // 
            this.btnGraph.Font = new System.Drawing.Font("Arial", 14F);
            this.btnGraph.Location = new System.Drawing.Point(47, 245);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(199, 43);
            this.btnGraph.TabIndex = 9;
            this.btnGraph.Text = "Построить график";
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 14F);
            this.btnSave.Location = new System.Drawing.Point(872, 520);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 55);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Arial", 14F);
            this.btnBack.Location = new System.Drawing.Point(1039, 521);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(161, 55);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "На главную";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnResearch
            // 
            this.btnResearch.Font = new System.Drawing.Font("Arial", 14F);
            this.btnResearch.Location = new System.Drawing.Point(261, 244);
            this.btnResearch.Name = "btnResearch";
            this.btnResearch.Size = new System.Drawing.Size(199, 44);
            this.btnResearch.TabIndex = 12;
            this.btnResearch.Text = "Исследовать";
            this.btnResearch.UseVisualStyleBackColor = true;
            this.btnResearch.Click += new System.EventHandler(this.btnResearch_Click);
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Font = new System.Drawing.Font("Arial", 14F);
            this.lblK.Location = new System.Drawing.Point(80, 92);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(35, 22);
            this.lblK.TabIndex = 14;
            this.lblK.Text = "k =";
            this.lblK.Visible = false;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Arial", 14F);
            this.lblB.Location = new System.Drawing.Point(80, 123);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(37, 22);
            this.lblB.TabIndex = 16;
            this.lblB.Text = "b =";
            this.lblB.Visible = false;
            // 
            // txtK
            // 
            this.txtK.Font = new System.Drawing.Font("Arial", 14F);
            this.txtK.Location = new System.Drawing.Point(121, 92);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(52, 29);
            this.txtK.TabIndex = 17;
            this.txtK.Visible = false;
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Arial", 14F);
            this.txtB.Location = new System.Drawing.Point(121, 127);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(52, 29);
            this.txtB.TabIndex = 18;
            this.txtB.Visible = false;
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Arial", 14F);
            this.txtC.Location = new System.Drawing.Point(121, 162);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(52, 29);
            this.txtC.TabIndex = 22;
            this.txtC.Visible = false;
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Arial", 14F);
            this.txtA.Location = new System.Drawing.Point(119, 92);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(52, 29);
            this.txtA.TabIndex = 21;
            this.txtA.Visible = false;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Arial", 14F);
            this.lblC.Location = new System.Drawing.Point(80, 158);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(36, 22);
            this.lblC.TabIndex = 20;
            this.lblC.Text = "c =";
            this.lblC.Visible = false;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Arial", 14F);
            this.lblA.Location = new System.Drawing.Point(78, 92);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(36, 22);
            this.lblA.TabIndex = 19;
            this.lblA.Text = "a =";
            this.lblA.Visible = false;
            // 
            // txtD
            // 
            this.txtD.Font = new System.Drawing.Font("Arial", 14F);
            this.txtD.Location = new System.Drawing.Point(121, 197);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(52, 29);
            this.txtD.TabIndex = 24;
            this.txtD.Visible = false;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Arial", 14F);
            this.lblD.Location = new System.Drawing.Point(80, 193);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(37, 22);
            this.lblD.TabIndex = 23;
            this.lblD.Text = "d =";
            this.lblD.Visible = false;
            // 
            // txtPhi
            // 
            this.txtPhi.Font = new System.Drawing.Font("Arial", 14F);
            this.txtPhi.Location = new System.Drawing.Point(121, 162);
            this.txtPhi.Name = "txtPhi";
            this.txtPhi.Size = new System.Drawing.Size(52, 29);
            this.txtPhi.TabIndex = 30;
            this.txtPhi.Visible = false;
            // 
            // lblPhi
            // 
            this.lblPhi.AutoSize = true;
            this.lblPhi.Font = new System.Drawing.Font("Arial", 14F);
            this.lblPhi.Location = new System.Drawing.Point(80, 162);
            this.lblPhi.Name = "lblPhi";
            this.lblPhi.Size = new System.Drawing.Size(38, 22);
            this.lblPhi.TabIndex = 29;
            this.lblPhi.Text = "φ =";
            this.lblPhi.Visible = false;
            // 
            // txtOmega
            // 
            this.txtOmega.Font = new System.Drawing.Font("Arial", 14F);
            this.txtOmega.Location = new System.Drawing.Point(121, 128);
            this.txtOmega.Name = "txtOmega";
            this.txtOmega.Size = new System.Drawing.Size(52, 29);
            this.txtOmega.TabIndex = 28;
            this.txtOmega.Visible = false;
            // 
            // txtAmplitude
            // 
            this.txtAmplitude.Font = new System.Drawing.Font("Arial", 14F);
            this.txtAmplitude.Location = new System.Drawing.Point(121, 93);
            this.txtAmplitude.Name = "txtAmplitude";
            this.txtAmplitude.Size = new System.Drawing.Size(52, 29);
            this.txtAmplitude.TabIndex = 27;
            this.txtAmplitude.Visible = false;
            // 
            // lblOmega
            // 
            this.lblOmega.AutoSize = true;
            this.lblOmega.Font = new System.Drawing.Font("Arial", 14F);
            this.lblOmega.Location = new System.Drawing.Point(80, 124);
            this.lblOmega.Name = "lblOmega";
            this.lblOmega.Size = new System.Drawing.Size(42, 22);
            this.lblOmega.TabIndex = 26;
            this.lblOmega.Text = "ω =";
            this.lblOmega.Visible = false;
            // 
            // lblAmplitude
            // 
            this.lblAmplitude.AutoSize = true;
            this.lblAmplitude.Font = new System.Drawing.Font("Arial", 14F);
            this.lblAmplitude.Location = new System.Drawing.Point(80, 93);
            this.lblAmplitude.Name = "lblAmplitude";
            this.lblAmplitude.Size = new System.Drawing.Size(38, 22);
            this.lblAmplitude.TabIndex = 25;
            this.lblAmplitude.Text = "A =";
            this.lblAmplitude.Visible = false;
            // 
            // lblFormula
            // 
            this.lblFormula.AutoSize = true;
            this.lblFormula.Font = new System.Drawing.Font("Arial", 16F);
            this.lblFormula.Location = new System.Drawing.Point(210, 28);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(12, 25);
            this.lblFormula.TabIndex = 42;
            this.lblFormula.Text = "\t";
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Font = new System.Drawing.Font("Arial", 14F);
            this.lblDomain.Location = new System.Drawing.Point(235, 583);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(15, 22);
            this.lblDomain.TabIndex = 82;
            this.lblDomain.Text = " ";
            // 
            // lblDomainValue
            // 
            this.lblDomainValue.AutoSize = true;
            this.lblDomainValue.Font = new System.Drawing.Font("Arial", 14F);
            this.lblDomainValue.Location = new System.Drawing.Point(50, 583);
            this.lblDomainValue.Name = "lblDomainValue";
            this.lblDomainValue.Size = new System.Drawing.Size(174, 22);
            this.lblDomainValue.TabIndex = 81;
            this.lblDomainValue.Text = "Область значений:";
            // 
            // lblZeros
            // 
            this.lblZeros.AutoSize = true;
            this.lblZeros.Font = new System.Drawing.Font("Arial", 14F);
            this.lblZeros.Location = new System.Drawing.Point(191, 493);
            this.lblZeros.Name = "lblZeros";
            this.lblZeros.Size = new System.Drawing.Size(15, 22);
            this.lblZeros.TabIndex = 80;
            this.lblZeros.Text = " ";
            // 
            // lblZerosValue
            // 
            this.lblZerosValue.AutoSize = true;
            this.lblZerosValue.Font = new System.Drawing.Font("Arial", 14F);
            this.lblZerosValue.Location = new System.Drawing.Point(49, 493);
            this.lblZerosValue.Name = "lblZerosValue";
            this.lblZerosValue.Size = new System.Drawing.Size(136, 22);
            this.lblZerosValue.TabIndex = 79;
            this.lblZerosValue.Text = "Нули функции:";
            // 
            // lblExtrema
            // 
            this.lblExtrema.AutoSize = true;
            this.lblExtrema.Font = new System.Drawing.Font("Arial", 14F);
            this.lblExtrema.Location = new System.Drawing.Point(183, 542);
            this.lblExtrema.Name = "lblExtrema";
            this.lblExtrema.Size = new System.Drawing.Size(15, 22);
            this.lblExtrema.TabIndex = 78;
            this.lblExtrema.Text = " ";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Arial", 14F);
            this.lblPeriod.Location = new System.Drawing.Point(202, 406);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(15, 22);
            this.lblPeriod.TabIndex = 77;
            this.lblPeriod.Text = " ";
            // 
            // lblPeriodValue
            // 
            this.lblPeriodValue.AutoSize = true;
            this.lblPeriodValue.Font = new System.Drawing.Font("Arial", 14F);
            this.lblPeriodValue.Location = new System.Drawing.Point(49, 406);
            this.lblPeriodValue.Name = "lblPeriodValue";
            this.lblPeriodValue.Size = new System.Drawing.Size(147, 22);
            this.lblPeriodValue.TabIndex = 76;
            this.lblPeriodValue.Text = "Периодичность";
            // 
            // labelParity
            // 
            this.labelParity.AutoSize = true;
            this.labelParity.Font = new System.Drawing.Font("Arial", 14F);
            this.labelParity.Location = new System.Drawing.Point(224, 449);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(15, 22);
            this.labelParity.TabIndex = 75;
            this.labelParity.Text = " ";
            // 
            // lblMonot
            // 
            this.lblMonot.AutoSize = true;
            this.lblMonot.Font = new System.Drawing.Font("Arial", 14F);
            this.lblMonot.Location = new System.Drawing.Point(194, 366);
            this.lblMonot.Name = "lblMonot";
            this.lblMonot.Size = new System.Drawing.Size(15, 22);
            this.lblMonot.TabIndex = 74;
            this.lblMonot.Text = " ";
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Font = new System.Drawing.Font("Arial", 14F);
            this.lblRange.Location = new System.Drawing.Point(268, 324);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(15, 22);
            this.lblRange.TabIndex = 73;
            this.lblRange.Text = " ";
            // 
            // labelExtremaValue
            // 
            this.labelExtremaValue.AutoSize = true;
            this.labelExtremaValue.Font = new System.Drawing.Font("Arial", 14F);
            this.labelExtremaValue.Location = new System.Drawing.Point(50, 542);
            this.labelExtremaValue.Name = "labelExtremaValue";
            this.labelExtremaValue.Size = new System.Drawing.Size(126, 22);
            this.labelExtremaValue.TabIndex = 72;
            this.labelExtremaValue.Text = "Экстремумы:";
            // 
            // labelParityValue
            // 
            this.labelParityValue.AutoSize = true;
            this.labelParityValue.Font = new System.Drawing.Font("Arial", 14F);
            this.labelParityValue.Location = new System.Drawing.Point(50, 449);
            this.labelParityValue.Name = "labelParityValue";
            this.labelParityValue.Size = new System.Drawing.Size(161, 22);
            this.labelParityValue.TabIndex = 71;
            this.labelParityValue.Text = "Чётная/нечётная:";
            // 
            // labelMonotValue
            // 
            this.labelMonotValue.AutoSize = true;
            this.labelMonotValue.Font = new System.Drawing.Font("Arial", 14F);
            this.labelMonotValue.Location = new System.Drawing.Point(48, 366);
            this.labelMonotValue.Name = "labelMonotValue";
            this.labelMonotValue.Size = new System.Drawing.Size(141, 22);
            this.labelMonotValue.TabIndex = 70;
            this.labelMonotValue.Text = "Монотонность:";
            // 
            // lblRangeValue
            // 
            this.lblRangeValue.AutoSize = true;
            this.lblRangeValue.Font = new System.Drawing.Font("Arial", 14F);
            this.lblRangeValue.Location = new System.Drawing.Point(50, 324);
            this.lblRangeValue.Name = "lblRangeValue";
            this.lblRangeValue.Size = new System.Drawing.Size(208, 22);
            this.lblRangeValue.TabIndex = 69;
            this.lblRangeValue.Text = "Область определения:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 14F);
            this.button1.Location = new System.Drawing.Point(1206, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 53);
            this.button1.TabIndex = 83;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 646);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDomain);
            this.Controls.Add(this.lblDomainValue);
            this.Controls.Add(this.lblZeros);
            this.Controls.Add(this.lblZerosValue);
            this.Controls.Add(this.lblExtrema);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.lblPeriodValue);
            this.Controls.Add(this.labelParity);
            this.Controls.Add(this.lblMonot);
            this.Controls.Add(this.lblRange);
            this.Controls.Add(this.labelExtremaValue);
            this.Controls.Add(this.labelParityValue);
            this.Controls.Add(this.labelMonotValue);
            this.Controls.Add(this.lblRangeValue);
            this.Controls.Add(this.lblFormula);
            this.Controls.Add(this.txtPhi);
            this.Controls.Add(this.lblPhi);
            this.Controls.Add(this.txtOmega);
            this.Controls.Add(this.txtAmplitude);
            this.Controls.Add(this.lblOmega);
            this.Controls.Add(this.lblAmplitude);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblK);
            this.Controls.Add(this.btnResearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.chartGraph);
            this.Location = new System.Drawing.Point(10, 110);
            this.Name = "Form2";
            this.Text = "Исследование математической функции";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnResearch;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.TextBox txtPhi;
        private System.Windows.Forms.Label lblPhi;
        private System.Windows.Forms.TextBox txtOmega;
        private System.Windows.Forms.TextBox txtAmplitude;
        private System.Windows.Forms.Label lblOmega;
        private System.Windows.Forms.Label lblAmplitude;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.Label lblDomainValue;
        private System.Windows.Forms.Label lblZeros;
        private System.Windows.Forms.Label lblZerosValue;
        private System.Windows.Forms.Label lblExtrema;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblPeriodValue;
        private System.Windows.Forms.Label labelParity;
        private System.Windows.Forms.Label lblMonot;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.Label labelExtremaValue;
        private System.Windows.Forms.Label labelParityValue;
        private System.Windows.Forms.Label labelMonotValue;
        private System.Windows.Forms.Label lblRangeValue;
        private System.Windows.Forms.Button button1;
    }
}