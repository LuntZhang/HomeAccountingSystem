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
    public partial class EditBorrowAccountsForm : Form
    {
        public EditBorrowAccountsForm()
        {
            InitializeComponent();
        }
        // 预算对象
        public jt_jr_zm m_jrzmModel = null;

        private void EditBorrowAccountsForm_Load(object sender, EventArgs e)
        {
            loadPage();
        }
        /// <summary>
        /// 加载页面
        /// </summary>
        private void loadPage()
        {
            if (m_jrzmModel == null)
            {
                this.Text = "添加借出账目";
                // 账目预算信息
                this.textBoxNo.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
                this.textBoxWho.Text = "";
                this.decimalTextBoxMoney.EditValue = 0.00M;
                this.dateTimeDate.Value = DateTime.Today;
                this.textBoxDescription.Text = "";

                this.textBoxWhoBorrow.Text = "";
                this.dateTimeInputReturn.Value = DateTime.Today;
                this.textBoxUserName.Text = LoginAccountManager.Instance.getLoginUserModel().v_yh_name;
                this.dateTimeTallyDate.Value = DateTime.Now;
                this.checkBoxReturn.Checked = false;
                this.tzxDecimalTextBoxAccrual.EditValue = 0.00M;
                this.tzxDecimalTextBoxReturnMoney.EditValue = 0.00M;
                this.richTextBoxRemark.Text = "";
            }
            else
            {
                this.Text = "修改借出账目";
                this.textBoxNo.Text = m_jrzmModel.v_jrzm_no;
                this.textBoxWho.Text = m_jrzmModel.v_jr_who;
                this.decimalTextBoxMoney.EditValue = m_jrzmModel.f_jr_money;
                this.dateTimeDate.Value = m_jrzmModel.t_jr_time;
                this.textBoxDescription.Text = m_jrzmModel.v_jrzm_name;

                this.textBoxWhoBorrow.Text = m_jrzmModel.v_jr_name;
                this.dateTimeInputReturn.Value = m_jrzmModel.t_gh_time;
                this.textBoxUserName.Text = m_jrzmModel.v_jz_user_name;
                this.dateTimeTallyDate.Value = m_jrzmModel.t_create_time;
                this.checkBoxReturn.Checked = m_jrzmModel.i_gh_flag == 1 ? true : false;
                this.tzxDecimalTextBoxAccrual.EditValue = m_jrzmModel.f_accrual;
                this.tzxDecimalTextBoxReturnMoney.EditValue = m_jrzmModel.f_gh_how_money;
                this.richTextBoxRemark.Text = m_jrzmModel.v_remark;
            }
        }

        /// <summary>
        /// 给对象赋值
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private jt_jr_zm setModelValue(jt_jr_zm model)
        {
            if (model == null)
            {
                return null;
            }
            model.v_jrzm_no = this.textBoxNo.Text.Trim();
            model.v_jr_who = this.textBoxWho.Text.Trim();
            model.f_jr_money = this.decimalTextBoxMoney.EditValue;
            model.t_jr_time = this.dateTimeDate.Value;
            model.v_jrzm_name = this.textBoxDescription.Text.Trim();

            model.v_jr_name = this.textBoxWhoBorrow.Text.Trim();
            model.t_gh_time = this.dateTimeInputReturn.Value;
            model.i_gh_flag = this.checkBoxReturn.Checked == true ? 1 : 0;
            model.f_accrual = this.tzxDecimalTextBoxAccrual.EditValue;
            model.f_gh_how_money = this.tzxDecimalTextBoxReturnMoney.EditValue;
            model.v_remark = this.richTextBoxRemark.Text;
            if (m_jrzmModel == null)
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
            if (string.IsNullOrEmpty(this.textBoxWho.Text))
            {
                MessageBoxFunction.showVerifyInfoMessageBox("给谁借不能为空！");
                return false;
            }
            if (string.IsNullOrEmpty(this.textBoxWhoBorrow.Text))
            {
                MessageBoxFunction.showVerifyInfoMessageBox("给借出的不能为空！");
                return false;
            }
            return true;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (estimateNull() == false)
            {
                return;
            }

            if (m_jrzmModel == null)
            {
                jt_jr_zm zmModel = new jt_jr_zm();
                zmModel = setModelValue(zmModel);
                bool isSuccess = BorrowAccountsManager.Instance.Add(zmModel);
                if (isSuccess)
                {
                    MessageBoxFunction.showSaveSuccessMessageBox();
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                m_jrzmModel = setModelValue(m_jrzmModel);
                bool isSuccess = BorrowAccountsManager.Instance.Update(m_jrzmModel);
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

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            CalculatorForm form = new CalculatorForm();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                this.decimalTextBoxMoney.EditValue = form.m_currentNumber;
            }
        }
    }
}
