﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeAccountingSystem.BLL;
using System.Windows.Forms.DataVisualization.Charting;

namespace HomeAccountingSystem.MainUserControl
{
    public partial class BudgetUserControl : UserControl
    {
        public BudgetUserControl()
        {
            if (!this.DesignMode)
            {
                InitializeComponent();
            }
        }
        private DateTime m_startTime = Convert.ToDateTime(DateTime.Today.ToString("yyyy-MM-01"));
        private DateTime m_endTime = DateTime.Now;

        private void BudgetUserControl_Load(object sender, EventArgs e)
        {
            loadComboBoxSelectDate();
        }

        private void loadComboBoxSelectDate()
        {
            int month = DateTime.Today.Month;
            this.comboBoxExTIME.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                if (i == month)
                {
                    this.comboBoxExTIME.Items.Add("本月");
                }
                else
                {
                    this.comboBoxExTIME.Items.Add(i + "月");
                }
            }
            this.comboBoxExTIME.SelectedIndex = month - 1;
        }

        private void loadBarChart()
        {
            // 消费用途
            List<string> xData = new List<string>();
            // 所占总消费比率
            List<decimal> yData = new List<decimal>();

            DataTable dt = BudgetAccountsManager.Instance.getBudgetBriefingData(m_startTime, m_endTime);
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    xData.Add(this.comboBoxExTIME.SelectedItem.ToString()+ item["zc"].ToString());
                    yData.Add(Convert.ToDecimal(decimal.Parse(item["f_money_all"].ToString()).ToString("0.00")));
                   
                }
                //this.chartExpendData.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧 
                //this.chartExpendData.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。 

                this.chartExpendData.Series[0].Points.DataBindXY(xData, yData);
                this.chartExpendData.Series[0].Points[0].Color = Color.Red;
                this.chartExpendData.Series[0].Points[1].Color = Color.Yellow;
                this.chartExpendData.Series[0]["PointWidth"] = "0.5";


            }
            else
            {
                xData.Add("无数据");
                yData.Add(1);
                this.chartExpendData.Series[0].Points.DataBindXY(xData, yData);
                this.chartExpendData.Series[0].Label = "#VALX";
                this.chartExpendData.Legends[0].CellColumns[1].Text = "￥0.00";

            }

        }

        private void comboBoxExTIME_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sValue = comboBoxExTIME.SelectedItem.ToString();
            sValue = sValue.Remove(sValue.Length - 1);
            int month = 0;
            if (sValue != "本")
            {
                month = Convert.ToInt32(sValue);
                m_startTime = DateTime.Parse(DateTime.Today.ToString("yyyy-" + month + "-01"));
                m_endTime = DateTime.Parse(m_startTime.AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd 23:59:59"));
            }
            else
            {
                m_startTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01"));
                m_endTime = DateTime.Parse(m_startTime.AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd 23:59:59"));
            }

            loadBarChart();
        }
    }
}
