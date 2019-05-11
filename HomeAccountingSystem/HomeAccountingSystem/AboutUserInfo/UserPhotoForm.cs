using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HomeAccountingSystem.BLL;
using HomeAccountingSystem.MainUserControl;
using HomeAccountingSystem.Model;

namespace HomeAccountingSystem.AboutUserInfo
{
    public partial class UserPhotoForm : Form
    {
        public UserPhotoForm()
        {
            InitializeComponent();
        }

        public TopUserInfoUserControl m_topUserInfoUserControl = null;

        private void btnOK_Click(object sender, EventArgs e)
        {
            string str = "";
            for (int i = 0; i < this.tzxPanelPhoto.Controls.Count; i++)
            {
                RadioButton radioButton = this.tzxPanelPhoto.Controls[i] as RadioButton;
                if (radioButton!=null&&radioButton.Checked == true)
                {
                    str = radioButton.Text.ToString() + str;
                }
            }

            // 拼凑头像路径
            string strPhotoFileName = "photo" + str.Trim() + ".png";
            string strAllPhotoPath = Application.StartupPath+@"..\..\..\..\Resources\image\photo\" + strPhotoFileName;
            // 选择的头像保存到数据库
            this.uploadSavePhoto(strAllPhotoPath);

        }

        private void uploadSavePhoto(string strAllPhotoPath)
        {
            jt_yh_zl yhzlModel = LoginAccountManager.Instance.getLoginUserModel();
            if (yhzlModel == null)
            {
                return;
            }
            bool isUpload = UserInfoManager.Instance.UploadPhotoToDataBase(yhzlModel, strAllPhotoPath);
            if(isUpload == false)
            {
                MessageBox.Show("头像信息保存未完成！头像更换失败", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 头像图片加载
            m_topUserInfoUserControl.loadPhoto();
            base.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }
    }
}
