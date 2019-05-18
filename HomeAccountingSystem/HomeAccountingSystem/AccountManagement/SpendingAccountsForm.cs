using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HomeAccountingSystem.BLL;
using HomeAccountingSystem.Model;
using HomeAccountingSystem.Utility;

namespace HomeAccountingSystem.AccountManagement
{
    public partial class SpendingAccountsForm : Form
    {
        public SpendingAccountsForm()
        {
            InitializeComponent();
        }

        // 选中行
        private int m_selectRow = 0;

        private void SpendingAccountsForm_Load(object sender, EventArgs e)
        {
            this.comboBoxExTIME.SelectedIndex = 0;
            loadCombox();
            loadDataList();
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

        private void loadDataList()
        {
            string ssss = this.comboBoxExType.SelectedValue.ToString();
            this.gridControlDataList.DataSource = ExpendAccountsManager.Instance.getExpendAccountsData(this.dateTimeInputStartDate.Value,this.dateTimeInputEndDate.Value,this.textBoxName.Text.Trim(),this.comboBoxExType.SelectedValue.ToString());
            this.selectRow();
        }

        /// <summary>
        /// 选中行
        /// </summary>
        public void selectRow()
        {
            if (this.gridViewDataList.RowCount == 0)
            {
                return;
            }
            if(m_selectRow< this.gridViewDataList.RowCount)
            {
                this.gridViewDataList.FocusedRowHandle = m_selectRow;
            } 
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

        private void buttonXAdd_Click(object sender, EventArgs e)
        {
            EditSpendingAccountsForm form = new EditSpendingAccountsForm();
            form.ShowDialog();
        }

        private void buttonXModify_Click(object sender, EventArgs e)
        {
            if (this.gridViewDataList.SelectedRowsCount == 0)
            {
                MessageBox.Show("请选择一条数据！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            m_selectRow = this.gridViewDataList.FocusedRowHandle;
            // 取出pk
            int selectRow = this.gridViewDataList.GetSelectedRows()[0];
            int pk = Convert.ToInt32(this.gridViewDataList.GetRowCellValue(selectRow, "pk").ToString());
            jt_zc_zm zczmModel = ExpendAccountsManager.Instance.GetModel(pk);
            EditSpendingAccountsForm form = new EditSpendingAccountsForm();
            form.m_zczmModel = zczmModel;
            form.m_spendingAccountsForm = this;
            form.ShowDialog();

            this.loadDataList();
        }

        private void buttonXDelete_Click(object sender, EventArgs e)
        {
            if (this.gridViewDataList.SelectedRowsCount == 0)
            {
                MessageBox.Show("请选择一条数据！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!MessageBoxFunction.showQuestionMessageBox("确定要删除这条数据？"))
            {
                return;
            }

            // 取出pk
            int selectRow = this.gridViewDataList.GetSelectedRows()[0];
            int pk = Convert.ToInt32(this.gridViewDataList.GetRowCellValue(selectRow, "pk").ToString());
            bool isSuccess = ExpendAccountsManager.Instance.Delete(pk);
            if (isSuccess)
            {
                MessageBox.Show("删除成功！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.loadDataList();
            }
            else
            {
                MessageBox.Show("删除失败！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonXRefresh_Click(object sender, EventArgs e)
        {
            loadDataList();
        }

        private void buttonXExit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void buttonXSearch_Click(object sender, EventArgs e)
        {
            loadDataList();
        }
    }
}
