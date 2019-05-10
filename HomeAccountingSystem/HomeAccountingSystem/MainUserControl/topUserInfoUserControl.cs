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

namespace HomeAccountingSystem.MainUserControl
{
    public partial class TopUserInfoUserControl : UserControl
    {
        public TopUserInfoUserControl()
        {
            InitializeComponent();
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
    }
}
