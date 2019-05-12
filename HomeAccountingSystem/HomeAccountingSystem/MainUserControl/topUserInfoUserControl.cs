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

       
    }
}
