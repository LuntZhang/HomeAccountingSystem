namespace HomeAccountingSystem.MainUserControl
{
    partial class ControlChartUserControl
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
            System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn2 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelAll = new System.Windows.Forms.Panel();
            this.panelIncome = new System.Windows.Forms.Panel();
            this.chartExpendData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTime = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelBeforeOneDay = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelAll.SuspendLayout();
            this.panelIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpendData)).BeginInit();
            this.panelTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAll
            // 
            this.panelAll.Controls.Add(this.panelIncome);
            this.panelAll.Controls.Add(this.panelTime);
            this.panelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAll.Location = new System.Drawing.Point(0, 0);
            this.panelAll.Name = "panelAll";
            this.panelAll.Padding = new System.Windows.Forms.Padding(10);
            this.panelAll.Size = new System.Drawing.Size(560, 250);
            this.panelAll.TabIndex = 1;
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
            chartArea1.Name = "ChartArea1";
            this.chartExpendData.ChartAreas.Add(chartArea1);
            this.chartExpendData.Dock = System.Windows.Forms.DockStyle.Fill;
            legendCellColumn1.Name = "Column1";
            legendCellColumn1.Text = "#VALX";
            legendCellColumn2.Name = "Column2";
            legendCellColumn2.Text = "#VAL{C}";
            legend1.CellColumns.Add(legendCellColumn1);
            legend1.CellColumns.Add(legendCellColumn2);
            legend1.Name = "LegendMoney";
            this.chartExpendData.Legends.Add(legend1);
            this.chartExpendData.Location = new System.Drawing.Point(0, 0);
            this.chartExpendData.Name = "chartExpendData";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsXValueIndexed = true;
            series1.Label = "#VALX #PERCENT{P}";
            series1.Legend = "LegendMoney";
            series1.Name = "Series1";
            this.chartExpendData.Series.Add(series1);
            this.chartExpendData.Size = new System.Drawing.Size(540, 196);
            this.chartExpendData.TabIndex = 0;
            this.chartExpendData.Text = "消费分析";
            // 
            // panelTime
            // 
            this.panelTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.panelTime.Controls.Add(this.comboBox1);
            this.panelTime.Controls.Add(this.pictureBox3);
            this.panelTime.Controls.Add(this.labelBeforeOneDay);
            this.panelTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTime.Location = new System.Drawing.Point(10, 10);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(540, 34);
            this.panelTime.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(485, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(52, 24);
            this.comboBox1.TabIndex = 5;
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
            this.labelBeforeOneDay.Text = "消费分析";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::HomeAccountingSystem.Properties.Resources.会员消费分析_2_;
            this.pictureBox3.Location = new System.Drawing.Point(3, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // ControlChartUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panelAll);
            this.Name = "ControlChartUserControl";
            this.Size = new System.Drawing.Size(560, 250);
            this.Load += new System.EventHandler(this.ControlChartUserControl_Load);
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
        private System.Windows.Forms.Panel panelTime;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelBeforeOneDay;
        private System.Windows.Forms.Panel panelIncome;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExpendData;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
