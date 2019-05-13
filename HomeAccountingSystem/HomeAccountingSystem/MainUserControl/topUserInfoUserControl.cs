using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using HomeAccountingSystem.Model;
using HomeAccountingSystem.BLL;
using HomeAccountingSystem.AboutUserInfo;

namespace HomeAccountingSystem.MainUserControl
{
    public partial class TopUserInfoUserControl : UserControl
    {
        // 定义关闭页面的委托
        public delegate void CloseMainPage(bool isTuichu);
        public CloseMainPage delegateCloseMainPage = null;

        public TopUserInfoUserControl()
        {
            InitializeComponent();
        }

        public jt_yh_zl m_yhzlModel = null;

        private void TopUserInfoUserControl_Load(object sender, EventArgs e)
        {
            m_yhzlModel = LoginAccountManager.Instance.getLoginUserModel();
            this.labelUserName.Text = m_yhzlModel.v_yh_name;
            this.labelUserName.Text = string.Format("{0}，你好！", m_yhzlModel.v_yh_name);
            // 转换图片格式
            this.loadPhoto();
        }

        // 转换图片格式
        public void loadPhoto()
        {
            // 转换图片格式
            byte[] bytFile=UserInfoManager.Instance.getPhoto(m_yhzlModel.pk);
            if (bytFile == null)
            {
                return;
            }
            MemoryStream ms = new MemoryStream(bytFile, 0, bytFile.Length); Image ReturnImage = Image.FromStream(ms);
            this.pictureBoxPhoto.Image = ReturnImage;
        }

        // 更改头像按钮
        private void linkLabelChangePhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserPhotoForm formUserPhoto = new UserPhotoForm();
            formUserPhoto.m_topUserInfoUserControl = this;
            formUserPhoto.ShowDialog();
        }

        // 设置
        private void btnSetting_Click(object sender, EventArgs e)
        {

        }

        // 退出
        private void btnESC_Click(object sender, EventArgs e)
        {
            if(this.delegateCloseMainPage != null)
            {
                this.delegateCloseMainPage(true);
            }
        }

        // 注销
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (this.delegateCloseMainPage != null)
            {
                this.delegateCloseMainPage(false);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm formChangePassword = new ChangePasswordForm();
            formChangePassword.ShowDialog();
            // 修改成功返回登录页面
            if(formChangePassword.m_isClosePage==true)
            {
                // 不询问直接退出到注册页面
                Program.m_MainForm.m_isInquiry = false;

                if (this.delegateCloseMainPage != null)
                {
                    this.delegateCloseMainPage(false);
                }
            }
        }
    }
}
