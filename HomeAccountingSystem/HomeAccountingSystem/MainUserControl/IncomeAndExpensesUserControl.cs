using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeAccountingSystem.Model;
using HomeAccountingSystem.BLL;
using HomeAccountingSystem.AccountManagement;

namespace HomeAccountingSystem.MainUserControl
{
    public enum Day
    {
        BeforeOneDay = -1,
        YesterDay = 0,
        ToDay = 1
    }
    public partial class IncomeAndExpensesUserControl : UserControl
    {
        public IncomeAndExpensesUserControl()
        {
            if (!this.DesignMode)
            {
                InitializeComponent();
            }
        }

        // 当前是哪天的账目
        private int m_tallyDay = 1;

        private void IncomeAndExpensesUserControl_Load(object sender, EventArgs e)
        {
            getTallyTime();
        }

        private void labelDay_Click(object sender, EventArgs e)
        {
            // 获取按钮
            Label label  = sender as Label;
            if (label == null)
            {
                return;
            }
            string strLabelName = label.Name.ToString().Trim();

            // 循环不符合的变回原颜色
            Font fontDay = null;
            for (int i = 0; i < this.panelTime.Controls.Count; i++)
            {
                Label labelDay = this.panelTime.Controls[i] as Label;
                if (labelDay != null&& labelDay.Name != strLabelName)
                {
                    if (labelDay.Text == "记一笔")
                    {
                        continue;
                    }
                    labelDay.ForeColor = Color.White;
                    fontDay = new Font("宋体", 16, FontStyle.Bold);//设置字体的样式（宋体，9号字，有下划线），括号里可根据自己需要修改
                    labelDay.Font = fontDay;
                }
            }
            // 设置点中的字体颜色
            label.ForeColor = Color.Red;
            Font f = new Font("宋体", 16, FontStyle.Bold | FontStyle.Underline);
            label.Font = f;

            switch (strLabelName)
            {
                case "labelBeforeOneDay":
                    m_tallyDay = (int)Day.BeforeOneDay;
                    break;
                case "labelYesterday":
                    m_tallyDay = (int)Day.YesterDay;
                    break;
                case "labelToday":
                    m_tallyDay = (int)Day.ToDay;
                    break;
                default:
                    break;
            }

            getTallyTime();

        }

        private void getTallyTime()
        {
            DateTime startTime = DateTime.Today;
            DateTime endTime = DateTime.Now;
            switch (m_tallyDay)
            {
                case -1:
                    startTime = DateTime.Today.AddDays(-2);
                    endTime = Convert.ToDateTime(DateTime.Today.AddDays(-2).ToString("yyyy-MM-dd 23:59:59.999"));
                    break;
                case 0:
                    startTime = DateTime.Today.AddDays(-1);
                    endTime = Convert.ToDateTime(DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd 23:59:59.999"));
                    break;
                case 1:
                    startTime = DateTime.Today;
                    endTime = Convert.ToDateTime(DateTime.Today.ToString("yyyy-MM-dd 23:59:59.999"));
                    break;
                default:
                    break;
            }
            getExpendTallyInfo(startTime, endTime);
            getIncomeTallyInfo(startTime, endTime);
        }

        private void getExpendTallyInfo(DateTime startTime,DateTime endTime)
        {
            decimal expendTotalMoney = 0.00M;
            string strExpendType = "今天还没记账！";
            string strCount = "";
            // 取出指定时间的账目
            string strTime = string.Format("t_xf_time>='{0}' and t_xf_time<='{1}'", startTime, endTime);
            List<jt_zc_zm> zczmList = ExpendAccountsManager.Instance.GetModelList(strTime);
            if(zczmList == null || zczmList.Count == 0)
            {
                this.linkLabelExpendMoney.Text = expendTotalMoney.ToString("0.00");
                this.labelExpendInfo.Text = strExpendType + strCount;
                return;
            }
            // 统计
            expendTotalMoney = 0.00M;
            strExpendType = "";
            strCount = "  共" + zczmList.Count + "笔";
            foreach (jt_zc_zm item in zczmList)
            {
                expendTotalMoney += item.f_zc_money;
                strExpendType += item.v_zclx_name+"/";
            }
            strExpendType = strExpendType.Remove(strExpendType.Length-1);
            if (strExpendType.Length > 20)
            {
                strExpendType = strExpendType.Remove(20)+"...";
            }

            this.linkLabelExpendMoney.Text = expendTotalMoney.ToString("0.00");
            this.labelExpendInfo.Text = strExpendType + strCount;
        }

        private void getIncomeTallyInfo(DateTime startTime, DateTime endTime)
        {
            decimal incomeTotalMoney = 0.00M;
            string strIncomeType = "今天还没记账！";
            string strCount = "";
            // 取出指定时间的账目
            string strTime = string.Format("t_xf_time>='{0}' and t_xf_time<='{1}'", startTime, endTime);
            List<jt_sr_zm> srzmList = IncomeAccountsManager.Instance.GetModelList(strTime);
            if (srzmList == null || srzmList.Count == 0)
            {
                this.linkLabelIncomeMoney.Text = incomeTotalMoney.ToString("0.00");
                this.labelIncomeInfo.Text = strIncomeType + strCount;
                return;
            }
            // 统计
            incomeTotalMoney = 0.00M;
            strIncomeType = "";
            strCount = "  共" + srzmList.Count + "笔";
            foreach (jt_sr_zm item in srzmList)
            {
                incomeTotalMoney += item.f_sr_money;
                strIncomeType += item.v_srlx_name + "/";
            }
            strIncomeType = strIncomeType.Remove(strIncomeType.Length - 1);
            if (strIncomeType.Length > 20)
            {
                strIncomeType = strIncomeType.Remove(20) + "...";
            }

            this.linkLabelIncomeMoney.Text = incomeTotalMoney.ToString("0.00");
            this.labelIncomeInfo.Text = strIncomeType + strCount;
        }

        private void labelExpendWriteABill_Click(object sender, EventArgs e)
        {
            EditSpendingAccountsForm form = new EditSpendingAccountsForm();
            form.ShowDialog();
            getTallyTime();
        }

        private void labelIncomeWriteABill_Click(object sender, EventArgs e)
        {
            EditIncomeAccountsForm form = new EditIncomeAccountsForm();
            form.ShowDialog();
            getTallyTime();
        }

        private void pictureBoxExpend_Click(object sender, EventArgs e)
        {
            EditSpendingAccountsForm form = new EditSpendingAccountsForm();
            form.ShowDialog();
            getTallyTime();
        }

        private void pictureBoxIncome_Click(object sender, EventArgs e)
        {
            EditIncomeAccountsForm form = new EditIncomeAccountsForm();
            form.ShowDialog();
            getTallyTime();
        }

        private void labelWriteABill_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.FromArgb(77, 176, 242);
        }

        private void labelWriteABill_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.Blue;
        }

        private void linkLabelExpendMoney_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SpendingAccountsForm formSpend = new SpendingAccountsForm();
            formSpend.ShowDialog();
        }

        private void linkLabelIncomeMoney_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IncomeAccountsForm formIncome = new IncomeAccountsForm();
            formIncome.ShowDialog();
        }
    }
}
