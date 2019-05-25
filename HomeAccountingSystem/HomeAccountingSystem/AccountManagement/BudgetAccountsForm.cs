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
    public partial class BudgetAccountsForm : Form
    {
        public BudgetAccountsForm()
        {
            InitializeComponent();
        }
        // 选中行
        private int m_selectRow = 0;

        private void BudgetAccountsForm_Load(object sender, EventArgs e)
        {
            loadComboBoxSelectDate();
            loadDataList();
        }

        private void loadComboBoxSelectDate()
        {
            int month = DateTime.Today.Month;
            this.comboBoxExTIME.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                if (i == month)
                {
                    this.comboBoxExTIME.Items.Add( "本月");
                }
                else
                {
                    this.comboBoxExTIME.Items.Add(i + "月");
                }
            }
            this.comboBoxExTIME.SelectedIndex = month-1;
        }

        private void loadDataList()
        {
            this.gridControlDataList.DataSource = BudgetAccountsManager.Instance.getBudgetAccountsData(this.dateTimeInputStartDate.Value, this.dateTimeInputEndDate.Value);
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
            if (m_selectRow < this.gridViewDataList.RowCount)
            {
                this.gridViewDataList.SelectAll();
                this.gridViewDataList.FocusedRowHandle = m_selectRow;
            }
        }

        private void comboBoxExTIME_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sValue = comboBoxExTIME.SelectedItem.ToString();
            sValue = sValue.Remove(sValue.Length-1);
            int month = 0;
            if (sValue != "本")
            {
                month = Convert.ToInt32(sValue);
                dateTimeInputStartDate.Value = DateTime.Parse(DateTime.Today.ToString("yyyy-" + month + "-01"));
                dateTimeInputEndDate.Value = DateTime.Parse(dateTimeInputStartDate.Value.AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd 23:59:59"));
            }
            else
            {
                dateTimeInputStartDate.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01"));
                dateTimeInputEndDate.Value = DateTime.Parse(dateTimeInputStartDate.Value.AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd 23:59:59"));
            }
        }

        private void buttonXAdd_Click(object sender, EventArgs e)
        {
            EditBudgetAccountsForm form = new EditBudgetAccountsForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                this.loadDataList();
            }
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
            jt_ys_zm yszmModel = BudgetAccountsManager.Instance.GetModel(pk);
            EditBudgetAccountsForm form = new EditBudgetAccountsForm();
            form.m_yszmModel = yszmModel;
            form.m_budgetAccountsForm = this;
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                this.loadDataList();
            }
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
            bool isSuccess = BudgetAccountsManager.Instance.Delete(pk);
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

        private void gridControlDataList_DoubleClick(object sender, EventArgs e)
        {
            loadDataList();
        }
    }
}
