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
            // 转换图片格式
            this.loadPhoto();
        }

        // 转换图片格式
        public void loadPhoto()
        {
            if(m_yhzlModel.v_photo==null)
            {
                return;
            }
            // 转换图片格式
            MemoryStream ms = new MemoryStream(m_yhzlModel.v_photo);
            Image ReturnImage = Image.FromStream(ms);
            this.pictureBoxPhoto.Image = ReturnImage;
        }

        private void tzxButtonRegister_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "选择要上传的图片";

            ofd.Filter = "All Files(*.*)|*.*|位图(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg";

            ofd.ShowDialog();

            if (!File.Exists(ofd.FileName))
            {
                MessageBox.Show("照片为空");
                return;
            }



        }

        private void linkLabelChangePhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserPhotoForm formUserPhoto = new UserPhotoForm();
            formUserPhoto.m_topUserInfoUserControl = this;
            formUserPhoto.ShowDialog();
        }

       
    }
}
