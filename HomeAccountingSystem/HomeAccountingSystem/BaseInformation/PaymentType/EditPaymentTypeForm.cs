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

namespace HomeAccountingSystem.BaseInformation.PaymentType
{
    public partial class EditPaymentTypeForm : Form
    {
        public EditPaymentTypeForm()
        {
            InitializeComponent();
        }
        // 支付类型主页对象
        public PaymentTypeForm m_paymentTypeForm = null;
        // 新增或修改
        //public bool m_isAdd = true;
        // 支付类型对象
        public jt_zffs m_zffsModel = null;

        private void EditPaymentTypeForm_Load(object sender, EventArgs e)
        {
            this.loadPage();

        }
        /// <summary>
        /// 加载页面
        /// </summary>
        private void loadPage()
        {
            if(m_zffsModel ==null)
            {
                this.textBoxNo.Text = "";
                this.textBoxName.Text = "";
                this.comboBoxSelected.SelectedIndex =0;
            }
            else
            {
                this.textBoxNo.Text = m_zffsModel.v_zffs_no;
                this.textBoxName.Text = m_zffsModel.v_zffs_name;
                this.comboBoxSelected.SelectedIndex = m_zffsModel.i_zffs_lx;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBoxNo.Text.Trim())|| string.IsNullOrEmpty(this.textBoxName.Text.Trim()))
            {
                MessageBox.Show("请填写信息！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (m_zffsModel == null)
            {
                jt_zffs model = new jt_zffs();
                model.v_zffs_no = this.textBoxNo.Text.Trim();
                model.v_zffs_name = this.textBoxName.Text.Trim();
                model.i_zffs_lx = this.comboBoxSelected.SelectedIndex;
                model.t_create_time = DateTime.Now;
                bool isSuccess = PaymentTypeManager.Instance.Add(model);
                if(isSuccess)
                {
                    MessageBox.Show("添加成功！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    m_paymentTypeForm.loadDataList();
                }
            }
            else
            {
                m_zffsModel.v_zffs_no = this.textBoxNo.Text.Trim();
                m_zffsModel.v_zffs_name = this.textBoxName.Text.Trim();
                m_zffsModel.i_zffs_lx = this.comboBoxSelected.SelectedIndex;
                bool isSuccess = PaymentTypeManager.Instance.Update(m_zffsModel);
                if (isSuccess)
                {
                    MessageBox.Show("修改成功！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    m_paymentTypeForm.loadDataList();
                    base.Close();
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }
    }
}
