namespace HomeAccountingSystem.MainUserControl
{
    partial class BudgetUserControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn1 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.panelAll = new System.Windows.Forms.Panel();
            this.panelIncome = new System.Windows.Forms.Panel();
            this.chartExpendData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTime = new System.Windows.Forms.Panel();
            this.comboBoxExTIME = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelBeforeOneDay = new System.Windows.Forms.Label();
            this.panelAll.SuspendLayout();
            this.panelIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpendData)).BeginInit();
            this.panelTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAll
            // 
            this.panelAll.BackColor = System.Drawing.Color.Transparent;
            this.panelAll.Controls.Add(this.panelIncome);
            this.panelAll.Controls.Add(this.panelTime);
            this.panelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAll.Location = new System.Drawing.Point(0, 0);
            this.panelAll.Name = "panelAll";
            this.panelAll.Padding = new System.Windows.Forms.Padding(10);
            this.panelAll.Size = new System.Drawing.Size(560, 250);
            this.panelAll.TabIndex = 2;
            // 
            // panelIncome
            // 
            this.panelIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.panelIncome.Controls.Add(this.chartExpendData);
            this.panelIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIncome.Location = new System.Drawing.Point(10, 44);
            this.panelIncome.Name = "panelIncome";
            this.panelIncome.Size = new System.Drawing.Size(540, 196);
            this.panelIncome.TabIndex = 1;
            // 
            // chartExpendData
            // 
            this.chartExpendData.BorderlineColor = System.Drawing.Color.DimGray;
            this.chartExpendData.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            this.chartExpendData.BorderlineWidth = 0;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 94F;
            chartArea1.Position.Width = 86.17625F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 3F;
            this.chartExpendData.ChartAreas.Add(chartArea1);
            this.chartExpendData.Cursor = System.Windows.Forms.Cursors.Default;
            this.chartExpendData.Dock = System.Windows.Forms.DockStyle.Fill;
            legendCellColumn1.Name = "Column1";
            legendCellColumn1.Text = "";
            legend1.CellColumns.Add(legendCellColumn1);
            legend1.Name = "LegendMoney";
            this.chartExpendData.Legends.Add(legend1);
            this.chartExpendData.Location = new System.Drawing.Point(0, 0);
            this.chartExpendData.Name = "chartExpendData";
            this.chartExpendData.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chartExpendData.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Cyan,
        System.Drawing.Color.Red};
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Color = System.Drawing.Color.Silver;
            series1.EmptyPointStyle.Color = System.Drawing.Color.Transparent;
            series1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.Label = "#VALX #VAL{C}";
            series1.Legend = "LegendMoney";
            series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series1.MarkerSize = 2;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            this.chartExpendData.Series.Add(series1);
            this.chartExpendData.Size = new System.Drawing.Size(540, 196);
            this.chartExpendData.TabIndex = 0;
            this.chartExpendData.Text = "消费分析";
            // 
            // panelTime
            // 
            this.panelTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.panelTime.Controls.Add(this.comboBoxExTIME);
            this.panelTime.Controls.Add(this.pictureBox3);
            this.panelTime.Controls.Add(this.labelBeforeOneDay);
            this.panelTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTime.Location = new System.Drawing.Point(10, 10);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(540, 34);
            this.panelTime.TabIndex = 1;
            // 
            // comboBoxExTIME
            // 
            this.comboBoxExTIME.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxExTIME.Font = new System.Drawing.Font("宋体", 12F);
            this.comboBoxExTIME.FormattingEnabled = true;
            this.comboBoxExTIME.Location = new System.Drawing.Point(461, 5);
            this.comboBoxExTIME.Name = "comboBoxExTIME";
            this.comboBoxExTIME.Size = new System.Drawing.Size(76, 24);
            this.comboBoxExTIME.TabIndex = 5;
            this.comboBoxExTIME.SelectedIndexChanged += new System.EventHandler(this.comboBoxExTIME_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::HomeAccountingSystem.Properties.Resources.预算_3_;
            this.pictureBox3.Location = new System.Drawing.Point(3, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // labelBeforeOneDay
            // 
            this.labelBeforeOneDay.AutoSize = true;
            this.labelBeforeOneDay.Font = new System.Drawing.Font("宋体", 12F);
            this.labelBeforeOneDay.ForeColor = System.Drawing.Color.White;
            this.labelBeforeOneDay.Location = new System.Drawing.Point(33, 9);
            this.labelBeforeOneDay.Name = "labelBeforeOneDay";
            this.labelBeforeOneDay.Size = new System.Drawing.Size(72, 16);
            this.labelBeforeOneDay.TabIndex = 3;
            this.labelBeforeOneDay.Text = "预算简报";
            // 
            // BudgetUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelAll);
            this.Name = "BudgetUserControl";
            this.Size = new System.Drawing.Size(560, 250);
            this.Load += new System.EventHandler(this.BudgetUserControl_Load);
            this.panelAll.ResumeLayout(false);
            this.panelIncome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartExpendData)).EndInit();
            this.panelTime.ResumeLayout(false);
            this.panelTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAll;
        private System.Windows.Forms.Panel panelIncome;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExpendData;
        private System.Windows.Forms.Panel panelTime;
        private System.Windows.Forms.ComboBox comboBoxExTIME;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelBeforeOneDay;
    }
}
