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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.instancePage();
        }

        /// <summary>
        /// 初始化注册页面
        /// </summary>
        private void instancePage()
        {
            this.textBoxAccount.Text = "";
            this.textBoxName.Text = "";
            this.textBoxPwd.Text = "";
            this.textBoxAgainPwd.Text = "";
            this.textBoxPhone.Text = "";
            this.radioButtonUser.Checked = true;
        }

        private void btnAccountGenerated_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(this.textBoxAccount.Text.Trim()))
            {
                MessageBox.Show("账号已生成！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 以当前时间作为账号
            string strAccount = DateTime.Now.ToString("yyyyMMddHHmmss");
            this.textBoxAccount.Text = strAccount;
        }

        private void tzxRoundedButtonRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBoxAccount.Text.Trim()))
            {
                MessageBox.Show("账号不能为空！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(this.textBoxName.Text.Trim()))
            {
                MessageBox.Show("姓名不能为空！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(this.textBoxName.Text.Trim()))
            {
                MessageBox.Show("密码不能为空！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("确定已填写好信息并注册？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information)!= DialogResult.Yes)
            {
                return;
            }

            jt_yh_zl yhzlModel = new jt_yh_zl();
            yhzlModel.v_yh_no = this.textBoxAccount.Text;
            yhzlModel.v_yh_name = this.textBoxName.Text;
            yhzlModel.v_yh_pwd = this.textBoxPwd.Text;
            yhzlModel.v_phone = this.textBoxPhone.Text;
            yhzlModel.i_yh_type = this.radioButtonUser.Checked ? 1 : 2;
            bool isAddSuccess = UserInfoManager.Instance.Add(yhzlModel);
            if(isAddSuccess==true)
            {
                MessageBox.Show("注册成功！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("注册失败！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
