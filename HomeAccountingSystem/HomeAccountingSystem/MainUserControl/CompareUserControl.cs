using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeAccountingSystem.BLL;
using HomeAccountingSystem.Utility;

namespace HomeAccountingSystem.MainUserControl
{
    public partial class CompareUserControl : UserControl
    {
        public CompareUserControl()
        {
            if (!this.DesignMode)
            {
                InitializeComponent();
            }
        }

        private DateTime m_startTime = Convert.ToDateTime(DateTime.Today.ToString("yyyy-MM-01"));
        private DateTime m_endTime = DateTime.Now;

        private void CompareUserControl_Load(object sender, EventArgs e)
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
        private void loadData()
        {
            m_startTime = this.dateTimeInputStartDate.Value;
            m_endTime = this.dateTimeInputEndDate.Value;

            decimal expendTotalMoney = 0.00M;
            decimal IncomeTotalMoney = 0.00M;
            DataTable dt = null;
            // 支出
            dt = ExpendAccountsManager.Instance.getSumData(m_startTime, m_endTime);
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    if(!string.IsNullOrEmpty(item["f_zc_money"].ToString()))
                    {
                        expendTotalMoney = Convert.ToDecimal(item["f_zc_money"].ToString());
                    }
                }
            }
            //  收入
            dt = IncomeAccountsManager.Instance.getSumData(m_startTime, m_endTime);
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    if (!string.IsNullOrEmpty(item["f_sr_money"].ToString()))
                    {
                        IncomeTotalMoney = Convert.ToDecimal(item["f_sr_money"].ToString());
                    }
                }
            }
            this.labelExpendMoney.Text = expendTotalMoney.ToString("0.00") + " 元";
            this.labelIncomeMoney.Text = IncomeTotalMoney.ToString("0.00") + " 元";
            // 比较值计算
            comparisonValue(expendTotalMoney, IncomeTotalMoney);
        }

        private void comparisonValue(decimal expendTotalMoney,decimal IncomeTotalMoney)
        {
            decimal comparisonMoney = 0.00M;
            // 消费大于收入
            if (expendTotalMoney > IncomeTotalMoney)
            {
                comparisonMoney = expendTotalMoney - IncomeTotalMoney;
                this.pictureBoxDownArrow.Visible = true;
                this.pictureBoxBalance.Visible = false;
                this.pictureBoxUpArrow.Visible = false;
            }
            // 收入大于消费
            else if(expendTotalMoney < IncomeTotalMoney)
            {
                comparisonMoney = IncomeTotalMoney- expendTotalMoney ;
                this.pictureBoxDownArrow.Visible = false;
                this.pictureBoxBalance.Visible = false;
                this.pictureBoxUpArrow.Visible = true;
            }
            else
            {
                comparisonMoney = IncomeTotalMoney - expendTotalMoney;
                this.pictureBoxDownArrow.Visible = false;
                this.pictureBoxBalance.Visible = true;
                this.pictureBoxUpArrow.Visible = false;
            }
            this.labelCompareMoney.Text = comparisonMoney.ToString("0.00") + " 元";
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(this.dateTimeInputStartDate.Value > this.dateTimeInputEndDate.Value)
            {
                MessageBoxFunction.showWarningMessageBox("开始时间不能大于结束时间！");
                return;
            }
            loadData();
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

            this.dateTimeInputStartDate.Value = m_startTime;
            this.dateTimeInputEndDate.Value = m_endTime;
            loadData();
        }
    }
}
