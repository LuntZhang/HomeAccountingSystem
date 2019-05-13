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

namespace HomeAccountingSystem.AboutUserInfo
{
    public partial class ChangePasswordForm : Form
    {

        public ChangePasswordForm()
        {
            InitializeComponent();
        }
        // 当前登录用户对象
        public jt_yh_zl m_yhzlModel = null;
        // 修改密码成功关闭页面
        public bool m_isClosePage = false;

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            m_yhzlModel = LoginAccountManager.Instance.getLoginUserModel();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (m_yhzlModel==null)
            {
                return;
            }
            if (string.IsNullOrEmpty(this.textBoxNewPwd.Text.Trim()) || string.IsNullOrEmpty( this.textBoxAgainInput.Text.Trim()))
            {
                MessageBox.Show("请不要输入空值！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.textBoxOldPwd.Text.Trim() != m_yhzlModel.v_yh_pwd)
            {
                MessageBox.Show("原密码输入错误！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.textBoxNewPwd.Text.Trim() != this.textBoxAgainInput.Text.Trim())
            {
                MessageBox.Show("两次密码输入不一致！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            m_yhzlModel.v_yh_pwd = this.textBoxNewPwd.Text.Trim();
            bool isUpdateSuccess = UserInfoManager.Instance.Update(m_yhzlModel);
            if(isUpdateSuccess==true)
            {
                MessageBox.Show("修改成功，返回登录页面！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                base.Close();
                this.m_isClosePage = true;
            }
            else
            {
                MessageBox.Show("修改失败！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.m_isClosePage = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        
    }
}
