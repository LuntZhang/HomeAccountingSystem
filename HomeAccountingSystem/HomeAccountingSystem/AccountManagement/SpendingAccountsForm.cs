using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HomeAccountingSystem.BLL;
using HomeAccountingSystem.Utility;

namespace HomeAccountingSystem.AccountManagement
{
    public partial class SpendingAccountsForm : Form
    {
        public SpendingAccountsForm()
        {
            InitializeComponent();
        }

        private void SpendingAccountsForm_Load(object sender, EventArgs e)
        {
            this.comboBoxExTIME.SelectedIndex = 0;
            loadCombox();
            loadData();
        }

        private void loadCombox()
        {
            // 消费用途下拉
            DataSet dataSet = ExpendTypeManager.Instance.GetList("");
            if (dataSet == null || dataSet.Tables.Count == 0)
            {
                MessageBoxFunction.showWarningMessageBox("没有支出类型，请先去创建支出类型！");
                base.Close();
                return;
            }
            DataTable dataTable = dataSet.Tables[0];
            if (dataTable == null && dataTable.Rows.Count == 0)
            {
                
                MessageBoxFunction.showWarningMessageBox("没有支出类型，请先去创建支出类型！");
                base.Close();
                return;
            }
            DataRow dr = dataTable.NewRow();
            dr["v_zclx_name"] = "全部";
            dr["pk"] = -1;
            dataTable.Rows.Add(dr);
            this.comboBoxExType.Items.Clear();
            this.comboBoxExType.DataSource = dataTable;
            this.comboBoxExType.DisplayMember = "v_zclx_name";
            this.comboBoxExType.ValueMember = "pk";

            this.comboBoxExType.SelectedValue = -1;
        }

        private void loadData()
        {
            this.gridControlDataList.DataSource = ExpendAccountsManager.Instance.getExpendAccountsData(this.dateTimeInputStartDate.Value,this.dateTimeInputEndDate.Value);
        }

        private void buttonXAdd_Click(object sender, EventArgs e)
        {
            EditSpendingAccountsForm form = new EditSpendingAccountsForm();
            form.ShowDialog();
        }

        private void comboBoxExTIME_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sValue = comboBoxExTIME.SelectedItem.ToString();
            switch (sValue)
            {
                case "全部":
                    dateTimeInputStartDate.Value = DateTime.Parse("2000-01-01"); ;
                    dateTimeInputEndDate.Value = DateTime.Now;
                    break;
                case "今天":
                    dateTimeInputStartDate.Value = DateTime.Today;
                    dateTimeInputEndDate.Value = DateTime.Now;
                    break;
                case "昨天":
                    dateTimeInputStartDate.Value = DateTime.Parse(DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd"));
                    dateTimeInputEndDate.Value = DateTime.Parse(DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd 23:59:59.9999"));
                    break;
                case "前天":
                    dateTimeInputStartDate.Value = DateTime.Parse(DateTime.Now.AddDays(-2).ToString("yyyy-MM-dd"));
                    dateTimeInputEndDate.Value = DateTime.Parse(DateTime.Now.AddDays(-2).ToString("yyyy-MM-dd 23:59:59.9999"));
                    break;
                case "本周":
                    dateTimeInputStartDate.Value = DateTime.Parse(DateTime.Now.AddDays(1 - Convert.ToInt32(DateTime.Now.DayOfWeek.ToString("d"))).ToString("yyyy-MM-dd"));
                    dateTimeInputEndDate.Value = DateTime.Now;
                    break;
                case "上周":
                    dateTimeInputStartDate.Value = DateTime.Parse(DateTime.Now.AddDays(Convert.ToDouble((1 - Convert.ToInt16(DateTime.Now.DayOfWeek))) - 7).ToString("yyyy-MM-dd"));
                    dateTimeInputEndDate.Value = DateTime.Parse(DateTime.Now.AddDays(Convert.ToDouble(0 - Convert.ToInt16(DateTime.Now.DayOfWeek))).ToString("yyyy-MM-dd 23:59:59.9999"));
                    break;
                case "本月":
                    dateTimeInputStartDate.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01"));
                    dateTimeInputEndDate.Value = DateTime.Now;
                    break;
                case "本年":
                    dateTimeInputStartDate.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-01-01"));
                    dateTimeInputEndDate.Value = DateTime.Now;
                    break;
                default:
                    break;
            }
        }

        
    }
}
