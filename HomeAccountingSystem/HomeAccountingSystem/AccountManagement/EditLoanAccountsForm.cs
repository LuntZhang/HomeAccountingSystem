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
    public partial class EditLoanAccountsForm : Form
    {
        public EditLoanAccountsForm()
        {
            InitializeComponent();
        }
        // 预算对象
        public jt_jc_zm m_jczmModel = null;

        private void EditLoanAccountsForm_Load(object sender, EventArgs e)
        {
            loadPage();
        }
        /// <summary>
        /// 加载页面
        /// </summary>
        private void loadPage()
        {
            if (m_jczmModel == null)
            {
                this.Text = "添加借出账目";
                // 账目预算信息
                this.textBoxNo.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
                this.textBoxWho.Text = "";
                this.decimalTextBoxMoney.EditValue = 0.00M;
                this.dateTimeDate.Value = DateTime.Today;
                this.textBoxDescription.Text = "";
                
                this.textBoxWhoLoan.Text = "";
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
                this.textBoxNo.Text = m_jczmModel.v_jczm_no;
                this.textBoxWho.Text = m_jczmModel.v_jc_who;
                this.decimalTextBoxMoney.EditValue = m_jczmModel.f_jc_money;
                this.dateTimeDate.Value = m_jczmModel.t_jc_time;
                this.textBoxDescription.Text = m_jczmModel.v_jczm_name;

                this.textBoxWhoLoan.Text = m_jczmModel.v_jc_name;
                this.dateTimeInputReturn.Value = m_jczmModel.t_gh_time;
                this.textBoxUserName.Text = m_jczmModel.v_jz_user_name;
                this.dateTimeTallyDate.Value = m_jczmModel.t_create_time;
                this.checkBoxReturn.Checked = m_jczmModel.i_gh_flag == 1 ? true : false;
                this.tzxDecimalTextBoxAccrual.EditValue = m_jczmModel.f_accrual;
                this.tzxDecimalTextBoxReturnMoney.EditValue = m_jczmModel.f_gh_how_money;
                this.richTextBoxRemark.Text = m_jczmModel.v_remark;
            }
        }

        /// <summary>
        /// 给对象赋值
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private jt_jc_zm setModelValue(jt_jc_zm model)
        {
            if (model == null)
            {
                return null;
            }
            model.v_jczm_no = this.textBoxNo.Text.Trim();
            model.v_jc_who = this.textBoxWho.Text.Trim();
            model.f_jc_money = this.decimalTextBoxMoney.EditValue;
            model.t_jc_time = this.dateTimeDate.Value;
            model.v_jczm_name = this.textBoxDescription.Text.Trim();

            model.v_jc_name = this.textBoxWhoLoan.Text.Trim();
            model.t_gh_time = this.dateTimeInputReturn.Value ;
            model.i_gh_flag = this.checkBoxReturn.Checked  == true ?  1: 0;
            model.f_accrual = this.tzxDecimalTextBoxAccrual.EditValue  ;
            model.f_gh_how_money= this.tzxDecimalTextBoxReturnMoney.EditValue  ;
            model.v_remark =  this.richTextBoxRemark.Text  ;
            if (m_jczmModel == null)
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
            if (string.IsNullOrEmpty(this.textBoxWhoLoan.Text))
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

            if (m_jczmModel == null)
            {
                jt_jc_zm zmModel = new jt_jc_zm();
                zmModel = setModelValue(zmModel);
                bool isSuccess = LoanAccountsManager.Instance.Add(zmModel);
                if (isSuccess)
                {
                    MessageBoxFunction.showSaveSuccessMessageBox();
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                m_jczmModel = setModelValue(m_jczmModel);
                bool isSuccess = LoanAccountsManager.Instance.Update(m_jczmModel);
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
