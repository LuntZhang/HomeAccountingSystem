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
    public partial class EditSpendingAccountsForm : Form
    {
        public EditSpendingAccountsForm()
        {
            InitializeComponent();
        }

        // 支出对象
        public jt_zc_zm m_zczmModel = null;

        // 数据页对象
        public SpendingAccountsForm m_spendingAccountsForm = null;

        private void EditSpendingAccountsForm_Load(object sender, EventArgs e)
        {
            if (this.loadTypeComboBox() == false)
            {
                return;
            }
            this.loadPage();
        }

        /// <summary>
        /// 加载下拉框
        /// </summary>
        private bool loadTypeComboBox()
        {
            DataTable dataTable = null;
            DataSet dataSet = null;
            // 消费用途下拉
            dataSet = ExpendTypeManager.Instance.GetList("");
            if (dataSet == null || dataSet.Tables.Count == 0)
            {
                MessageBoxFunction.showWarningMessageBox("没有支出类型，请先去创建支出类型！");
                base.Close();
                return false;
            }
            dataTable = dataSet.Tables[0];
            if (dataTable == null && dataTable.Rows.Count == 0)
            {
                MessageBoxFunction.showWarningMessageBox("没有支出类型，请先去创建支出类型！");
                base.Close();
                return false;
            }
            this.comboBoxType.DataSource = dataTable;
            this.comboBoxType.DisplayMember = "v_zclx_name";
            this.comboBoxType.ValueMember = "pk";

            // 支付方式
            dataSet = PaymentTypeManager.Instance.GetList("");
            if (dataSet == null || dataSet.Tables.Count == 0)
            {
                MessageBoxFunction.showWarningMessageBox("没有支付方式，请先去创建支付方式！");
                base.Close();
                return false;
            }
            dataTable = dataSet.Tables[0];
            if (dataTable == null && dataTable.Rows.Count == 0)
            {
                MessageBoxFunction.showWarningMessageBox("没有支付方式，请先去创建支付方式！");
                base.Close();
                return false;
            }
            this.comboBoxPayType.DataSource = dataTable;
            this.comboBoxPayType.DisplayMember = "v_zffs_name";
            this.comboBoxPayType.ValueMember = "pk";
            return true;
        }

        /// <summary>
        /// 加载页面
        /// </summary>
        private void loadPage()
        {
            if(m_zczmModel == null)
            {
                this.Text = "添加消费记录账目";
                // 账目支出基本信息
                this.textBoxNo.Text = "";
                this.decimalTextBoxMoney.EditValue = 0.00M;
                this.comboBoxType.SelectedIndex = 0;
                this.dateTimeDate.Value = DateTime.Today;
                this.textBoxDescription.Text = "";
                // 账目支出记账信息
                this.textBoxWho.Text = "";
                this.comboBoxPayType.SelectedIndex = 0;
                this.textBoxUserName.Text = LoginAccountManager.Instance.getLoginUserModel().v_yh_name;
                this.dateTimeTallyDate.Value = DateTime.Now;
                this.richTextBoxRemark.Text = "";
            }
            else
            {
                this.Text = "修改消费记录账目";
                // 账目支出基本信息
                this.textBoxNo.Text = m_zczmModel.v_zczm_no;
                this.decimalTextBoxMoney.EditValue = m_zczmModel.f_zc_money;
                this.comboBoxType.SelectedItem = m_zczmModel.v_zclx_name;
                this.dateTimeDate.Value = m_zczmModel.t_xf_time;
                this.textBoxDescription.Text = m_zczmModel.v_zczm_name;
                // 账目支出记账信息
                this.textBoxWho.Text = m_zczmModel.v_who;
                this.comboBoxPayType.SelectedItem = m_zczmModel.v_zffs_name;
                this.textBoxUserName.Text = m_zczmModel.v_jz_user_name;
                this.dateTimeTallyDate.Value = m_zczmModel.t_create_time;
                this.richTextBoxRemark.Text = m_zczmModel.v_remark;
            }
        }

        /// <summary>
        /// 给对象赋值
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private jt_zc_zm setModelValue(jt_zc_zm model)
        {
            model.v_zczm_no = this.textBoxNo.Text.Trim();
            model.f_zc_money = this.decimalTextBoxMoney.EditValue;
            model.v_zclx_no = this.comboBoxType.SelectedValue.ToString();
            model.v_zclx_name = this.comboBoxType.SelectedItem.ToString();
            model.t_xf_time = this.dateTimeDate.Value;
            model.v_zczm_name = this.textBoxDescription.Text.Trim();

            model.v_who = this.textBoxWho.Text.Trim();
            model.v_zffs_name = this.comboBoxPayType.SelectedItem.ToString();
            model.v_zczm_no = this.comboBoxPayType.SelectedValue.ToString();
            model.v_remark = this.richTextBoxRemark.Text.Trim();
            if (m_zczmModel == null)
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
            if(string.IsNullOrEmpty(this.textBoxNo.Text))
            {
                MessageBoxFunction.showVerifyInfoMessageBox("编码不能为空！");
                return false;
            }
            if (this.decimalTextBoxMoney.EditValue<=0)
            {
                MessageBoxFunction.showVerifyInfoMessageBox("消费金额不能小于或等于0！");
                return false;
            }
            if (string.IsNullOrEmpty(this.textBoxWho.Text))
            {
                MessageBoxFunction.showVerifyInfoMessageBox("给谁消费的不能为空！");
                return false;
            }
            return true;
        }
        // 保存
        private void btnOK_Click(object sender, EventArgs e)
        {
            if(estimateNull()==false)
            {
                return;
            }

            if (m_zczmModel == null)
            {
                jt_zc_zm zmModel = new jt_zc_zm();
                zmModel = setModelValue(zmModel);
                bool isSuccess = ExpendAccountsManager.Instance.Add(zmModel);
                if(isSuccess)
                {
                    MessageBoxFunction.showSaveSuccessMessageBox();
                }
            }
            else
            {
                m_zczmModel = setModelValue(m_zczmModel);
                bool isSuccess = ExpendAccountsManager.Instance.Update(m_zczmModel);
                if (isSuccess)
                {
                    MessageBoxFunction.showSaveSuccessMessageBox();
                }
            }
        }

        // 取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            CalculatorForm form = new CalculatorForm();
            form.ShowDialog();
        }
    }
}
