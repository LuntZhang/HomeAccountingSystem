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
    public partial class EditBudgetAccountsForm : Form
    {
        public EditBudgetAccountsForm()
        {
            InitializeComponent();
        }

        // 预算对象
        public jt_ys_zm m_yszmModel = null;

        private void EditBudgetAccountsForm_Load(object sender, EventArgs e)
        {
            this.comboBoxDate.SelectedIndex = 0;
            loadPage();
        }

        /// <summary>
        /// 加载页面
        /// </summary>
        private void loadPage()
        {
            if (m_yszmModel == null)
            {
                this.Text = "添加预算账目";
                // 账目预算信息
                this.textBoxNo.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
                this.textBoxName.Text = "";
                this.decimalTextBoxMoney.EditValue = 0.00M;
                this.dateTimeStart.Value = Convert.ToDateTime(DateTime.Today.ToString("yyyy-MM-01"));
                this.dateTimeEnd.Value = Convert.ToDateTime(this.dateTimeStart.Value.AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd"));
                this.textBoxUserName.Text = LoginAccountManager.Instance.getLoginUserModel().v_yh_name;
                this.dateTimeTallyDate.Value = DateTime.Now;
                this.textBoxRemark.Text = "";
            }
            else
            {
                this.Text = "修改预算账目";
                this.textBoxNo.Text = m_yszmModel.v_yszm_no;
                this.textBoxName.Text = m_yszmModel.v_yszm_name;
                this.decimalTextBoxMoney.EditValue = m_yszmModel.f_ys_money;
                this.dateTimeStart.Value = m_yszmModel.t_date_start;
                this.dateTimeEnd.Value = m_yszmModel.t_date_end;
                this.textBoxRemark.Text = m_yszmModel.v_remark;
                this.textBoxUserName.Text = m_yszmModel.v_jz_user_name;
                this.dateTimeTallyDate.Value = m_yszmModel.t_create_time;
            }
        }

        /// <summary>
        /// 给对象赋值
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private jt_ys_zm setModelValue(jt_ys_zm model)
        {
            model.v_yszm_no = this.textBoxNo.Text.Trim();
            model.f_ys_money = this.decimalTextBoxMoney.EditValue;
            model.v_yszm_name = this.textBoxName.Text.Trim();
            model.t_date_start = this.dateTimeStart.Value;
            model.t_date_end = this.dateTimeEnd.Value;
            model.v_remark = this.textBoxRemark.Text.Trim();
            if (m_yszmModel == null)
            {
                model.v_jz_user_name = LoginAccountManager.Instance.getLoginUserModel().v_yh_name;
                model.v_jz_user_pk = LoginAccountManager.Instance.getLoginUserModel().pk.ToString();
                model.t_create_time = this.dateTimeTallyDate.Value;
            }

            return model;
        }

        /// <summary>
        /// 判断是否填了空值
        /// </summary>
        private bool estimateNull()
        {
            if (string.IsNullOrEmpty(this.textBoxNo.Text))
            {
                MessageBoxFunction.showVerifyInfoMessageBox("编码不能为空！");
                return false;
            }
            if (this.decimalTextBoxMoney.EditValue <= 0)
            {
                MessageBoxFunction.showVerifyInfoMessageBox("消费金额不能小于或等于0！");
                return false;
            }
            if (string.IsNullOrEmpty(this.textBoxName.Text))
            {
                MessageBoxFunction.showVerifyInfoMessageBox("预算用途不能为空！");
                return false;
            }
            if (this.dateTimeStart.Value > this.dateTimeEnd.Value)
            {
                MessageBoxFunction.showVerifyInfoMessageBox("开始时间不能大于结束时间！");
                return false;
            }
            return true;
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            CalculatorForm form = new CalculatorForm();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                this.decimalTextBoxMoney.EditValue = form.m_currentNumber;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (estimateNull() == false)
            {
                return;
            }

            if (m_yszmModel == null)
            {
                jt_ys_zm zmModel = new jt_ys_zm();
                zmModel = setModelValue(zmModel);
                bool isSuccess = BudgetAccountsManager.Instance.Add(zmModel);
                if (isSuccess)
                {
                    MessageBoxFunction.showSaveSuccessMessageBox();
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                m_yszmModel = setModelValue(m_yszmModel);
                bool isSuccess = BudgetAccountsManager.Instance.Update(m_yszmModel);
                if (isSuccess)
                {
                    MessageBoxFunction.showSaveSuccessMessageBox();
                    this.DialogResult = DialogResult.OK;
                }
            }
            base.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void comboBoxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.comboBoxDate.SelectedItem.ToString() == "本月")
            {
                this.dateTimeStart.Value = Convert.ToDateTime(DateTime.Today.ToString("yyyy-MM-01"));
                this.dateTimeEnd.Value = Convert.ToDateTime(this.dateTimeStart.Value.AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd"));
            }
        }
    }
}
